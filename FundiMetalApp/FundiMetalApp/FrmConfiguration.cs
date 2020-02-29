using fundimetal.Core;
using fundimetal_core.Model;
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

namespace Fundimetal.App
{
    public partial class FrmConfiguration : Form
    {

        private string rutaXmlCLiente = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\TablaClientes.xml";
        private string rutaXmlRutas = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\Rutas.xml";
        private string rutaXmlInfoCliente = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\InfoClientes.xml";

        private XmlDocument xDocCliente,xDocRutas,XDocInfoClientes;

        private IRepository _repository = new XmlRepository();
        public FrmConfiguration()
        {
            InitializeComponent();
        }

        private void FrmConfiguration_Load(object sender, EventArgs e)
        {
            LoadConfigurationBase();
        }

        private void LoadConfigurationBase()
        {
            //Carga de tabla de cliente
            xDocCliente = new XmlDocument();
            xDocCliente.Load(rutaXmlCLiente);

            XDocInfoClientes = new XmlDocument();
            XDocInfoClientes.Load(rutaXmlInfoCliente);

            LoadConfigurationCliente();
            LoadConfigurationPath();
            LoadConfigInfoClientes();

         
        }

        /// <summary>
        /// Lectura de configuracion de rutas
        /// </summary>
        private void LoadConfigurationPath()
        {
            if (!File.Exists(rutaXmlRutas))
            {
                MessageBox.Show("La información de rutas no se encuentra en carpeta de Referencias");
            }
            else
            {
                xDocRutas = new XmlDocument();
                xDocRutas.Load(rutaXmlRutas);


                #region Tabla de rutas
                DataTable dtElementos = new DataTable();
                dtElementos.Columns.Add("Ruta", typeof(string));

                XmlNodeList RutaXmlFiles = xDocRutas.SelectNodes("/ConfiguracionRutas/RutaXmlFuente/File");
                dtagrid_xml_fuente.Rows.Clear();

                foreach (XmlNode item in RutaXmlFiles)
                {
                    dtagrid_xml_fuente.Rows.Add(item.Attributes["id"].InnerText, item.InnerText);
                } 
                #endregion


                var rutaGeneraPDF = xDocRutas.SelectSingleNode("/ConfiguracionRutas/RutaGeneracionCertificados");

                txt_ruta_pdf.Text = rutaGeneraPDF.InnerText;
                //txt_xml_ruta.Text = rutaXml.InnerText;

            }

        }

        public void LoadConfigurationCliente()
        {
            DataTable infoCliente = _repository.getEspecificacionClientes(xDocCliente);

            // Carga informacion solo de cliente
            dataGridCliente.DataSource = infoCliente;
        }


        public void LoadConfigInfoClientes()
        {
            DataTable infoCliente = _repository.getInfoClientes(XDocInfoClientes);

            // Carga informacion solo de cliente
            datagridClientesListado.DataSource = infoCliente;
        }


        private void editar_cliente_Click(object sender, EventArgs e)
        {


            if (dataGridCliente.SelectedRows.Count > 0)
            {
                this.OpenFormEditarCliente();
            }
            else
            {
                MessageBox.Show("Debe primero seleccionar una fila");
            }

            
        }

        private void OpenFormEditarCliente()
        {

            //dataGridCliente.CurrentRow.Cells["Lote"].Value.ToString();

            ClienteModel cliente = new ClienteModel();


            cliente = _repository.GetClienteById( dataGridCliente.CurrentRow.Cells[0].Value.ToString());

            ///Esto permite el momento de cerrar de guarda se pueda refrescar la grid y mostrar nuevos registros
            FrmClienteNuevo formClienteNuevo = new FrmClienteNuevo(cliente);
            formClienteNuevo.ShowDialog();
         this.LoadConfigurationBase();
                
            
        }

        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {

            FrmClienteNuevo formClienteNuevo = new FrmClienteNuevo();

            formClienteNuevo.ShowDialog();
            this.LoadConfigurationBase();
                
        }

