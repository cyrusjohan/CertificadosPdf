namespace Fundimetal.App
{
    partial class FrmExportacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_certificado_numero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_factura = new System.Windows.Forms.Label();
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.lbl_marcas_embalaje = new System.Windows.Forms.Label();
            this.txt_marca_embalaje = new System.Windows.Forms.TextBox();
            this.lbl_peso_bruto = new System.Windows.Forms.Label();
            this.lbl_peso_neto = new System.Windows.Forms.Label();
            this.txt_peso_neto = new System.Windows.Forms.TextBox();
            this.txt_peso_bruto = new System.Windows.Forms.TextBox();
            this.lbl_presentacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datagrid_elementos = new System.Windows.Forms.DataGridView();
            this.cmb_producto = new System.Windows.Forms.ComboBox();
            this.cmb_presentacion = new System.Windows.Forms.ComboBox();
            this.lblcontainer = new System.Windows.Forms.Label();
            this.txt_container = new System.Windows.Forms.TextBox();
            this.btn_generar_pdf_exportacion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_lingotes = new System.Windows.Forms.TextBox();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagrid_melts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_elementos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_melts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Certificado Nº";
            // 
            // lbl_certificado_numero
            // 
            this.lbl_certificado_numero.AutoSize = true;
            this.lbl_certificado_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_certificado_numero.Location = new System.Drawing.Point(576, 27);
            this.lbl_certificado_numero.Name = "lbl_certificado_numero";
            this.lbl_certificado_numero.Size = new System.Drawing.Size(0, 20);
            this.lbl_certificado_numero.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cliente";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(33, 86);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(50, 13);
            this.lbl_producto.TabIndex = 6;
            this.lbl_producto.Text = "Producto";
            // 
            // lbl_factura
            // 
            this.lbl_factura.AutoSize = true;
            this.lbl_factura.Location = new System.Drawing.Point(405, 86);
            this.lbl_factura.Name = "lbl_factura";
            this.lbl_factura.Size = new System.Drawing.Size(58, 13);
            this.lbl_factura.TabIndex = 8;
            this.lbl_factura.Text = "Factura Nº";
            // 
            // txt_factura
            // 
            this.txt_factura.Location = new System.Drawing.Point(468, 79);
            this.txt_factura.MaxLength = 20;
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(203, 20);
            this.txt_factura.TabIndex = 4;
            // 
            // lbl_marcas_embalaje
            // 
            this.lbl_marcas_embalaje.AutoSize = true;
            this.lbl_marcas_embalaje.Location = new System.Drawing.Point(381, 117);
            this.lbl_marcas_embalaje.Name = "lbl_marcas_embalaje";
            this.lbl_marcas_embalaje.Size = new System.Drawing.Size(82, 13);
            this.lbl_marcas_embalaje.TabIndex = 10;
            this.lbl_marcas_embalaje.Text = "Marca embalaje";
            // 
            // txt_marca_embalaje
            // 
            this.txt_marca_embalaje.Location = new System.Drawing.Point(468, 110);
            this.txt_marca_embalaje.MaxLength = 250;
            this.txt_marca_embalaje.Name = "txt_marca_embalaje";
            this.txt_marca_embalaje.Size = new System.Drawing.Size(203, 20);
            this.txt_marca_embalaje.TabIndex = 5;
            // 
            // lbl_peso_bruto
            // 
            this.lbl_peso_bruto.AutoSize = true;
            this.lbl_peso_bruto.Location = new System.Drawing.Point(24, 155);
            this.lbl_peso_bruto.Name = "lbl_peso_bruto";
            this.lbl_peso_bruto.Size = new System.Drawing.Size(59, 13);
            this.lbl_peso_bruto.TabIndex = 12;
            this.lbl_peso_bruto.Text = "Peso Bruto";
            // 
            // lbl_peso_neto
            // 
            this.lbl_peso_neto.AutoSize = true;
            this.lbl_peso_neto.Location = new System.Drawing.Point(28, 117);
            this.lbl_peso_neto.Name = "lbl_peso_neto";
            this.lbl_peso_neto.Size = new System.Drawing.Size(57, 13);
            this.lbl_peso_neto.TabIndex = 13;
            this.lbl_peso_neto.Text = "Peso Neto";
            // 
            // txt_peso_neto
            // 
            this.txt_peso_neto.Location = new System.Drawing.Point(100, 114);
            this.txt_peso_neto.Name = "txt_peso_neto";
            this.txt_peso_neto.ReadOnly = true;
            this.txt_peso_neto.Size = new System.Drawing.Size(72, 20);
            this.txt_peso_neto.TabIndex = 3;
            this.txt_peso_neto.Text = "0";
            // 
            // txt_peso_bruto
            // 
            this.txt_peso_bruto.Location = new System.Drawing.Point(100, 152);
            this.txt_peso_bruto.MaxLength = 7;
            this.txt_peso_bruto.Name = "txt_peso_bruto";
            this.txt_peso_bruto.Size = new System.Drawing.Size(72, 20);
            this.txt_peso_bruto.TabIndex = 3;
            this.txt_peso_bruto.Text = "0";
            this.txt_peso_bruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_peso_bruto_KeyPress);
            // 
            // lbl_presentacion
            // 
            this.lbl_presentacion.AutoSize = true;
            this.lbl_presentacion.Location = new System.Drawing.Point(384, 155);
            this.lbl_presentacion.Name = "lbl_presentacion";
            this.lbl_presentacion.Size = new System.Drawing.Size(69, 13);
            this.lbl_presentacion.TabIndex = 16;
            this.lbl_presentacion.Text = "Presentación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datagrid_elementos);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(43, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 208);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Composición química";
            // 
            // datagrid_elementos
            // 
            this.datagrid_elementos.AllowUserToAddRows = false;
            this.datagrid_elementos.AllowUserToOrderColumns = true;
            this.datagrid_elementos.AllowUserToResizeColumns = false;
            this.datagrid_elementos.AllowUserToResizeRows = false;
            this.datagrid_elementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_elementos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.datagrid_elementos.Location = new System.Drawing.Point(4, 19);
            this.datagrid_elementos.MultiSelect = false;
            this.datagrid_elementos.Name = "datagrid_elementos";
            this.datagrid_elementos.Size = new System.Drawing.Size(663, 171);
            this.datagrid_elementos.TabIndex = 8;
            this.datagrid_elementos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.datagrid_elementos_CellValidating);
            // 
            // cmb_producto
            // 
            this.cmb_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_producto.FormattingEnabled = true;
            this.cmb_producto.Items.AddRange(new object[] {
            "Plomo refinado",
            "Plomo aliado"});
            this.cmb_producto.Location = new System.Drawing.Point(98, 78);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Size = new System.Drawing.Size(226, 21);
            this.cmb_producto.TabIndex = 2;
            // 
            // cmb_presentacion
            // 
            this.cmb_presentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_presentacion.FormattingEnabled = true;
            this.cmb_presentacion.Items.AddRange(new object[] {
            "Lingotes 19K",
            "Lingotes 29K",
            "Lingotes 34K",
            "Lingotes 100K",
            "Jumbo"});
            this.cmb_presentacion.Location = new System.Drawing.Point(468, 147);
            this.cmb_presentacion.Name = "cmb_presentacion";
            this.cmb_presentacion.Size = new System.Drawing.Size(203, 21);
            this.cmb_presentacion.TabIndex = 6;
            // 
            // lblcontainer
            // 
            this.lblcontainer.AutoSize = true;
            this.lblcontainer.Location = new System.Drawing.Point(318, 559);
            this.lblcontainer.Name = "lblcontainer";
            this.lblcontainer.Size = new System.Drawing.Size(52, 13);
            this.lblcontainer.TabIndex = 23;
            this.lblcontainer.Text = "Container";
            // 
            // txt_container
            // 
            this.txt_container.Location = new System.Drawing.Point(383, 556);
            this.txt_container.MaxLength = 40;
            this.txt_container.Name = "txt_container";
            this.txt_container.Size = new System.Drawing.Size(222, 20);
            this.txt_container.TabIndex = 10;
            // 
            // btn_generar_pdf_exportacion
            // 
            this.btn_generar_pdf_exportacion.Location = new System.Drawing.Point(567, 616);
            this.btn_generar_pdf_exportacion.Name = "btn_generar_pdf_exportacion";
            this.btn_generar_pdf_exportacion.Size = new System.Drawing.Size(161, 35);
            this.btn_generar_pdf_exportacion.TabIndex = 12;
            this.btn_generar_pdf_exportacion.Text = "&Generar reporte";
            this.btn_generar_pdf_exportacion.UseVisualStyleBackColor = true;
            this.btn_generar_pdf_exportacion.Click += new System.EventHandler(this.btn_generar_pdf_exportacion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Lingotes";
            // 
            // txt_lingotes
            // 
            this.txt_lingotes.AcceptsReturn = true;
            this.txt_lingotes.Location = new System.Drawing.Point(383, 588);
            this.txt_lingotes.MaxLength = 3;
            this.txt_lingotes.Name = "txt_lingotes";
            this.txt_lingotes.Size = new System.Drawing.Size(136, 20);
            this.txt_lingotes.TabIndex = 11;
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(40, 556);
            this.txtobservaciones.MaxLength = 200;
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(269, 62);
            this.txtobservaciones.TabIndex = 9;
            // 
            // lbl_observaciones
            // 
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.Location = new System.Drawing.Point(37, 540);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(78, 13);
            this.lbl_observaciones.TabIndex = 30;
            this.lbl_observaciones.Text = "Observaciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagrid_melts);
            this.groupBox2.Location = new System.Drawing.Point(40, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 92);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lotes";
            // 
            // datagrid_melts
            // 
            this.datagrid_melts.AllowUserToAddRows = false;
            this.datagrid_melts.AllowUserToDeleteRows = false;
            this.datagrid_melts.AllowUserToResizeColumns = false;
            this.datagrid_melts.AllowUserToResizeRows = false;
            this.datagrid_melts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_melts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.datagrid_melts.Location = new System.Drawing.Point(7, 19);
            this.datagrid_melts.Name = "datagrid_melts";
            this.datagrid_melts.Size = new System.Drawing.Size(663, 58);
            this.datagrid_melts.TabIndex = 7;
            this.datagrid_melts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_melts_CellEndEdit);
            this.datagrid_melts.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.datagrid_melts_CellValidating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "(Kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "(Kg)";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(98, 29);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(226, 21);
            this.cmb_cliente.TabIndex = 1;
            // 
            // FrmExportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 666);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_observaciones);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.txt_lingotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_generar_pdf_exportacion);
            this.Controls.Add(this.txt_container);
            this.Controls.Add(this.lblcontainer);
            this.Controls.Add(this.cmb_presentacion);
            this.Controls.Add(this.cmb_producto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_presentacion);
            this.Controls.Add(this.txt_peso_bruto);
            this.Controls.Add(this.txt_peso_neto);
            this.Controls.Add(this.lbl_peso_neto);
            this.Controls.Add(this.lbl_peso_bruto);
            this.Controls.Add(this.txt_marca_embalaje);
            this.Controls.Add(this.lbl_marcas_embalaje);
            this.Controls.Add(this.txt_factura);
            this.Controls.Add(this.lbl_factura);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_certificado_numero);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmExportacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo certificado exportación";
            this.Load += new System.EventHandler(this.FrmExportacion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_elementos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_melts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_certificado_numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label lbl_factura;
        private System.Windows.Forms.TextBox txt_factura;
        private System.Windows.Forms.Label lbl_marcas_embalaje;
        private System.Windows.Forms.TextBox txt_marca_embalaje;
        private System.Windows.Forms.Label lbl_peso_bruto;
        private System.Windows.Forms.Label lbl_peso_neto;
        private System.Windows.Forms.TextBox txt_peso_neto;
        private System.Windows.Forms.TextBox txt_peso_bruto;
        private System.Windows.Forms.Label lbl_presentacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datagrid_elementos;
        private System.Windows.Forms.ComboBox cmb_producto;
        private System.Windows.Forms.ComboBox cmb_presentacion;
        private System.Windows.Forms.Label lblcontainer;
        private System.Windows.Forms.TextBox txt_container;
        private System.Windows.Forms.Button btn_generar_pdf_exportacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_lingotes;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.Label lbl_observaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datagrid_melts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_cliente;
    }
}