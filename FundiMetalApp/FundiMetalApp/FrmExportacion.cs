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
using fundimetal.Core;
using fundimetal_core;
using fundimetal_core.Model;

namespace Fundimetal.App
{
    public partial class FrmExportacion : Form
    {

        public DataGridView _datosVisor = new DataGridView();
        public DataTable _dtEspecificacionCLiente;

        public ExportacionModel _exportacionModel;

        public string RutaSalidaCertificados { get; private set; }
        public string RutaConsecutivo { get; private set; }
        private IRepository _repository = new XmlRepository();

        public FrmExportacion()
        {
            InitializeComponent();
        }

        public FrmExportacion(DataGridView datos_visor_exportacion, DataTable especficacionCliente)
        {
            InitializeComponent();
            _datosVisor = datos_visor_exportacion;
            _dtEspecificacionCLiente = especficacionCliente;

            this.RutaConsecutivo = string.Format("{0}\\{1}", AppDomain.CurrentDomain.BaseDirectory, "Referencia\\consecutivo-exportacion.txt");



        }

        


      
        /**
         * Permite cargar informacion de la tabla de composicion quimica
         * 
         **/
        private void loadInformationInit()
        {
            if (this.datagrid_elementos == null)
            {
                this.datagrid_elementos = new DataGridView();
            }
            else
            {
                this.datagrid_elementos.DataSource = null;
            }

            DataTable dtElementos = this.getDataTableElementos(_datosVisor, _dtEspecificacionCLiente);
            this.datagrid_elementos.DataSource = dtElementos;
            this.datagrid_melts.DataSource = this.getDataMelts(dtElementos);

        }

        private DataTable getDataMelts(DataTable dtElementos)
        {
            DataTable dtMelts = new DataTable("tabla_melts");

            var lotes = dtElementos.AsEnumerable().Select(x => new { Name = x.Field<String>("Melts") });

            var count = lotes.Count();

            List<String> list_lotes = new List<string>();

            foreach (var item in lotes)
            {
                if (list_lotes.IndexOf(item.Name) < 0)
                {
                    list_lotes.Add(item.Name);
                }
            }

            foreach (var item in list_lotes)
            {
                dtMelts.Columns.Add(item, typeof(string));
            }
          
            DataRow drow = dtMelts.NewRow();

            foreach (DataColumn column in dtMelts.Columns) {
              
                drow[column] = 0;
            }
            dtMelts.Rows.Add(drow);



            return dtMelts;
        }


        //Permite obtener la informacion delos elementos de manera ordenada
        private DataTable getDataTableElementos(DataGridView datosVisor, DataTable especficacionCliente)
        {
            DataTable dtElementos = new DataTable("tabla_elementos");

            //Crear columnas  voy por aca toca enviar al especificacion  primeero


            // Primea columna con el valor del lote
            dtElementos.Columns.Add("Melts", typeof(string));


            foreach (DataRow rowClienteEspecificacion in especficacionCliente.Rows)
            {
                //Creacion de columnas
                dtElementos.Columns.Add(rowClienteEspecificacion["Simbolo"].ToString(), typeof(string));
            }




            // Itera por cada uno de las filas del visor filas seleccionadas
            for (int i = 0; i < _datosVisor.SelectedRows.Count; i++)
            {
               
                DataRow drow = dtElementos.NewRow();


                for (int j = 0; j < _datosVisor.SelectedRows[i].Cells.Count; j++)
                {

                    var name_column = datosVisor.SelectedRows[i].Cells[j].OwningColumn.HeaderText;

                    //Columnas de cada tabla ya creada
                    foreach (DataColumn column in dtElementos.Columns)
                    {
                      
           
                        if (column.ColumnName.ToUpper() == _datosVisor.SelectedRows[i].Cells[j].OwningColumn.HeaderText.ToUpper())
                        {
                            drow[column] = _datosVisor.SelectedRows[i].Cells[j].Value;
                        }

                        if (column.ColumnName.Equals("Melts") && _datosVisor.SelectedRows[i].Cells[name_column].OwningColumn.HeaderText.ToUpper().Equals("LOTE") )
                        {
                            drow[column] = _datosVisor.SelectedRows[i].Cells[j].Value;
                        }
                    }

                        
                }
                dtElementos.Rows.Add(drow);
                // this.datagrid_elementos.Rows[index].Cells[0].Value = _datosVisor.SelectedRows[i].Cells[0].Value.ToString();
                // this.datagrid_elementos.Rows[index].Cells[1].Value = _datosVisor.SelectedRows[i].Cells[1].Value.ToString();

            }

            //foreach (DataGridViewCell Cell in currentRow.Cells)
            //{
            //    //Buscamos las coincidencia por elemento entre las tablas
            //    if (Cell.OwningColumn.HeaderText.ToUpper() == rowClienteEspecificacion["Simbolo"].ToString().ToUpper())
            //    {


            //        //decimal valor_analizado = Convert.ToDecimal(Cell.Value.ToString());
            //        //decimal valor_max = Convert.ToDecimal(rowClienteEspecificacion["Max"].ToString());

            //        dtInfoAnalisis.Rows.Add(
            //            rowClienteEspecificacion["Nombre"].ToString(), // Nombre Elemento Ej: Estaño, Cobre
            //             rowClienteEspecificacion["Simbolo"].ToString(),
            //             Cell.Value.ToString(),  //Valor analizado promedio,
            //             rowClienteEspecificacion["Min"].ToString(),
            //              rowClienteEspecificacion["Max"].ToString() // Maximo permitido
            //            );


            //    }
            //}


            //for (int i = 0; i < _datosVisor.SelectedRows.Count; i++)
            //{
            //    int index = this.datagrid_elementos.Rows.Add();
            //    this.datagrid_elementos.Rows[index].Cells[0].Value = _datosVisor.SelectedRows[i].Cells[0].Value.ToString();
            //    this.datagrid_elementos.Rows[index].Cells[1].Value = _datosVisor.SelectedRows[i].Cells[1].Value.ToString();

            //}


            return dtElementos;
        }

