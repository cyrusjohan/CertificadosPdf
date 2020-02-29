using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fundimetal.Core;
using fundimetal_core.Model;

namespace Fundimetal.App
{
    public partial class FrmInfoCliente : Form


    {

        private IRepository _repository = new XmlRepository();
        private ClienteModel cliente = new ClienteModel();
        private Boolean isModeEdit = false;
      

        public FrmInfoCliente()
        {
            InitializeComponent();
        }

        public FrmInfoCliente(ClienteModel cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            isModeEdit = true;
        }

        private void btnSaveCliente_Click(object sender, EventArgs e)
        {
            int X = 1;
            Boolean isError = false;

            var clienteModel = new ClienteModel();
            clienteModel.NombreCliente = txt_nombre.Text;
            clienteModel.Descripcion = txt_direccion.Text;
            clienteModel.IdCLiente = lbl_id_cliente.Text;

            #region Validaciones
            if (clienteModel.NombreCliente.Length == 0)
            {
                isError = true;
                MessageBox.Show("Debe completar nombre cliente");
                txt_nombre.Select();
                return;

            }
            if (clienteModel.Descripcion.Length == 0)
            {
                isError = true;
                MessageBox.Show("Debe completar direccion ");
                txt_direccion.Select();
                return;

            }


            #endregion


            bool estadoSave = false;
            try
            {


                estadoSave = this._repository.SaveOrEditInfoCliente(clienteModel);


                MessageBox.Show("Operacion realiza con exito", "Confirmación", MessageBoxButtons.OK);
              
                this.Close();

            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show("Un error ha ocurrido al guardar nuevo registro", "Error", MessageBoxButtons.OK);
                return;
            }
        }

        private void bnt_Cerrar_ventana_new_cliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInfoCliente_Load(object sender, EventArgs e)
        {
            if (isModeEdit == true)
            {
                this.Text = "Editar informacion cliente";
                this.SetInfoCliente();

            }
        }

        private void SetInfoCliente()
        {

            lbl_id_cliente.Text = cliente.IdCLiente;
            txt_nombre.Text = cliente.NombreCliente;
            txt_direccion.Text = cliente.Descripcion;
        }
    }
}
