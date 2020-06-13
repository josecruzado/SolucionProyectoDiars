using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;
namespace CapaDominio.Servicios
{
    public class RegistroDeContrato
    {
        public void crearContrato(Contrato contrato,Empleado empleado, AFP afp,Contrato contratoAnterior)
        {
            if(contrato != null)
            {
                contrato.setEmpleado(empleado);
                contrato.setAFP(afp);
                if(contrato.eslaFechaInicioValida(contrato.getFechaFin()) != true)
                {

                }
                if(contrato.esValidoLasHorasALaSemana() != true)
                {

                }
            }
            
        }
    }
}
