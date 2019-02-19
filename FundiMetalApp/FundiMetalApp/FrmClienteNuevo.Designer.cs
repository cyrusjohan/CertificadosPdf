namespace Fundimetal.App
{
    partial class FrmClienteNuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardarNuevoCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.dataGridEspecificaciones = new System.Windows.Forms.DataGridView();
            this.Simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Máximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.bnt_Cerrar_ventana_new_cliente = new System.Windows.Forms.Button();
            this.lbl_id_cliente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarNuevoCliente
            // 
            this.btnGuardarNuevoCliente.Location = new System.Drawing.Point(394, 371);
            this.btnGuardarNuevoCliente.Name = "btnGuardarNuevoCliente";
            this.btnGuardarNuevoCliente.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarNuevoCliente.TabIndex = 4;
            this.btnGuardarNuevoCliente.Text = "Guardar";
            this.btnGuardarNuevoCliente.UseVisualStyleBackColor = true;
            this.btnGuardarNuevoCliente.Click += new System.EventHandler(this.btnGuardarNuevoCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_id_cliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.dataGridEspecificaciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 337);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tabla de espeficaciones";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(6, 46);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(445, 20);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // dataGridEspecificaciones
            // 
            this.dataGridEspecificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEspecificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Simbolo,
            this.Elemento,
            this.Minimo,
            this.Máximo});
            this.dataGridEspecificaciones.Location = new System.Drawing.Point(9, 191);
            this.dataGridEspecificaciones.Name = "dataGridEspecificaciones";
            this.dataGridEspecificaciones.Size = new System.Drawing.Size(442, 121);
            this.dataGridEspecificaciones.TabIndex = 5;
            this.dataGridEspecificaciones.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridEspecificaciones_CellValidating);
            // 
            // Simbolo
            // 
            this.Simbolo.HeaderText = "Simbolo";
            this.Simbolo.MaxInputLength = 3;
            this.Simbolo.MinimumWidth = 2;
            this.Simbolo.Name = "Simbolo";
            // 
            // Elemento
            // 
            this.Elemento.HeaderText = "Elemento";
            this.Elemento.MaxInputLength = 35;
            this.Elemento.MinimumWidth = 2;
            this.Elemento.Name = "Elemento";
            // 
            // Minimo
            // 
            this.Minimo.HeaderText = "Minimo";
            this.Minimo.MaxInputLength = 35;
            this.Minimo.Name = "Minimo";
            this.Minimo.ToolTipText = "Ingrese valores numericos";
            // 
            // Máximo
            // 
            this.Máximo.HeaderText = "Máximo";
            this.Máximo.MaxInputLength = 35;
            this.Máximo.Name = "Máximo";
            this.Máximo.ToolTipText = "Ingrese valores numericos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción (Opcional)";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(6, 99);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(442, 43);
            this.txtDescripcion.TabIndex = 3;
            // 
            // bnt_Cerrar_ventana_new_cliente
            // 
            this.bnt_Cerrar_ventana_new_cliente.Location = new System.Drawing.Point(21, 371);
            this.bnt_Cerrar_ventana_new_cliente.Name = "bnt_Cerrar_ventana_new_cliente";
            this.bnt_Cerrar_ventana_new_cliente.Size = new System.Drawing.Size(75, 23);
            this.bnt_Cerrar_ventana_new_cliente.TabIndex = 7;
            this.bnt_Cerrar_ventana_new_cliente.Text = "Cerrar";
            this.bnt_Cerrar_ventana_new_cliente.UseVisualStyleBackColor = true;
            this.bnt_Cerrar_ventana_new_cliente.Click += new System.EventHandler(this.bnt_Cerrar_ventana_new_cliente_Click);
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.AutoSize = true;
            this.lbl_id_cliente.Location = new System.Drawing.Point(379, 16);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_cliente.TabIndex = 8;
            this.lbl_id_cliente.Visible = false;
            // 
            // FrmClienteNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 416);
            this.Controls.Add(this.bnt_Cerrar_ventana_new_cliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardarNuevoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar nuevo cliente";
            this.Load += new System.EventHandler(this.FrmClienteNuevo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardarNuevoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.DataGridView dataGridEspecificaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button bnt_Cerrar_ventana_new_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Máximo;
        private System.Windows.Forms.Label lbl_id_cliente;
    }
}