        private void FrmExportacion_Load(object sender, EventArgs e)
        {
            this.loadInformationInit();
            this._exportacionModel = new ExportacionModel();

            this.cmb_producto.SelectedIndex = 0;
            this.cmb_presentacion.SelectedIndex = 0;

           
            var numeroConse = File.ReadAllText(this.RutaConsecutivo, Encoding.Default);
            this.lbl_certificado_numero.Text = DateTime.Now.ToString("yyyyMMdd") +"-"+ numeroConse;

            this.setupControles();

        }

        private void setupControles()
        {
            // Lista de Clientes   
            cmb_cliente.DataSource = null;
            cmb_cliente.DisplayMember = "Text";
            cmb_cliente.ValueMember = "Value";
            cmb_cliente.BindingContext = new BindingContext();

            cmb_cliente.DataSource = _repository.GetInformacionClientesComboBox();
        }


        /// <summary>
        /// Boton que permite generar reporte exportación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_generar_pdf_exportacion_Click(object sender, EventArgs e)
        {
           
            // Load Information to model
            var idCliente = cmb_cliente.SelectedValue.ToString();
            var clienteModel = _repository.GetInfoClienteById(idCliente);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(clienteModel.NombreCliente);
            sb.AppendLine(clienteModel.Descripcion);

            this._exportacionModel.Cliente = sb.ToString();


            _exportacionModel.NumeroCertificado = lbl_certificado_numero.Text;

            this._exportacionModel.Producto = cmb_producto.SelectedItem.ToString();
            this._exportacionModel.NumeroFactura = txt_factura.Text;
            this._exportacionModel.PesoNeto =    Convert.ToInt32( txt_peso_neto.Text);
            this._exportacionModel.PesoBruto =    Convert.ToInt32( txt_peso_bruto.Text);
            this._exportacionModel.MarcaEmbalaje = txt_marca_embalaje.Text;
            this._exportacionModel.Presentacion = cmb_presentacion.SelectedItem.ToString();
            this._exportacionModel.dtMelts = (DataTable) datagrid_melts.DataSource;
            this._exportacionModel.dtElementos = (DataTable) datagrid_elementos.DataSource;

            this._exportacionModel.Observaciones = txtobservaciones.Text;
            this._exportacionModel.Container = txt_container.Text;
            this._exportacionModel.Lingotes = txt_lingotes.Text;

            if (this.validateForm(this._exportacionModel))
            {
                return;
            }

            pdfGeneratorExport(this._exportacionModel);
        }

