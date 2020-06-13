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

        public Contrato buscarUltimoContratoActivo(String Dni)
        {
            Contrato aux = null;
            gestorDatos.abrirConexion();
            List<Contrato> contratos = contratoDAO.listarContratos(); //select * from Contrato
            gestorDatos.cerrarConexion();

            foreach (Contrato contrato in contratos)
            {
                Empleado emp = contrato.getEmpleado();
                if(emp.getDni() == Dni)
                {
                    if(contrato.esVigente() == true)
                    {
                        aux = contrato;
                    }
                }
            }
            return aux;
        }

    }
}
