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
    public class ProcesarPagoServicio
    {
        private IGestorAccesoDatos gestorDatos;
        private IContrato contratoDAO;
        public List<Contrato> buscarContratosActivos()
        {
            List<Contrato> aux = new List<Contrato>();
            gestorDatos.abrirConexion();
            List<Contrato> contratos = contratoDAO.listarContratos(); //select * from Contrato
            gestorDatos.cerrarConexion();

            foreach (Contrato contrato in contratos) {

                if (contrato.getEstadoContrato() == true) 
                {
                    aux.Add(contrato);
                }
            }
            return aux;
        }


    }

}