        /// <summary>
        /// Permite la validacion de obligatorios del campos 
        /// </summary>
        /// <returns></returns>
        private bool validateForm(ExportacionModel exportacionModel)
        {
            bool isError = false;
            if (exportacionModel.PesoBruto <= 0 )
            {
                isError = true;
                MessageBox.Show("El campo peso bruto debe ser mayor a Cero","Información",MessageBoxButtons.OK);
                txt_peso_bruto.Select();
                return isError;

            }
            if (exportacionModel.PesoNeto <= 0)
            {
                isError = true;
                MessageBox.Show("El campo peso Neto debe ser mayor a Cero", "Información", MessageBoxButtons.OK);
                txt_peso_neto.Select();
                return isError;

            }

            if (exportacionModel.NumeroFactura.Length ==0)
            {
                isError = true;
                MessageBox.Show("El campo Numero factura es obligatorio", "Información", MessageBoxButtons.OK);
                txt_factura.Select();
                return isError;

            }

            if (exportacionModel.MarcaEmbalaje.Length == 0)
            {
                isError = true;
                MessageBox.Show("El campo Marca Embalaje es obligatorio", "Información", MessageBoxButtons.OK);
                txt_marca_embalaje.Select();
                return isError;

            }

            if (exportacionModel.Container.Length == 0)
            {
                isError = true;
                MessageBox.Show("El campo Container es obligatorio", "Información", MessageBoxButtons.OK);
                txt_container.Select();
                return isError;

            }

            if (exportacionModel.Lingotes.Length == 0)
            {
                isError = true;
                MessageBox.Show("El campo Lingotes es obligatorio", "Información", MessageBoxButtons.OK);
                txt_lingotes.Select();
                return isError;

            }
            return isError;
        }

        //Metodo que permite genear PDF de exportacion
        private void pdfGeneratorExport(ExportacionModel exportacionModel)
        {
            ReaderPath objReader = new ReaderPath();
            this.RutaSalidaCertificados = objReader.getRutaGeneracionCertificados();


            FileGenerator objGenerator = new FileGenerator(this.RutaSalidaCertificados,exportacionModel.NumeroCertificado);
            try
            {

                Cursor = Cursors.WaitCursor;
                DataTable TablaAnalisQuimico = this.GetInfoTablaAnalisis(exportacionModel, null , _dtEspecificacionCLiente);
                
                objGenerator.ToMakeExportacion(TablaAnalisQuimico, exportacionModel);
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Format("Error: {0}", exc.Message),
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                addlog(exc.ToString() + exc.Message);
                return;
                throw;
            }
            finally
            {
                Cursor = Cursors.Arrow;
                var valConsecutivo = Convert.ToInt32(this.lbl_certificado_numero.Text) + 1;
                File.WriteAllText(this.RutaConsecutivo, valConsecutivo.ToString());
                this.Close();
               

            }


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



        }

        private DataTable GetInfoTablaAnalisis(DataGridView datagrid_elementos)
        {
            return new DataTable();
        }

        private DataTable GetInfoTablaAnalisis(ExportacionModel exportacionModel, DataGridViewRow currentRow, DataTable especficacionCliente)
        {
            DataTable dtInfoAnalisis = new DataTable();
            DataTable dtelementos = exportacionModel.dtElementos;

            dtInfoAnalisis.Columns.Add("Element", typeof(string));
            dtInfoAnalisis.Columns.Add("ESPECIFICATION", typeof(string));

            // se creanb todas las columnas Melts
            for (int i = 0; i < datagrid_elementos.Rows.Count; i++)
            {

                var name_melt = String.Format("MELT_{0}", datagrid_elementos[0, i].Value.ToString());
                dtInfoAnalisis.Columns.Add(name_melt, typeof(string));

            }





            foreach (DataRow rowClienteEspecificacion in especficacionCliente.Rows)
            {

                //Nueva fila 
                DataRow drow = dtInfoAnalisis.NewRow();
                // Recorre cada fila y columna de la tabla de elementosw
                for (int i = 0; i < datagrid_elementos.Rows.Count; i++)
                {

                    var name_melt = String.Format("MELT_{0}", datagrid_elementos[0, i].Value.ToString());

                   
                    for (int j = 0; j < datagrid_elementos.Columns.Count; j++)
                    {
                        //Buscamos las coincidencia por elemento entre las tablas
                        if (datagrid_elementos[j,i].OwningColumn.HeaderText.ToUpper() == rowClienteEspecificacion["Simbolo"].ToString().ToUpper())
                        {
                            //decimal valor_analizado = Convert.ToDecimal(Cell.Value.ToString());
                            //decimal valor_max = Convert.ToDecimal(rowClienteEspecificacion["Max"].ToString());
                           
                            drow["Element"] = rowClienteEspecificacion["Simbolo"].ToString();
                            drow["ESPECIFICATION"] = rowClienteEspecificacion["Max"].ToString();
                            drow[name_melt] = datagrid_elementos[j, i].Value.ToString();


                        }
                    }
                  
                }
                dtInfoAnalisis.Rows.Add(drow);


            }

            return dtInfoAnalisis;
        }


