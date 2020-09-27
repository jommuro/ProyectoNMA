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

namespace CapaPresentacion
{
    public partial class V_MenuPrin : Form
    {
        public V_MenuPrin()
        {
            InitializeComponent();
            btnLogo2.Hide();
        }
        //Permitir mover y arrastrar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void MenuPrin_Load(object sender, EventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                //btnLogo.Left;
                MenuVertical.Width = 80;
                btnLogo2.Visible = true;
            }
            else
            {
                MenuVertical.Width = 250;
                btnLogo2.Hide();
            }
        }

        //Metodo boton MAximizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else {
                this.WindowState = FormWindowState.Maximized;
                 }


        }
        //Metodo para cerrar aplicación
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Metodo para minimizar apliación
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
           ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            while (MessageBox.Show("Cerrar Sesión?", "", MessageBoxButtons.YesNo) ==
               DialogResult.No)
            {

            }
            // The user wants to exit the application. Close everything down.
            this.Close();
            V_Login login = new V_Login();
            login.Show();

            
        }
        //Metodo permite abrir la vista dentro del panel hijo de V_MenuPrin
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }
        private void btnProfesional_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new V_Profesional());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new V_Servicios());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new V_Cliente());
        }
    }
}
