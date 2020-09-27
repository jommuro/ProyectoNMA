
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Oracle.ManagedDataAccess.Client;

namespace CapaPresentacion
{
    public partial class V_Profesional : Form
    {
        CL_Profesional pro = new CL_Profesional();
        public V_Profesional()
        {
            InitializeComponent();
            cbxEstCred.Hide();
        }
        private void V_Profesional_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ESTADO_CREDENCIAL' table. You can move, or remove it, as needed.
            this.eSTADO_CREDENCIALTableAdapter.Fill(this.dataSet1.ESTADO_CREDENCIAL);
            // TODO: This line of code loads data into the 'dataSet1.CREDENCIAL' table. You can move, or remove it, as needed.
            this.cREDENCIALTableAdapter.Fill(this.dataSet1.CREDENCIAL);

            // TODO: This line of code loads data into the 'dataSet1.COMUNA' table. You can move, or remove it, as needed.
            this.cOMUNATableAdapter.Fill(this.dataSet1.COMUNA);
            // TODO: This line of code loads data into the 'dataSet1.GENERO' table. You can move, or remove it, as needed.
            this.gENEROTableAdapter.Fill(this.dataSet1.GENERO);
            // TODO: This line of code loads data into the 'dataSet1.PROFESIONAL' table. You can move, or remove it, as needed.
            this.pROFESIONALTableAdapter.Fill(this.dataSet1.PROFESIONAL);

        }
        
