using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistencia;
using CapaPersistencia.ADO_SQLServer;
using CapaDominio.Contratos;
using CapaDominio.Servicios;
using CapaDominio.Entidades;

namespace CapaAplicacion.Servicios
{
    public class GestionarContratoServicio
    {
        private IGestorAccesoDatos gestorDatos;
        private IContrato contratoDAO;
        private IEmpleado empleadoDAO;

        public Empleado buscarEmpleado(String Dni)
        {
            gestorDatos.abrirConexion();
            Empleado aux = empleadoDAO.buscarPorDni(Dni);
            gestorDatos.cerrarConexion();
            return aux;
        }
        public Contrato buscarUltimoContratoActivo(String Dni)
        {
            Contrato aux = new Contrato();
            DateTime fech = new DateTime(1990, 8, 1, 0, 0, 0);
            aux.setFechaFin(fech);
            gestorDatos.abrirConexion();
            List<Contrato> contratos = contratoDAO.listarContratos(); //select * from Contrato
            gestorDatos.cerrarConexion();

            foreach (Contrato contrato in contratos)
            {
                Empleado emp = contrato.getEmpleado();
                if(emp.getDni() == Dni)
                {
                    int resultado = DateTime.Compare(aux.getFechaFin(), contrato.getFechaFin());
                    if(resultado < 0)
                    {
                        aux = contrato;
                    }
                }
            }
            return aux;
        }
        public Contrato buscarUltimoContrato(String Dni,Contrato contratoActual)
        {
            Contrato aux = new Contrato();
            DateTime fech = new DateTime(1990, 8, 1, 0, 0, 0);
            aux.setFechaFin(fech);
            gestorDatos.abrirConexion();
            List<Contrato> contratos = contratoDAO.listarContratos(); //select * from Contrato
            gestorDatos.cerrarConexion();

            foreach (Contrato contrato in contratos)
            {
                Empleado emp = contrato.getEmpleado();
                if (emp.getDni() == Dni)
                {
                    int resultado = DateTime.Compare(aux.getFechaFin(), contrato.getFechaFin());
                    if (resultado < 0 && contrato.Equals(contratoActual) != false )
                    {
                        aux = contrato;
                    }
                }
            }
            return aux;
        }


    }
}
