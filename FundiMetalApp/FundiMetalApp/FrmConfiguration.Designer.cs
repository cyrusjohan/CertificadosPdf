﻿namespace Fundimetal.App
{
    partial class FrmConfiguration
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
            this.tab_configuracion = new System.Windows.Forms.TabControl();
            this.Espec_Clientes = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_nuevo_cliente = new System.Windows.Forms.Button();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.bnt_editar_Cliente = new System.Windows.Forms.Button();
            this.Rutas = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_ruta_pdf = new System.Windows.Forms.TextBox();
            this.btn_select_folder_path = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtagrid_xml_fuente = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ruta_xml = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_grid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_find_1 = new System.Windows.Forms.Button();
            this.txt_xml_ruta = new System.Windows.Forms.TextBox();
            this.bnt_save_rutas = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNewCliente = new System.Windows.Forms.Button();
            this.datagridClientesListado = new System.Windows.Forms.DataGridView();
            this.btnEditCliente = new System.Windows.Forms.Button();
            this.btn_close_win = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridTipoProducto = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_guardar_parametros = new System.Windows.Forms.Button();
            this.lbl_lingotes = new System.Windows.Forms.Label();
            this.dataGridView_lingotes = new System.Windows.Forms.DataGridView();
            this.tab_configuracion.SuspendLayout();
            this.Espec_Clientes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.Rutas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtagrid_xml_fuente)).BeginInit();
            this.Cliente.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridClientesListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lingotes)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_configuracion
            // 
            this.tab_configuracion.Controls.Add(this.Espec_Clientes);
            this.tab_configuracion.Controls.Add(this.Rutas);
            this.tab_configuracion.Controls.Add(this.Cliente);
            this.tab_configuracion.Controls.Add(this.tabPage1);
            this.tab_configuracion.Location = new System.Drawing.Point(12, 24);
            this.tab_configuracion.Name = "tab_configuracion";
            this.tab_configuracion.SelectedIndex = 0;
            this.tab_configuracion.Size = new System.Drawing.Size(850, 359);
            this.tab_configuracion.TabIndex = 0;
            // 
            // Espec_Clientes
            // 
            this.Espec_Clientes.Controls.Add(this.groupBox2);
            this.Espec_Clientes.Location = new System.Drawing.Point(4, 22);
            this.Espec_Clientes.Name = "Espec_Clientes";
            this.Espec_Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Espec_Clientes.Size = new System.Drawing.Size(842, 333);
            this.Espec_Clientes.TabIndex = 0;
            this.Espec_Clientes.Text = "Especificación Clientes";
            this.Espec_Clientes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_nuevo_cliente);
            this.groupBox2.Controls.Add(this.dataGridCliente);
            this.groupBox2.Controls.Add(this.bnt_editar_Cliente);
            this.groupBox2.Location = new System.Drawing.Point(18, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 270);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administración";
            // 
            // btn_nuevo_cliente
            // 
            this.btn_nuevo_cliente.Location = new System.Drawing.Point(46, 28);
            this.btn_nuevo_cliente.Name = "btn_nuevo_cliente";
            this.btn_nuevo_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo_cliente.TabIndex = 4;
            this.btn_nuevo_cliente.Text = "Nuevo";
            this.btn_nuevo_cliente.UseVisualStyleBackColor = true;
            this.btn_nuevo_cliente.Click += new System.EventHandler(this.btn_nuevo_cliente_Click);
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.AllowUserToAddRows = false;
            this.dataGridCliente.AllowUserToDeleteRows = false;
            this.dataGridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Location = new System.Drawing.Point(46, 74);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCliente.Size = new System.Drawing.Size(526, 152);
            this.dataGridCliente.TabIndex = 0;
            // 
            // bnt_editar_Cliente
            // 
            this.bnt_editar_Cliente.Location = new System.Drawing.Point(141, 28);
            this.bnt_editar_Cliente.Name = "bnt_editar_Cliente";
            this.bnt_editar_Cliente.Size = new System.Drawing.Size(75, 23);
            this.bnt_editar_Cliente.TabIndex = 2;
            this.bnt_editar_Cliente.Text = "Editar";
            this.bnt_editar_Cliente.UseVisualStyleBackColor = true;
            this.bnt_editar_Cliente.Click += new System.EventHandler(this.editar_cliente_Click);
            // 
            // Rutas
            // 
            this.Rutas.Controls.Add(this.groupBox3);
            this.Rutas.Controls.Add(this.groupBox1);
            this.Rutas.Controls.Add(this.bnt_save_rutas);
            this.Rutas.Location = new System.Drawing.Point(4, 22);
            this.Rutas.Name = "Rutas";
            this.Rutas.Padding = new System.Windows.Forms.Padding(3);
            this.Rutas.Size = new System.Drawing.Size(842, 333);
            this.Rutas.TabIndex = 1;
            this.Rutas.Text = "Rutas";
            this.Rutas.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_ruta_pdf);
            this.groupBox3.Controls.Add(this.btn_select_folder_path);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(15, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 86);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuracion de ruta";
            // 
            // txt_ruta_pdf
            // 
            this.txt_ruta_pdf.Location = new System.Drawing.Point(20, 39);
            this.txt_ruta_pdf.Name = "txt_ruta_pdf";
            this.txt_ruta_pdf.Size = new System.Drawing.Size(421, 20);
            this.txt_ruta_pdf.TabIndex = 4;
            // 
            // btn_select_folder_path
            // 
            this.btn_select_folder_path.Location = new System.Drawing.Point(448, 36);
            this.btn_select_folder_path.Name = "btn_select_folder_path";
            this.btn_select_folder_path.Size = new System.Drawing.Size(33, 23);
            this.btn_select_folder_path.TabIndex = 6;
            this.btn_select_folder_path.Text = "...";
            this.btn_select_folder_path.UseVisualStyleBackColor = true;
            this.btn_select_folder_path.Click += new System.EventHandler(this.btn_select_folder_path_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta generacion PDF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtagrid_xml_fuente);
            this.groupBox1.Controls.Add(this.btn_add_grid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_find_1);
            this.groupBox1.Controls.Add(this.txt_xml_ruta);
            this.groupBox1.Location = new System.Drawing.Point(15, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 203);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen de datos";
            // 
            // dtagrid_xml_fuente
            // 
            this.dtagrid_xml_fuente.AllowUserToAddRows = false;
            this.dtagrid_xml_fuente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagrid_xml_fuente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.txt_ruta_xml});
            this.dtagrid_xml_fuente.Location = new System.Drawing.Point(5, 64);
            this.dtagrid_xml_fuente.Name = "dtagrid_xml_fuente";
            this.dtagrid_xml_fuente.Size = new System.Drawing.Size(721, 119);
            this.dtagrid_xml_fuente.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // txt_ruta_xml
            // 
            this.txt_ruta_xml.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_ruta_xml.FillWeight = 200F;
            this.txt_ruta_xml.HeaderText = "Ruta";
            this.txt_ruta_xml.Name = "txt_ruta_xml";
            // 
            // btn_add_grid
            // 
            this.btn_add_grid.Location = new System.Drawing.Point(472, 35);
            this.btn_add_grid.Name = "btn_add_grid";
            this.btn_add_grid.Size = new System.Drawing.Size(75, 23);
            this.btn_add_grid.TabIndex = 7;
            this.btn_add_grid.Text = "Adicionar";
            this.btn_add_grid.UseVisualStyleBackColor = true;
            this.btn_add_grid.Click += new System.EventHandler(this.btn_add_grid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar archivo XML Fuente";
            // 
            // btn_find_1
            // 
            this.btn_find_1.Location = new System.Drawing.Point(432, 36);
            this.btn_find_1.Name = "btn_find_1";
            this.btn_find_1.Size = new System.Drawing.Size(34, 23);
            this.btn_find_1.TabIndex = 5;
            this.btn_find_1.Text = "...";
            this.btn_find_1.UseVisualStyleBackColor = true;
            this.btn_find_1.Click += new System.EventHandler(this.btn_find_1_Click);
            // 
            // txt_xml_ruta
            // 
            this.txt_xml_ruta.Location = new System.Drawing.Point(5, 38);
            this.txt_xml_ruta.Name = "txt_xml_ruta";
            this.txt_xml_ruta.Size = new System.Drawing.Size(421, 20);
            this.txt_xml_ruta.TabIndex = 2;
            // 
            // bnt_save_rutas
            // 
            this.bnt_save_rutas.Location = new System.Drawing.Point(713, 291);
            this.bnt_save_rutas.Name = "bnt_save_rutas";
            this.bnt_save_rutas.Size = new System.Drawing.Size(123, 32);
            this.bnt_save_rutas.TabIndex = 0;
            this.bnt_save_rutas.Text = "Guardar cambios";
            this.bnt_save_rutas.UseVisualStyleBackColor = true;
            this.bnt_save_rutas.Click += new System.EventHandler(this.bnt_save_rutas_Click);
            // 
            // Cliente
            // 
            this.Cliente.Controls.Add(this.groupBox4);
            this.Cliente.Location = new System.Drawing.Point(4, 22);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(842, 333);
            this.Cliente.TabIndex = 2;
            this.Cliente.Text = "Info Clientes";
            this.Cliente.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNewCliente);
            this.groupBox4.Controls.Add(this.datagridClientesListado);
            this.groupBox4.Controls.Add(this.btnEditCliente);
            this.groupBox4.Location = new System.Drawing.Point(19, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(706, 270);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Administración";
            // 
            // btnNewCliente
            // 
            this.btnNewCliente.Location = new System.Drawing.Point(46, 28);
            this.btnNewCliente.Name = "btnNewCliente";
            this.btnNewCliente.Size = new System.Drawing.Size(75, 23);
            this.btnNewCliente.TabIndex = 4;
            this.btnNewCliente.Text = "Nuevo";
            this.btnNewCliente.UseVisualStyleBackColor = true;
            this.btnNewCliente.Click += new System.EventHandler(this.btnNewCliente_Click);
            // 
            // datagridClientesListado
            // 
            this.datagridClientesListado.AllowUserToAddRows = false;
            this.datagridClientesListado.AllowUserToDeleteRows = false;
            this.datagridClientesListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridClientesListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridClientesListado.Location = new System.Drawing.Point(46, 74);
            this.datagridClientesListado.Name = "datagridClientesListado";
            this.datagridClientesListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridClientesListado.Size = new System.Drawing.Size(587, 152);
            this.datagridClientesListado.TabIndex = 0;
            // 
            // btnEditCliente
            // 
            this.btnEditCliente.Location = new System.Drawing.Point(141, 28);
            this.btnEditCliente.Name = "btnEditCliente";
            this.btnEditCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEditCliente.TabIndex = 2;
            this.btnEditCliente.Text = "Editar";
            this.btnEditCliente.UseVisualStyleBackColor = true;
            this.btnEditCliente.Click += new System.EventHandler(this.btnEditCliente_Click);
            // 
            // btn_close_win
            // 
            this.btn_close_win.Location = new System.Drawing.Point(777, 401);
            this.btn_close_win.Name = "btn_close_win";
            this.btn_close_win.Size = new System.Drawing.Size(75, 23);
            this.btn_close_win.TabIndex = 6;
            this.btn_close_win.Text = "Cerrar";
            this.btn_close_win.UseVisualStyleBackColor = true;
            this.btn_close_win.Click += new System.EventHandler(this.btn_close_win_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_lingotes);
            this.tabPage1.Controls.Add(this.lbl_lingotes);
            this.tabPage1.Controls.Add(this.btn_guardar_parametros);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridTipoProducto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 333);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Parametros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridTipoProducto
            // 
            this.dataGridTipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTipoProducto.Location = new System.Drawing.Point(25, 57);
            this.dataGridTipoProducto.Name = "dataGridTipoProducto";
            this.dataGridTipoProducto.Size = new System.Drawing.Size(216, 198);
            this.dataGridTipoProducto.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo Producto Exportación";
            // 
            // btn_guardar_parametros
            // 
            this.btn_guardar_parametros.Location = new System.Drawing.Point(632, 263);
            this.btn_guardar_parametros.Name = "btn_guardar_parametros";
            this.btn_guardar_parametros.Size = new System.Drawing.Size(131, 23);
            this.btn_guardar_parametros.TabIndex = 2;
            this.btn_guardar_parametros.Text = "Guardar";
            this.btn_guardar_parametros.UseVisualStyleBackColor = true;
            this.btn_guardar_parametros.Click += new System.EventHandler(this.btn_guardar_parametros_Click);
            // 
            // lbl_lingotes
            // 
            this.lbl_lingotes.AutoSize = true;
            this.lbl_lingotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lingotes.Location = new System.Drawing.Point(340, 27);
            this.lbl_lingotes.Name = "lbl_lingotes";
            this.lbl_lingotes.Size = new System.Drawing.Size(167, 16);
            this.lbl_lingotes.TabIndex = 3;
            this.lbl_lingotes.Text = "Tipo lingotes presentación";
            // 
            // dataGridView_lingotes
            // 
            this.dataGridView_lingotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lingotes.Location = new System.Drawing.Point(343, 57);
            this.dataGridView_lingotes.Name = "dataGridView_lingotes";
            this.dataGridView_lingotes.Size = new System.Drawing.Size(216, 198);
            this.dataGridView_lingotes.TabIndex = 4;
            // 
            // FrmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.btn_close_win);
            this.Controls.Add(this.tab_configuracion);
            this.Name = "FrmConfiguration";
            this.Text = "Ajustes de configuración";
            this.Load += new System.EventHandler(this.FrmConfiguration_Load);
            this.tab_configuracion.ResumeLayout(false);
            this.Espec_Clientes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.Rutas.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtagrid_xml_fuente)).EndInit();
            this.Cliente.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridClientesListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lingotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_configuracion;
        private System.Windows.Forms.TabPage Espec_Clientes;
        private System.Windows.Forms.TabPage Rutas;
        private System.Windows.Forms.Button bnt_editar_Cliente;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.Button btn_nuevo_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_save_rutas;
        private System.Windows.Forms.TextBox txt_ruta_pdf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_xml_ruta;
        private System.Windows.Forms.Button btn_find_1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_select_folder_path;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_close_win;
        private System.Windows.Forms.DataGridView dtagrid_xml_fuente;
        private System.Windows.Forms.Button btn_add_grid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_ruta_xml;
        private System.Windows.Forms.TabPage Cliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnNewCliente;
        private System.Windows.Forms.DataGridView datagridClientesListado;
        private System.Windows.Forms.Button btnEditCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView_lingotes;
        private System.Windows.Forms.Label lbl_lingotes;
        private System.Windows.Forms.Button btn_guardar_parametros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridTipoProducto;
    }
}