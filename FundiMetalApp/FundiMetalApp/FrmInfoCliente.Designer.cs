namespace Fundimetal.App
{
    partial class FrmInfoCliente
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
            this.btnSaveCliente = new System.Windows.Forms.Button();
            this.bnt_Cerrar_ventana_new_cliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id_cliente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveCliente
            // 
            this.btnSaveCliente.Location = new System.Drawing.Point(231, 263);
            this.btnSaveCliente.Name = "btnSaveCliente";
            this.btnSaveCliente.Size = new System.Drawing.Size(127, 23);
            this.btnSaveCliente.TabIndex = 0;
            this.btnSaveCliente.Text = "&Guardar CLiente";
            this.btnSaveCliente.UseVisualStyleBackColor = true;
            this.btnSaveCliente.Click += new System.EventHandler(this.btnSaveCliente_Click);
            // 
            // bnt_Cerrar_ventana_new_cliente
            // 
            this.bnt_Cerrar_ventana_new_cliente.Location = new System.Drawing.Point(28, 263);
            this.bnt_Cerrar_ventana_new_cliente.Name = "bnt_Cerrar_ventana_new_cliente";
            this.bnt_Cerrar_ventana_new_cliente.Size = new System.Drawing.Size(75, 23);
            this.bnt_Cerrar_ventana_new_cliente.TabIndex = 8;
            this.bnt_Cerrar_ventana_new_cliente.Text = "Cerrar";
            this.bnt_Cerrar_ventana_new_cliente.UseVisualStyleBackColor = true;
            this.bnt_Cerrar_ventana_new_cliente.Click += new System.EventHandler(this.bnt_Cerrar_ventana_new_cliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 229);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(9, 114);
            this.txt_direccion.MaxLength = 500;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(280, 61);
            this.txt_direccion.TabIndex = 8;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(9, 49);
            this.txt_nombre.MaxLength = 100;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(283, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Completo";
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.AutoSize = true;
            this.lbl_id_cliente.Location = new System.Drawing.Point(137, 263);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_cliente.TabIndex = 10;
            this.lbl_id_cliente.Visible = false;
            // 
            // FrmInfoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 311);
            this.Controls.Add(this.lbl_id_cliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnt_Cerrar_ventana_new_cliente);
            this.Controls.Add(this.btnSaveCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInfoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informacion Completa Cliente";
            this.Load += new System.EventHandler(this.FrmInfoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveCliente;
        private System.Windows.Forms.Button bnt_Cerrar_ventana_new_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id_cliente;
    }
}