namespace Fundimetal.App
{
    partial class FrmVisor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridVisor = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_recargar_info = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ruta_usuario_archivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.cmb_especificacion_cliente = new System.Windows.Forms.ComboBox();
            this.chk_send_email = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridVisor
            // 
            this.dataGridVisor.AllowUserToAddRows = false;
            this.dataGridVisor.AllowUserToDeleteRows = false;
            this.dataGridVisor.AllowUserToOrderColumns = true;
            this.dataGridVisor.AllowUserToResizeRows = false;
            this.dataGridVisor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridVisor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridVisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVisor.Location = new System.Drawing.Point(15, 80);
            this.dataGridVisor.Name = "dataGridVisor";
            this.dataGridVisor.ReadOnly = true;
            this.dataGridVisor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVisor.Size = new System.Drawing.Size(1039, 390);
            this.dataGridVisor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Se estan visualizando unicamente registros con calculos promedio.";
            // 
            // bnt_recargar_info
            // 
            this.bnt_recargar_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_recargar_info.Location = new System.Drawing.Point(935, 506);
            this.bnt_recargar_info.Name = "bnt_recargar_info";
            this.bnt_recargar_info.Size = new System.Drawing.Size(119, 33);
            this.bnt_recargar_info.TabIndex = 8;
            this.bnt_recargar_info.Text = "Recargar visor";
            this.bnt_recargar_info.UseVisualStyleBackColor = true;
            this.bnt_recargar_info.Click += new System.EventHandler(this.bnt_recargar_info_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(935, 549);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(119, 33);
            this.btn_cerrar.TabIndex = 9;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1090, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivosToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cargado :";
            // 
            // lbl_ruta_usuario_archivo
            // 
            this.lbl_ruta_usuario_archivo.AutoSize = true;
            this.lbl_ruta_usuario_archivo.Location = new System.Drawing.Point(71, 33);
            this.lbl_ruta_usuario_archivo.Name = "lbl_ruta_usuario_archivo";
            this.lbl_ruta_usuario_archivo.Size = new System.Drawing.Size(0, 13);
            this.lbl_ruta_usuario_archivo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleccionar  especificación para cliente";
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGenerarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPDF.ForeColor = System.Drawing.Color.White;
            this.btnGenerarPDF.Location = new System.Drawing.Point(281, 23);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(177, 50);
            this.btnGenerarPDF.TabIndex = 4;
            this.btnGenerarPDF.Text = "Generar certificado";
            this.btnGenerarPDF.UseVisualStyleBackColor = false;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // cmb_especificacion_cliente
            // 
            this.cmb_especificacion_cliente.DisplayMember = "Text";
            this.cmb_especificacion_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_especificacion_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_especificacion_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_especificacion_cliente.Location = new System.Drawing.Point(23, 37);
            this.cmb_especificacion_cliente.Name = "cmb_especificacion_cliente";
            this.cmb_especificacion_cliente.Size = new System.Drawing.Size(212, 23);
            this.cmb_especificacion_cliente.TabIndex = 6;
            this.cmb_especificacion_cliente.ValueMember = "Value";
            // 
            // chk_send_email
            // 
            this.chk_send_email.AutoSize = true;
            this.chk_send_email.Checked = true;
            this.chk_send_email.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_send_email.Location = new System.Drawing.Point(23, 71);
            this.chk_send_email.Name = "chk_send_email";
            this.chk_send_email.Size = new System.Drawing.Size(107, 17);
            this.chk_send_email.TabIndex = 11;
            this.chk_send_email.Text = "Enviar por correo";
            this.chk_send_email.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.chk_send_email);
            this.groupBox1.Controls.Add(this.cmb_especificacion_cliente);
            this.groupBox1.Controls.Add(this.btnGenerarPDF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 99);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Certificado PDF";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(464, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = " Certificado Exportación";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 651);
            this.Controls.Add(this.lbl_ruta_usuario_archivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.bnt_recargar_info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridVisor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmVisor";
            this.Text = "Visor Espectómetro - Fundimetal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnt_recargar_info;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ruta_usuario_archivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.ComboBox cmb_especificacion_cliente;
        private System.Windows.Forms.CheckBox chk_send_email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