        private void btnGuardarPro_Click(object sender, EventArgs e)
        {
            /* string SQL = "INSERT INTO PROFESIONAL VALUES (SQ_ID_PROFESIONAL.NEXTVAL,:I_RUT_PRO,:I_NOMBRE,:AP_PAT,:AP_MAT,:I_FEC_NAC_DD_MM_YYYY,:I_CEL,:I_DOMI,:I_CORREO,:I_GENERO,:I_COMUNA)";

             OracleConnection conexion = new OracleConnection("DATA SOURCE = localhost:1521 / xe;PASSWORD=123;USER ID=ACCIDENTES;");
             conexion.Open();

             OracleCommand comando = conexion.CreateCommand();
             comando.CommandType = System.Data.CommandType.Text;
             comando.CommandText = SQL;

             comando.Parameters.Add("I_RUT_PRO", OracleDbType.Varchar2).Value = txtRutProfesional.Text;
             comando.Parameters.Add("I_NOMBRE", OracleDbType.Varchar2).Value = txtNombre.Text;
             comando.Parameters.Add("AP_PAT", OracleDbType.Varchar2).Value = txtApellidoPat.Text;
             comando.Parameters.Add("AP_MAT", OracleDbType.Varchar2).Value = txtApellidoMat.Text;
             comando.Parameters.Add("I_FEC_NAC_DD_MM_YYYY", OracleDbType.Varchar2).Value = dtpFecNac.Text;
             comando.Parameters.Add("I_CEL", OracleDbType.Decimal).Value = 987654321;
             comando.Parameters.Add("I_DOMI", OracleDbType.Varchar2).Value = txtDireccion.Text;
             comando.Parameters.Add("I_CORREO", OracleDbType.Varchar2).Value = txtCorreo.Text;
             comando.Parameters.Add("I_GENERO", OracleDbType.Decimal).Value = int.Parse((cbxGenero.SelectedValue).ToString());
             comando.Parameters.Add("I_COMUNA", OracleDbType.Decimal).Value = int.Parse((cbxComuna.SelectedValue).ToString());
             comando.ExecuteNonQuery();
             conexion.Close();
             comando.Dispose();
             conexion.Dispose();
             this.pROFESIONALTableAdapter.Fill(this.dataSet1.PROFESIONAL);*/

             string SQL = "SP_INSERT_PROFESIONAL";
             OracleConnection conexion = new OracleConnection("DATA SOURCE = localhost:1521 / xe;PASSWORD=123;USER ID=ACCIDENTES;");
             conexion.Open();

             try
             {
              
             OracleCommand comando = conexion.CreateCommand();
             //comando.CommandType = System.Data.CommandType.Text;
             comando.CommandText = SQL;
             comando.CommandType = System.Data.CommandType.StoredProcedure;
             comando.Parameters.Add("I_RUT_PRO", OracleDbType.Varchar2).Value = txtRutProfesional.Text;
             comando.Parameters.Add("I_NOMBRE", OracleDbType.Varchar2).Value = txtNombre.Text;
             comando.Parameters.Add("AP_PAT", OracleDbType.Varchar2).Value = txtApellidoPat.Text;
             comando.Parameters.Add("AP_MAT", OracleDbType.Varchar2).Value = txtApellidoMat.Text;

             comando.Parameters.Add("I_FEC_NAC_DD_MM_YYYY", OracleDbType.Varchar2).Value = dtpFecNac.Value.ToShortDateString();
                comando.Parameters.Add("I_CEL", OracleDbType.Decimal).Value = txtTelefono.Text;
             comando.Parameters.Add("I_DOMI", OracleDbType.Varchar2).Value = txtDireccion.Text;
             comando.Parameters.Add("I_CORREO", OracleDbType.Varchar2).Value = txtCorreo.Text;
             comando.Parameters.Add("I_GENERO", OracleDbType.Decimal).Value = int.Parse((cbxGenero.SelectedValue).ToString());
             comando.Parameters.Add("I_COMUNA", OracleDbType.Decimal).Value = int.Parse((cbxComuna.SelectedValue).ToString());
             comando.Parameters.Add("I_USERNAME", OracleDbType.Varchar2).Value = txtusercred.Text;
             comando.Parameters.Add("I_PASSWORD", OracleDbType.Varchar2).Value = txtpassword.Text;
             comando.Parameters.Add("O_RESULT", OracleDbType.Varchar2).Direction = System.Data.ParameterDirection.Output;
             Console.WriteLine(dtpFecNac.Value.ToShortDateString());

                comando.ExecuteNonQuery();
                MessageBox.Show("Profesional Registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
             comando.Dispose();
             conexion.Dispose();
                this.pROFESIONALTableAdapter.Fill(this.dataSet1.PROFESIONAL);
            }
             catch (Exception es)
             {
                MessageBox.Show("Profesional no Registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
                 throw;
             }


            /*            conexion.Open();
                        OracleCommand comando = new OracleCommand("INSERT INTO PROFESIONAL (SQ_ID_PROFESIONAL,RUT_PROFESIONAL, NOMBRE, AP_PAT,AP_MAT,FEC_NACIMIENTO,TELEFONO,DIRECCION,CORREO,ID_GENERO,ID_COMUNA) VALUES(?,?,?,?,?,?,?,?,?,?,?); ", conexion);

                        try
                        {
                            comando.Parameters.Add("RUT_PROFESIONAL", OracleDbType.Varchar2).Value = txtRutProfesional.Text;
                            comando.Parameters.Add("NOMBRE", OracleDbType.Varchar2).Value = txtNombre.Text;
                            comando.Parameters.Add("AP_PAT", OracleDbType.Varchar2).Value = txtApellidoPat.Text;
                            comando.Parameters.Add("AP_MAT", OracleDbType.Varchar2).Value = txtApellidoMat.Text;
                            comando.Parameters.Add("FEC_NACIMIENTO", OracleDbType.Varchar2).Value = "02-02-1998";
                            comando.Parameters.Add("TELEFONO", OracleDbType.Decimal).Value = 987654321;
                            comando.Parameters.Add("DIRECCION", OracleDbType.Varchar2).Value = txtDireccion.Text;
                            comando.Parameters.Add("CORREO", OracleDbType.Varchar2).Value = txtCorreo.Text;
                            comando.Parameters.Add("ID_GENERO", OracleDbType.Decimal).Value = 1;
                            comando.Parameters.Add("ID_COMUNA", OracleDbType.Decimal).Value = 13114;
                            comando.ExecuteNonQuery();
                            conexion.Close();
                        }
                        catch (Exception es)
                        {

                            throw;
                        }*/



            /*conexion.Open();
            using (OracleCommand comando = new OracleCommand("SP_INSERT_PROFESIONAL", conexion))
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                
                comando.Parameters.Add("I_RUT_PRO", OracleDbType.Varchar2).Value = txtRutProfesional.Text;
                comando.Parameters.Add("I_NOMBRE", OracleDbType.Varchar2).Value = txtNombre.Text;
                comando.Parameters.Add("AP_PAT", OracleDbType.Varchar2).Value = txtApellidoPat.Text;
                comando.Parameters.Add("AP_MAT", OracleDbType.Varchar2).Value = txtApellidoMat.Text;
                comando.Parameters.Add("I_FEC_NAC_DD_MM_YYYY", OracleDbType.Varchar2).Value = "02-02-1998";
                comando.Parameters.Add("I_CEL", OracleDbType.Int64).Value = 987654321;
                comando.Parameters.Add("I_DOMI", OracleDbType.Varchar2).Value = txtDireccion.Text;
                comando.Parameters.Add("I_CORREO", OracleDbType.Varchar2).Value = txtCorreo.Text;
                comando.Parameters.Add("I_GENERO", OracleDbType.Int64).Value = cbxGenero.Text;
                comando.Parameters.Add("I_COMUNA", OracleDbType.Int64).Value = cbxComuna.Text;
                comando.Parameters.Add("I_USERNAME", OracleDbType.Varchar2).Value = txtusercred.Text;
                comando.Parameters.Add("I_PASSWORD", OracleDbType.Varchar2).Value = txtpassword.Text;
                comando.Parameters.Add("O_RESULT", OracleDbType.Varchar2).Direction = System.Data.ParameterDirection.Output;
                comando.ExecuteNonQuery();
                conexion.Close();
                //comando.Parameters.Add(":usuario", txtUsuario.Text);
                //comando.Parameters.Add(":password", txtPassword.Text);


            }*/




            /*
            pro.Rut_profesional = txtRutProfesional.Text;


            pro.Fec_nacimiento = DateTime.Parse(dtpFecNac.Text);
            try
            {
                if (pro.AgregarProfesional())
                {
                    MessageBox.Show("Profesional Agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error al Agregar Profesional", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception es)
            {

                throw;
            }

        */
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string rut = dataGridPro.SelectedRows[0].Cells[0].Value.ToString();
            buscarProfesional(rut);


        }
        
        public void buscarProfesional(String rut)
        {
            try
            {
                pro.Rut_profesional = rut.ToString();
                

                CL_Profesional u = pro.BuscarProfesionales();


                if (u == null)
                {
                    MessageBox.Show("Profesional no existe");
                }
                else
                {
                    txtRutProfesional.Text = u.Rut_profesional;
                    txtNombre.Text = u.Nombre;
                    txtApellidoPat.Text = u.Ap_pat;
                    txtApellidoMat.Text = u.Ap_mat;
                    dtpFecNac.Value = u.Fec_nacimiento;
                    txtTelefono.Text = Convert.ToString(u.Telefono);
                    txtDireccion.Text = u.Direccion;
                    txtCorreo.Text = u.Correo;
                    cbxComuna.SelectedValue = u.Id_comuna;
                    cbxGenero.SelectedValue = u.Id_genero;
                    //cbxEstCred.SelectedValue = 
                    MessageBox.Show("¡Busqueda exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pROFESIONALTableAdapter.FillBy(this.dataSet1.PROFESIONAL);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
