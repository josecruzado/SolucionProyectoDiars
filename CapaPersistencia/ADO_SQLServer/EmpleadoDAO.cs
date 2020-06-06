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
            Empleado empleado;
            String consultaSQL = "select * from empleado where empleado.dni = '" + dni + "';";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if(resultadoSQL.Read())
                {
                    empleado = obtenerEmpleado(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el Empleado");
                }
            }catch(Exception err)
            {
                throw err;
            }
            return empleado;
        }

        public Empleado obtenerEmpleado(SqlDataReader resultadoSQL)
        {
            Empleado empleado = new Empleado();
            empleado.setIdEmpleado(resultadoSQL.GetString(0));
            empleado.setDireccion(resultadoSQL.GetString(1));
            empleado.setDni(resultadoSQL.GetString(2));
            empleado.setEstadoCivil(resultadoSQL.GetString(3));
            empleado.setFechaDeNacimiento(DateTime.Parse(resultadoSQL.GetString(4)));
            empleado.setGradoAcademico(resultadoSQL.GetString(5));
            empleado.setNombre(resultadoSQL.GetString(6));
            empleado.setTelefono(resultadoSQL.GetString(7));
            return empleado;
        }
    }
}
