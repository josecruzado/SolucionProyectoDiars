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
        private IBoletaDePago boletaDAO;
        private IConceptosDeIngresosDescuentos conceptoDAO;
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


        public Boleta generarBoleta(Contrato contrato,ConceptoDeIngresosDescuentos concepto)
        {
            Boleta boleta = new Boleta();
            boleta.setContrato(contrato);
            boleta.setConcepto(concepto);
            boleta.calcularAsignacionFamiliar();
            boleta.calcularTotalDeHoras();
            boleta.calcularSueldoBasico();
            boleta.calcularDescuentoAFP();
            boleta.calcularTotalDeIngreso();
            boleta.calcularTotalDeDescuento();
            boleta.calcularSueldoNeto();
            return boleta;
        }
        public void generarBoletas(List<Contrato> contratosVigentes, PeriodoDePago periodoDePago)
        {
            gestorDatos.abrirConexion();
            foreach (Contrato contrato in contratosVigentes)
            {
                ConceptoDeIngresosDescuentos aux = conceptoDAO.buscarPorContratoYPeriodo(contrato, periodoDePago);
                boletaDAO.guardar(generarBoleta(contrato, aux));
            }
            periodoDePago.setEstado("Procesado");
            gestorDatos.cerrarConexion();
        }


    }

}
