using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace CapaNegocio
{
    public class CL_Contexto
    {
       private CapaDALC.ProyectoEntities conexion;

        public ProyectoEntities Entidades
        {
            get
            {
                if (conexion == null)
                {
                    conexion = new CapaDALC.ProyectoEntities();
                }
                return conexion;
            }
        }
        public CL_Contexto() { }

    }
}
