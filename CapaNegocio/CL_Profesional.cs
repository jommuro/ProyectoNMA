using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;

namespace CapaNegocio
{
    public class CL_Profesional
    {
        //Atributos de la clase profesional
        private int _id_profesional;
        private String _rut_profesional;
        private String _nombre;
        private String _ap_pat;
        private String _ap_mat;
        private DateTime _fec_nacimiento;
        private int _telefono;
        private String _direccion;
        private string _correo;
        private int _id_genero;
        private int _id_comuna;

        //Getter y Setter
        public int Id_profesional
        {
            get
            {
                return _id_profesional;
            }

            set
            {
                _id_profesional = value;
            }
        }

        public string Rut_profesional
        {
            get
            {
                return _rut_profesional;
            }

            set
            {
                _rut_profesional = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Ap_pat
        {
            get
            {
                return _ap_pat;
            }

            set
            {
                _ap_pat = value;
            }
        }

        public string Ap_mat
        {
            get
            {
                return _ap_mat;
            }

            set
            {
                _ap_mat = value;
            }
        }

        public DateTime Fec_nacimiento
        {
            get
            {
                return _fec_nacimiento;
            }

            set
            {
                _fec_nacimiento = value;
            }
        }

        public int Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }

            set
            {
                _direccion = value;
            }
        }

        public string Correo
        {
            get
            {
                return _correo;
            }

            set
            {
                _correo = value;
            }
        }

        public int Id_genero
        {
            get
            {
                return _id_genero;
            }

            set
            {
                _id_genero = value;
            }
        }

        public int Id_comuna
        {
            get
            {
                return _id_comuna;
            }

            set
            {
                _id_comuna = value;
            }
        }
        //Metodo para la conexion con la clase CL_Contexto
        private CL_Contexto conexion;

        //Contructor con metodo de conexion
        public CL_Profesional()
        {
            conexion = new CL_Contexto();
        }

        //Constructor con todos los atributos
        public CL_Profesional(int _id_profesional, string _rut_profesional, string _nombre, string _ap_pat, string _ap_mat, DateTime _fec_nacimiento, int _telefono, string _direccion, string _correo, int _id_genero, int _id_comuna)
        {
            this._id_profesional = _id_profesional;
            this._rut_profesional = _rut_profesional;
            this._nombre = _nombre;
            this._ap_pat = _ap_pat;
            this._ap_mat = _ap_mat;
            this._fec_nacimiento = _fec_nacimiento;
            this._telefono = _telefono;
            this._direccion = _direccion;
            this._correo = _correo;
            this._id_genero = _id_genero;
            this._id_comuna = _id_comuna;
        }
       
       
        //Metodo para agregar profesional
        public bool AgregarProfesional()
        {
            try
            {
                PROFESIONAL pro = new PROFESIONAL();
                CREDENCIAL cre = new CREDENCIAL();
                /*pro.RUT_PROFESIONAL = this.Rut_profesional;
                pro.NOMBRE = this.Nombre;
                pro.AP_PAT = this.Ap_pat;
                pro.AP_MAT = this.Ap_mat;
                pro.FEC_NACIMIENTO = this.Fec_nacimiento;
                string result;
                result = Convert.ToString(pro.FEC_NACIMIENTO);
        
                pro.TELEFONO = this.Telefono;
                pro.DIRECCION = this.Direccion;
                pro.CORREO = this.Correo;
                pro.ID_GENERO = this.Id_genero;
                pro.ID_COMUNA = this.Id_comuna;*/

                //pro.FEC_NACIMIENTO = Convert.ToDateTime(pro.FEC_NACIMIENTO.ToString("MM/dd/yyyy"));


                //pro.FEC_NACIMIENTO = DateTime.Parse(this._fec_nacimiento);

                var o_result = new System.Data.Objects.ObjectParameter("O_RESULT", typeof(string));
                //conexion.Entidades.SP_INSERT_PROFESIONAL("12096458-81", "Juanpi", "Adame", "Rivas", "21-09-2020", 123344, "adasd", "adasdas", 1, 13114, "adasd1asdaaaa", "adaasd",o_result);
                conexion.Entidades.SP_INSERT_PROFESIONAL(pro.RUT_PROFESIONAL, pro.NOMBRE, pro.AP_PAT, pro.AP_MAT, pro.FEC_NACIMIENTO.ToString(), pro.TELEFONO, pro.DIRECCION, pro.CORREO, pro.ID_GENERO, pro.ID_COMUNA, cre.USER_CRED,cre.PASSWORD, o_result);
               
                conexion.Entidades.SaveChanges();
                o_result.ToString();

                return true;
            }
            catch (Exception es)
            {
                return false;
            }


           
        }
        //Metodo para buscar Profesional
        public CL_Profesional BuscarProfesionales()
        {
            try
            {
                PROFESIONAL usu = new PROFESIONAL();
                usu = conexion.Entidades.PROFESIONAL.First(x => x.RUT_PROFESIONAL == this.Rut_profesional);//aca carga los datos que ya no debian existir
                CL_Profesional pro = new CL_Profesional();
                try
                {
                  pro.Rut_profesional = usu.RUT_PROFESIONAL;
                }
                catch (Exception)
                {
                    pro.Rut_profesional = "";
                }

                try
                {
                    pro.Nombre = usu.NOMBRE;
                }
                catch (Exception)
                {

                    pro.Nombre = "";
                }
                try
                {
                    pro.Ap_pat = usu.AP_PAT;
                }
                catch (Exception)
                {

                    pro.Ap_pat = "";
                }
                try
                {
                    pro.Ap_mat = usu.AP_MAT;
                }
                catch (Exception)
                {

                    pro.Ap_mat = "";
                }

                try
                {
                    pro.Fec_nacimiento = usu.FEC_NACIMIENTO;
                }
                catch (Exception)
                {

                    pro.Fec_nacimiento = System.DateTime.Now;
                }
                try
                {
                    pro.Telefono = int.Parse(usu.TELEFONO.ToString());
                }
                catch (Exception)
                {

                    pro.Ap_pat = "";
                }
                try
                {
                    pro.Direccion = usu.DIRECCION;
                }
                catch (Exception)
                {

                    pro.Direccion = "";
                }
                try
                {
                    pro.Correo = usu.CORREO;
                }
                catch (Exception)
                {

                    pro.Correo = "";
                }
                try
                {
                    pro.Id_genero = int.Parse(usu.ID_GENERO.ToString());
                }
                catch (Exception)
                {

                    pro.Id_genero = 1;
                }
                try
                {
                    pro.Id_comuna = int.Parse(usu.ID_COMUNA.ToString());
                }
                catch (Exception)
                {

                    pro.Ap_pat = "";
                }



                
                return pro;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }

}
