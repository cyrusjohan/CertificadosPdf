using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundimetal.App
{
    public partial class FrmExportacion : Form
    {

        public DataGridView _datosVisor = new DataGridView();
        public DataTable _dtEspecificacionCLiente;
        public FrmExportacion()
        {
            InitializeComponent();
        }

        public FrmExportacion(DataGridView datos_visor_exportacion, DataTable especficacionCliente)
        {
            InitializeComponent();
            _datosVisor = datos_visor_exportacion;
            _dtEspecificacionCLiente = especficacionCliente;
         
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


            this.datagrid_elementos.DataSource = this.getDataTableElementos(_datosVisor, _dtEspecificacionCLiente);
           
        }

        
        //Permite obtener la informacion delos elementos de manera ordenada
        private DataTable getDataTableElementos(DataGridView datosVisor, DataTable especficacionCliente)
        {
            DataTable dtElementos = new DataTable("tabla_elementos");

            //Crear columnas  voy por aca toca enviar al especificacion  primeero






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
        }
    }
}
