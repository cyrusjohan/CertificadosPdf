using fundimetal.Core;
using fundimetal_core.Model;
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
    public partial class FrmClienteNuevo : Form
    {

        private IRepository _repository = new XmlRepository();
        private Boolean isModeEdit = false;
        private ClienteModel ClienteInformacion= new ClienteModel();

        public FrmClienteNuevo()
        {
            InitializeComponent();
            isModeEdit = false;
        }

        public FrmClienteNuevo(ClienteModel cliente)
        {
            InitializeComponent();
            isModeEdit = true; /// Modo edicion

            ClienteInformacion = cliente;
        }

        private void FrmClienteNuevo_Load(object sender, EventArgs e)
        {
            if (isModeEdit == true)
            {
                this.Text = "Editar informacion cliente";
                this.SetInfoCliente();

            }
        }


        /// <summary>
        /// Permite completar la informacio del formulario con los 
        /// datos completos
        /// </summary>
        private void SetInfoCliente()
        {
            lbl_id_cliente.Text = ClienteInformacion.IdCLiente;
            txtNombreCliente.Text = ClienteInformacion.NombreCliente;
            txtDescripcion.Text = ClienteInformacion.Descripcion;

            DataTable dtElementos = new DataTable();


            dtElementos.Columns.Add("Simbolo", typeof(string));
            dtElementos.Columns.Add("Nombre", typeof(string));          
            dtElementos.Columns.Add("Min", typeof(string));
            dtElementos.Columns.Add("Max", typeof(string));
            foreach (var item in ClienteInformacion.lstEspeficacionesElementos)
            {
                //dtElementos.Rows.Add(item.Elemento, item.Simbolo, item.Min, item.Max);
                dataGridEspecificaciones.Rows.Add(item.Simbolo, item.Elemento, item.Min, item.Max);

            }
            //dataGridEspecificaciones.DataSource = dtElementos;


        }

        private void bnt_Cerrar_ventana_new_cliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarNuevoCliente_Click(object sender, EventArgs e)
        {
            int X = 1;
            Boolean isError = false;

            var clienteModel = new ClienteModel();
            clienteModel.NombreCliente = txtNombreCliente.Text;
            clienteModel.Descripcion = txtDescripcion.Text;
            clienteModel.IdCLiente = lbl_id_cliente.Text;

            #region Validaciones
            if (clienteModel.NombreCliente.Length == 0)
            {
                isError = true;
                MessageBox.Show("Debe completar nombre cliente");
                txtNombreCliente.Select();
                return;

            }

            if (dataGridEspecificaciones.Rows.Count == 1 )
            {
                isError = true;
                MessageBox.Show("Debe ingresar los valores de tabla especificación ");
                dataGridEspecificaciones.Select();
                return;

            }
            #endregion
          
            foreach (DataGridViewRow row in dataGridEspecificaciones.Rows)
            {
                if (row.Cells[0].Value == null  
                    && row.Cells[1].Value == null 
                    && row.Cells[2].Value == null
                    && row.Cells[3].Value == null )
                {
                    continue;
                }


                var simbolo = row.Cells[0].Value.ToString();
                var elemento = row.Cells[1].Value.ToString(); ;
                var Valor_Minimo = row.Cells[2].Value.ToString();
                var Valor_Maximo = row.Cells[3].Value.ToString();
                clienteModel.lstEspeficacionesElementos.Add(new EspeficiacionElementosCliente { Simbolo = simbolo, Elemento = elemento, Min = Valor_Minimo, Max = Valor_Maximo });
                X++;
            }
            bool estadoSave = false;
            try
            {
               
                    
              estadoSave = this._repository.SaveOrEditCliente(clienteModel);
                
                 
                MessageBox.Show("Operacion realiza con exito","Confirmación",MessageBoxButtons.OK);
                //((FrmConfiguration)Owner).LoadConfigurationCliente();
                this.Close();
                
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show("Un error ha ocurrido al guardar nuevo registro","Error",MessageBoxButtons.OK);
                return;
            }
        }

        private void dataGridEspecificaciones_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 ) // 1 should be your column index
            {
                Double i;

                if (!String.IsNullOrWhiteSpace (e.FormattedValue.ToString()))
                {
                    if (!Double.TryParse(Convert.ToString(e.FormattedValue), out i))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Debe ingresar solo caracteres numéricos","Validacion",MessageBoxButtons.OK);
                    }
                    else
                    {
                        // the input is numeric 
                    }
                }
                
            }
        }
    }
}
