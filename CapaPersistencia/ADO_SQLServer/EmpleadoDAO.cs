using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDominio.Entidades;
namespace CapaPersistencia.ADO_SQLServer
{
    public class EmpleadoDAO
    {
        private GestorSQL gestorSQL;

        public EmpleadoDAO(GestorSQL gestorSQL) {
            this.gestorSQL = gestorSQL;
        }

        public Empleado buscarPorDni(string dni)
        {
            return Empleado;
        }
    }
}