        /// <summary>
        /// Boton de busqueda de archivo XMl del espectometro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_find_1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Archivos XML |*.xml;*.XML";
            openFileDialog1.Title = "Seleccione archivo Xml";
            openFileDialog1.FileName = "Low Alloy Pb.xml";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_xml_ruta.Text = openFileDialog1.FileName;
                
            }
        }

        /// <summary>
        /// Permite guardar la configuracion de las rutas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bnt_save_rutas_Click(object sender, EventArgs e)
        {
            #region Validacion de entrada de datos
            if (!Directory.Exists(txt_ruta_pdf.Text))
            {
                MessageBox.Show("La ruta completa Xml Fuente no es válido o no existe", "Validación");
                return;
            }


            //if (!File.Exists(txt_xml_ruta.Text))
            //{
            //    MessageBox.Show("La ruta del XML fuente no es válida ó no existe", "Validación");
            //    return;
            //} 
            #endregion

            if ((MessageBox.Show("Confirma que desea guardar los cambios", "Confirmación",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {

                //Valor de cada celda
                SaveConfigurationPaths();
            }
        }

        /// <summary>
        /// Metodo que guarda la configuracion de rutas
        /// </summary>
        private void SaveConfigurationPaths()
        {

            try
            {
                //xDocRutas.SelectSingleNode("/ConfiguracionRutas/RutaXmlFuente").InnerText = txt_xml_ruta.Text;
                xDocRutas.SelectSingleNode("/ConfiguracionRutas/RutaGeneracionCertificados").InnerText = txt_ruta_pdf.Text;

                             
                //Borrado de todos los nodos
                XmlNode xnodeDet = xDocRutas.SelectSingleNode("/ConfiguracionRutas/RutaXmlFuente");
                XmlNodeList xnodeList = xDocRutas.SelectNodes("/ConfiguracionRutas/RutaXmlFuente/File");
                foreach (XmlNode item in xnodeList) { xnodeDet.RemoveChild(item); }



                foreach (DataGridViewRow row in dtagrid_xml_fuente.Rows)
                {
                    //Nuevo nodo
                    XmlElement nodeElemento = xDocRutas.CreateElement("File");
                    nodeElemento.SetAttribute("id", row.Cells[0].Value.ToString());
                    nodeElemento.InnerText = row.Cells[1].Value.ToString();

                    xnodeDet.AppendChild(nodeElemento);
                }


                xDocRutas.Save(rutaXmlRutas);
                MessageBox.Show("Guardado con éxito", "Confirmación",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en guardado de datos","Error");
                throw;
            }
         




        }

        private void btn_close_win_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Boton que permite adicionar ruta de archivo fuente XML a la grilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_grid_Click(object sender, EventArgs e)
        {
            var rutaNueva =  txt_xml_ruta.Text;
            if (rutaNueva.Length == 0 )
            {
                MessageBox.Show("Debe ingresar una ruta válida","Error");
                return;
            }

            if (!File.Exists(rutaNueva))
            {
                MessageBox.Show("El archivo ingresa no es válido ó no es posible accederlo ","Error");
                return;
            }
            var numId = dtagrid_xml_fuente.Rows.Count + 1;
            dtagrid_xml_fuente.Rows.Add(numId, rutaNueva);
        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            if (datagridClientesListado.SelectedRows.Count > 0)
            {
                this.OpenFormEditarInfoCliente();
            }
            else
            {
                MessageBox.Show("Debe primero seleccionar una fila");
            }
        }

        private void OpenFormEditarInfoCliente()
        {

            ClienteModel cliente = new ClienteModel();


            cliente = _repository.GetInfoClienteById(datagridClientesListado.CurrentRow.Cells[0].Value.ToString());

            ///Esto permite el momento de cerrar de guarda se pueda refrescar la grid y mostrar nuevos registros
            FrmInfoCliente formClienteNuevo = new FrmInfoCliente(cliente);
            formClienteNuevo.ShowDialog();
            this.LoadConfigurationBase();
        }

        /// <summary>
        /// Permite abrir formuario de ventana nueva pra informacion  cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            FrmInfoCliente frm = new FrmInfoCliente();

            frm.ShowDialog();
            this.LoadConfigurationBase();
        }

        private void btn_select_folder_path_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                    txt_ruta_pdf.Text = fbd.SelectedPath;
                }
            }

        }
    }
}
