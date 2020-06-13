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
        public void validarEmpleado(Empleado empleado)
        {
            if (empleado == null)
            {
                throw new Exception("No existe el empleado");
            }
        }

        public void validarContrato(Contrato contrato,Empleado empleado, AFP afp,Contrato contratoAnterior)
        {
            if(contrato != null)
            {
                contrato.setEmpleado(empleado);
                contrato.setAFP(afp);
                if(contrato.eslaFechaInicioValida(contrato.getFechaFin()) != true)
                {
                    throw new Exception("No se puede crear el contrato, La fecha del contrato anterior es superior a la fecha de inicio de este contrato");
                }
                if(contrato.esValidoLasHorasALaSemana() != true)
                {
                    throw new Exception("No se puede crear el contrato, Las horas a la semana no esta en el rango previsto ");
                }
                if(contrato.sonValidasLasFechas() != true )
                {
                    throw new Exception("No se puede crear el contrato, Las fechas no cumplen con el intrvalo previsto");
                }
                if(contrato.esValorPorHoraValido() != true)
                {
                    throw new Exception("No se puede crear el contrato, El valor por hora no cumple con lo privisto segun el cargo");
                }
                contrato.setEstadoContrato(true);

            }
            
        }
        public void tieneContratoVigenteEditable(Contrato contrato)
        {
            if (contrato == null)
            {
                throw new Exception("El empleado no tiene un contrato vigente");

            }
        }
        public void tieneContratoVigenteAnulable(Contrato contrato)
        {
            if (contrato == null)
            {
                throw new Exception("El empleado no tiene un contrato vigente");

            }
        }



    }
}
