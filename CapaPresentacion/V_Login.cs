using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class V_Login : Form
    {
        public V_Login()
        {
            InitializeComponent();
        }
        //Permitir mover y arrastrar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void V_Login_Load(object sender, EventArgs e)
        {

        }


        OracleConnection conexion = new OracleConnection("DATA SOURCE = localhost:1521 / xe;PASSWORD=123;USER ID=ACCIDENTES;");
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            // OracleConnection conexion = new OracleConnection("DATA SOURCE = localhost:1521 / xe;PASSWORD=123;USER ID=ACCIDENTES;");
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM CREDENCIAL WHERE USER_CRED =:usuario AND PASSWORD =:password and ID_ROL=1 and ID_EST_CREDEN=1", conexion);

            comando.Parameters.Add(":usuario", txtUsuario.Text);
            comando.Parameters.Add(":password", txtPassword.Text);

            OracleDataReader lector = comando.ExecuteReader();


            if (lector.Read())
            {
                V_MenuPrin vm = new V_MenuPrin();
                vm.Show();
                conexion.Close();

                
                this.WindowState = FormWindowState.Minimized;

                this.Visible = false;
            }
            else if (txtUsuario.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Campos vacios");
                conexion.Close();
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Campo Usuario vacio");
                conexion.Close();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Campo Contraseña vacio");
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Credencial  Incorrecta");
                conexion.Close();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
