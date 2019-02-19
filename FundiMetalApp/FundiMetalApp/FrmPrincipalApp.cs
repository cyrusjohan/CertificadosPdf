using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Fundimetal.App
{
    public partial class FrmPrincipalApp : Form
    {
        public FrmPrincipalApp()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSliderMenu_Click(object sender, EventArgs e)
        {
            if (Panel_menu_vertical.Width >= 276)
            {
                Panel_menu_vertical.Width = 50;
            }
            else
            {
                Panel_menu_vertical.Width = 276;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int LX, LY;
        int SW, SH;
        private void btn_maximar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            ///Esto es para guardar la posicion actual del formulario
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            btn_maximar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void bnt_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;

            this.Size = new Size(SW, SH);  // tamaño inicial del formulario 
            this.Location = new Point(LX, LY);  // Restauro la posicion antes de maximizar

            btn_maximar.Visible = true;
            btn_restaurar.Visible = false;
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (Panel_menu_vertical.Width >= 213)
            {
                Panel_menu_vertical.Width = 45;
            }
            else
            {
                Panel_menu_vertical.Width = 213;
            }
        }

        private void panel_barra_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bnt_visor_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmVisor>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmConfiguration>();
        }


        /// <summary>
        /// Metodo que permite abrir formulario dentro de un contenedor 
        /// </summary>
        /// <typeparam name="MiFormulario"></typeparam>
        private void AbrirFormulario<MiFormulario>() where MiFormulario : Form ,new()
        {

            Form formulario;
            formulario = panel_contendor_main.Controls.OfType<MiFormulario>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiFormulario();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel_contendor_main.Controls.Add(formulario);
                panel_contendor_main.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }
            else {
                formulario.BringToFront();
            }
        }


        #region Codigo para cambiar de tamaño de la ventana 

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        /// <summary>
        /// Muestra la ayuda de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bnt_help_Click(object sender, EventArgs e)
        {

          string RutaManualPDF = System.AppDomain.CurrentDomain.BaseDirectory + "\\Referencia\\MANUAL_USUARIO_APP.pdf";
        
            try
            {
                System.Diagnostics.Process.Start(RutaManualPDF);
            }
            catch
            {
                MessageBox.Show("No se puede abrir el manual de usuario , verifique que existe archivo",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panel_contendor_main.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            //base.OnPaint(e);
            //ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }
        #endregion

    }
}
