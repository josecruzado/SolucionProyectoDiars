using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;
using CapaPersistencia.ADO_SQLServer;

namespace CapaAplicacion.Servicios
{
    public class CrudEmpleado
    {
        public Empleado buscarEmpleado(String dni)
        {
            GestorSQL gestorSQL = new GestorSQL();
            EmpleadoDAO empleadoDAO = new EmpleadoDAO(gestorSQL);

            return empleadoDAO.buscarPorDni(dni);
        }
    }
}
