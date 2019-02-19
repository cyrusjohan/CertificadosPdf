using fundimetal.Core;
using fundimetal_core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Fundimetal.App
{
    public partial class FrmVisor : Form
    {
        #region Vars
        private DataTable dtDatosCompletos = new DataTable(); //DataTable
        private IRepository _repository = new XmlRepository();

        public string RutaXmlFuente = "";
        public string RutaSalidaCertificados = "";

        private string rutaXmlCLiente = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\TablaClientes.xml";
        private XmlDocument xDocCliente;
        #endregion

        #region Metodos Publicos
        public FrmVisor()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Inicio de controles formulario       

            this.CargaReferenciales();
            this.SetupControls();

        }

        #endregion

        #region Metodos privados

        private void SetupControls()
        {
            this.MakeDataGrid();
            // Lista de Clientes   
            cmb_especificacion_cliente.DataSource = null;
            cmb_especificacion_cliente.DisplayMember = "Text";
            cmb_especificacion_cliente.ValueMember = "Value";
            cmb_especificacion_cliente.BindingContext = new BindingContext();
            
            cmb_especificacion_cliente.DataSource = _repository.GetInfoClientesComboBox();


        }


        /// <summary>
        /// Permite la creacion de la grid view
        /// </summary>
        private void MakeDataGrid()
        {
            List<String> Errors = new List<string>();
            try
            {
                dtDatosCompletos = _repository.GetAllDataBurns(Errors,this.RutaXmlFuente);

                if (dtDatosCompletos == null)
                {
                    MessageBox.Show(Errors[0].ToString());
                    return;
                }


                dataGridVisor.DataSource = dtDatosCompletos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la lectura de archivo XMl");
                return;
            }


            
        }


        private void CargaReferenciales()
        {
            ReaderPath objReader = new ReaderPath();
            // ruta del archivo fuente de datos
            this.RutaXmlFuente = objReader.getRutaXmlSalida();

            if (!File.Exists(this.RutaXmlFuente))
            {
                    MessageBox.Show(String.Format("El archivo fuente Xml {0} no existe.", this.RutaXmlFuente));
                    return;
            }

            // Ruta de salida del archivo PDF
            this.RutaSalidaCertificados = objReader.getRutaGeneracionCertificados();

            if  (string.IsNullOrWhiteSpace(this.RutaSalidaCertificados))
            {
                MessageBox.Show(String.Format("La ruta de salida de certificados no esta configurada."));
                return;
            }
            
            
            //Creacion de carpeta de salida
            if (!Directory.Exists(this.RutaSalidaCertificados))
            {
                Directory.CreateDirectory(this.RutaSalidaCertificados);
            }




            if (!File.Exists(this.rutaXmlCLiente))
            {
                MessageBox.Show(String.Format("El archivo fuente Xml  de clientes {0} no existe.", this.rutaXmlCLiente));
                return;
            }
            else
            {
                xDocCliente = new XmlDocument();
                xDocCliente.Load(rutaXmlCLiente);
            }
           

        }

        #endregion
        /// <summary>
        /// Permite la generacion de certificado en PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
          
             if (dataGridVisor.SelectedRows.Count > 0 )
            {
                if ((MessageBox.Show("Confirma que desea generar PDF", "Generar PDF",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                  
                    //Valor de cada celda
                    PdfGenerator();
                }
               
               
            }
            else
            {
                MessageBox.Show("Debe primero seleccionar una fila");
            }
        }



        /// <summary>
        /// Permit le generacion del documento y llamado a componentes
        /// </summary>
        private void PdfGenerator()
        {
            // Extraemos el Id del Cliente           
            var ItemSelected = cmb_especificacion_cliente.SelectedItem;
            string IdCliente = ((ListItemCombo)ItemSelected).Value;

            // Obtenemos informacion del cliente
            DataTable especficacionCliente = _repository.GetInfoClientesById (IdCliente);

            String  LoteAnalizado = dataGridVisor.CurrentRow.Cells["Lote"].Value.ToString();

            DataTable TablaAnalisQuimico = this.GetInfoTablaAnalisis(dataGridVisor.CurrentRow , especficacionCliente);

            ReaderPath objReader = new ReaderPath();
            this.RutaSalidaCertificados = objReader.getRutaGeneracionCertificados();

            FileGenerator objGenerator = new FileGenerator(this.RutaSalidaCertificados, LoteAnalizado);
            try
            {

                Cursor = Cursors.WaitCursor;
                
                //objGenerator.setData();
                objGenerator.ToMake(TablaAnalisQuimico);
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Format("Error: {0}", exc.Message),
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                addlog(exc.ToString() + exc.Message);
                return;
                throw;
            }
            finally {
                Cursor = Cursors.Arrow;
            }


            // open generated pdf
            try
            {
                System.Diagnostics.Process.Start(objGenerator.RutaSalidaArchivosPDF);
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se puede abrir el PDF , instale un software para visualizar",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addlog(exc.ToString() + exc.Message);
            }

            /// Si la opcion de enviar correo esta habilitada
            if (chk_send_email.Checked)
            {
                List<String> archivoAdjuntos = new List<string>
                {
                    objGenerator.RutaSalidaArchivosPDF
                };

                try
                {
                    MailManager mailManager = new MailManager
                    {
                        ArchivosAdjunto = archivoAdjuntos
                    };

                    mailManager.SendMail();
                }
                catch (Exception exc )
                {
                    MessageBox.Show("Ha ocurrido un error al enviar el correo, revise configuración de servidor");
                    addlog(exc.ToString()  +  exc.Message);
                }
               
            }


        }


        /// <summary>
        /// Guarda en log de archivo los errores 
        /// </summary>
        /// <param name="text"></param>
        private void addlog(string text)
        {
            string namefileLog = string.Format("log_errores_{0}.txt",DateTime.Now.ToString("yyymmdd"));
            string fileName = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, namefileLog);


            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine("Linea adicionada {0}", DateTime.Now.ToString());
                sw.WriteLine("Error:");

                sw.WriteLine(text);
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("Fin! ");
            }
        }


        /// <summary>
        /// Permite la creacion de la tabla a mostrar 
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="especficacionCliente"></param>
        /// <returns></returns>
        private DataTable GetInfoTablaAnalisis(DataGridViewRow currentRow, DataTable especficacionCliente)
        {
            DataTable dtInfoAnalisis = new DataTable();
                     
            dtInfoAnalisis.Columns.Add("Elemento", typeof(string));
            dtInfoAnalisis.Columns.Add("Simbolo", typeof(string));
            dtInfoAnalisis.Columns.Add("Analizado", typeof(string));
            dtInfoAnalisis.Columns.Add("Permitido", typeof(string));


            foreach (DataGridViewCell Cell in currentRow.Cells)
            {
                
                foreach (DataRow rowClienteEspecificacion in especficacionCliente.Rows)
                {
                    //Buscamos las coincidencia por elemento entre las tablas
                    if (Cell.OwningColumn.HeaderText.ToUpper() == rowClienteEspecificacion["Simbolo"].ToString().ToUpper())
                    {

                        dtInfoAnalisis.Rows.Add(
                            rowClienteEspecificacion["Nombre"].ToString(), // Nombre Elemento Ej: Estaño, Cobre
                             rowClienteEspecificacion["Simbolo"].ToString(),
                             Cell.Value.ToString(),  //Valor analizado promedio
                             "< "+ rowClienteEspecificacion["Max"].ToString() // Maximo permitido
                            );


                    }
                }

            }

            return dtInfoAnalisis;
        }

      

        private void bnt_recargar_info_Click(object sender, EventArgs e)
        {
            this.CargaReferenciales();
            //this.MakeDataGrid();
            this.SetupControls();
            
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var valor = cmb_especificacion_cliente.SelectedValue.ToString();
            var SelectedItem = cmb_especificacion_cliente.SelectedItem.ToString();

            MessageBox.Show("Valor :" + valor + " SelectedItem: " + SelectedItem);
        }
    }
}
