using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Boleta
    {
        private double asignacionFamiliar;
        private double descuentoPorAFP;
        private double sueldoBasico;
        private double sueldoNeto;
        private int totalDeHoras;
        private double totalDescuentos;
        private double totalIngresos;
        private Contrato contrato;

        public void calcularAsignacionFamiliar()
        {
            if(contrato.getTieneAsignacionFamiliar == true)
            {
                asignacionFamiliar = 940 * 0.1;
            }
            else
            {
                asignacionFamiliar = 0;
            }
        }

        public double calcularDescuentoAfp()
        {
            return afp.getPorcentajeDescuentoAFP()  *  sueldoBasico;
        }

        public void calcularSueldoBasico()
        {
            sueldoBasico = totalDeHoras * valorHora;
        }

        public void calcularSueldoNeto()
        {
            
        }

        public void calcularTotalDeDescuento()
        {

        }

        public void calcularTotalDeHoras()
        {

            totalDeHoras = totalHorasPorSemana * conceptos.periodoDePago.semanaDePeriodo;
               
        }

        public void calcularTotalDeIngreso()
        {

        }

    }
}