        private void addlog(string text)
        {
            string namefileLog = string.Format("log_errores_{0}.txt", DateTime.Now.ToString("yyymmdd"));
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


        // Eventoque se dispara cuando termina de editar una celada
        private void datagrid_melts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Double sum = 0;
            for (int i = 0; i < datagrid_melts.Rows.Count; ++i)

            {

                for (int j = 0; j < datagrid_melts.Rows[i].Cells.Count; j++)
                {
                    sum += Convert.ToDouble(datagrid_melts.Rows[i].Cells[j].Value);
                }
               
            }
            txt_peso_neto.Text = sum.ToString();

        }

        private void txt_peso_bruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DecimalOnly_KeyPress(txt_peso_bruto, false, e))
            {
                e.Handled = true;
            }  

        }

        private bool DecimalOnly_KeyPress(TextBox txt, bool numeric, KeyPressEventArgs e)
        {
            if (numeric)
            {
                // Test first character - either text is blank or the selection starts at first character.
                if (txt.Text == "" || txt.SelectionStart == 0)
                {
                    // If the first character is a minus or digit, AND
                    // if the text does not contain a minus OR the selected text DOES contain a minus.
                    if ((e.KeyChar == '-' || char.IsDigit(e.KeyChar)) && (!txt.Text.Contains("-") || txt.SelectedText.Contains("-")))
                        return false;
                    else
                        return true;
                }
                else
                {
                    // If it's not the first character, then it must be a digit or backspace
                    if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
                        return false;
                    else
                        return true;
                }
            }
            else
            {
                // Test first character - either text is blank or the selection starts at first character.
                if (txt.Text == "" || txt.SelectionStart == 0)
                {
                    // If the first character is a minus or digit, AND
                    // if the text does not contain a minus OR the selected text DOES contain a minus.
                    if ((e.KeyChar == '-' || char.IsDigit(e.KeyChar)) && (!txt.Text.Contains("-") || txt.SelectedText.Contains("-")))
                        return false;
                    else
                    {
                        // If the first character is a decimal point or digit, AND
                        // if the text does not contain a decimal point OR the selected text DOES contain a decimal point.
                        if ((e.KeyChar == '.' || char.IsDigit(e.KeyChar)) && (!txt.Text.Contains(".") || txt.SelectedText.Contains(".")))
                            return false;
                        else
                            return true;
                    }
                }
                else
                {
                    // If it's not the first character, then it must be a digit or backspace OR
                    // a decimal point AND
                    // if the text does not contain a decimal point or the selected text does contain a decimal point.
                    if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || (e.KeyChar == '.' && (!txt.Text.Contains(".") || txt.SelectedText.Contains("."))))
                        return false;
                    else
                        return true;
                }

            }
        }

        private void datagrid_melts_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
                Double i;

                if (!String.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    if (!Double.TryParse(Convert.ToString(e.FormattedValue), out i))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Debe ingresar solo caracteres numéricos", "Validacion", MessageBoxButtons.OK);
                    }
                   
                }

            
        }

        private void datagrid_elementos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Double i;


            if (e.ColumnIndex > 0) //|| e.ColumnIndex == 3 ) // 1 should be your column index
            {

                if (!String.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    if (!Double.TryParse(Convert.ToString(e.FormattedValue), out i))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Debe ingresar solo caracteres numéricos", "Validacion", MessageBoxButtons.OK);
                    }

                }
            }
        }
    }
}
