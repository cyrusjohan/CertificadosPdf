namespace Fundimetal.App
{
    partial class FrmPrincipalApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalApp));
            this.Panel_menu_vertical = new System.Windows.Forms.Panel();
            this.bnt_help = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bnt_visor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_barra = new System.Windows.Forms.Panel();
            this.btnmenu = new System.Windows.Forms.PictureBox();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_maximar = new System.Windows.Forms.PictureBox();
            this.bnt_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.panel_contendor_main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_menu_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.panel_contendor_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_menu_vertical
            // 
            this.Panel_menu_vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(196)))), ((int)(((byte)(116)))));
            this.Panel_menu_vertical.Controls.Add(this.bnt_help);
            this.Panel_menu_vertical.Controls.Add(this.button1);
            this.Panel_menu_vertical.Controls.Add(this.bnt_visor);
            this.Panel_menu_vertical.Controls.Add(this.pictureBox1);
            this.Panel_menu_vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_menu_vertical.Location = new System.Drawing.Point(0, 0);
            this.Panel_menu_vertical.Name = "Panel_menu_vertical";
            this.Panel_menu_vertical.Size = new System.Drawing.Size(213, 700);
            this.Panel_menu_vertical.TabIndex = 0;
            // 
            // bnt_help
            // 
            this.bnt_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_help.FlatAppearance.BorderSize = 0;
            this.bnt_help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bnt_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_help.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_help.ForeColor = System.Drawing.Color.White;
            this.bnt_help.Image = global::Fundimetal.App.Properties.Resources.help_32;
            this.bnt_help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_help.Location = new System.Drawing.Point(3, 195);
            this.bnt_help.Name = "bnt_help";
            this.bnt_help.Size = new System.Drawing.Size(212, 42);
            this.bnt_help.TabIndex = 2;
            this.bnt_help.Text = "Ayuda";
            this.bnt_help.UseVisualStyleBackColor = true;
            this.bnt_help.Click += new System.EventHandler(this.bnt_help_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Fundimetal.App.Properties.Resources.data_configuration_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Configurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnt_visor
            // 
            this.bnt_visor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_visor.FlatAppearance.BorderSize = 0;
            this.bnt_visor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bnt_visor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_visor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_visor.ForeColor = System.Drawing.Color.White;
            this.bnt_visor.Image = global::Fundimetal.App.Properties.Resources.file24;
            this.bnt_visor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_visor.Location = new System.Drawing.Point(3, 80);
            this.bnt_visor.Name = "bnt_visor";
            this.bnt_visor.Size = new System.Drawing.Size(212, 43);
            this.bnt_visor.TabIndex = 0;
            this.bnt_visor.Text = "Certificados";
            this.bnt_visor.UseVisualStyleBackColor = true;
            this.bnt_visor.Click += new System.EventHandler(this.bnt_visor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fundimetal.App.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_barra
            // 
            this.panel_barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(111)))));
            this.panel_barra.Controls.Add(this.btnmenu);
            this.panel_barra.Controls.Add(this.btn_restaurar);
            this.panel_barra.Controls.Add(this.btn_maximar);
            this.panel_barra.Controls.Add(this.bnt_minimizar);
            this.panel_barra.Controls.Add(this.btn_cerrar);
            this.panel_barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra.Location = new System.Drawing.Point(213, 0);
            this.panel_barra.Name = "panel_barra";
            this.panel_barra.Size = new System.Drawing.Size(1087, 44);
            this.panel_barra.TabIndex = 1;
            this.panel_barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_barra_MouseDown);
            // 
            // btnmenu
            // 
            this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.Location = new System.Drawing.Point(6, 7);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(30, 30);
            this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmenu.TabIndex = 5;
            this.btnmenu.TabStop = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restaurar.Image = global::Fundimetal.App.Properties.Resources.icon_restaurar;
            this.btn_restaurar.Location = new System.Drawing.Point(1029, 12);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(20, 20);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 1;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_maximar
            // 
            this.btn_maximar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximar.Image = global::Fundimetal.App.Properties.Resources.icon_maximizar;
            this.btn_maximar.Location = new System.Drawing.Point(1029, 12);
            this.btn_maximar.Name = "btn_maximar";
            this.btn_maximar.Size = new System.Drawing.Size(20, 20);
            this.btn_maximar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximar.TabIndex = 3;
            this.btn_maximar.TabStop = false;
            this.btn_maximar.Click += new System.EventHandler(this.btn_maximar_Click);
            // 
            // bnt_minimizar
            // 
            this.bnt_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnt_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_minimizar.Image = global::Fundimetal.App.Properties.Resources.icon_minimizar;
            this.bnt_minimizar.Location = new System.Drawing.Point(1003, 12);
            this.bnt_minimizar.Name = "bnt_minimizar";
            this.bnt_minimizar.Size = new System.Drawing.Size(20, 20);
            this.bnt_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_minimizar.TabIndex = 2;
            this.bnt_minimizar.TabStop = false;
            this.bnt_minimizar.Click += new System.EventHandler(this.bnt_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = global::Fundimetal.App.Properties.Resources.icon_cerrar2;
            this.btn_cerrar.Location = new System.Drawing.Point(1055, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(20, 20);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel_contendor_main
            // 
            this.panel_contendor_main.BackColor = System.Drawing.Color.Silver;
            this.panel_contendor_main.Controls.Add(this.label1);
            this.panel_contendor_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contendor_main.Location = new System.Drawing.Point(213, 44);
            this.panel_contendor_main.Name = "panel_contendor_main";
            this.panel_contendor_main.Size = new System.Drawing.Size(1087, 656);
            this.panel_contendor_main.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // FrmPrincipalApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel_contendor_main);
            this.Controls.Add(this.panel_barra);
            this.Controls.Add(this.Panel_menu_vertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipalApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipalApp";
            this.Panel_menu_vertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.panel_contendor_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_menu_vertical;
        private System.Windows.Forms.Panel panel_barra;
        private System.Windows.Forms.Panel panel_contendor_main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.PictureBox bnt_minimizar;
        private System.Windows.Forms.PictureBox btn_maximar;
        private System.Windows.Forms.Button bnt_visor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnmenu;
        private System.Windows.Forms.Button bnt_help;
    }
}