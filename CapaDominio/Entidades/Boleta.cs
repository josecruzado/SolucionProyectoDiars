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

        private ConceptoDeIngresosDescuentos conceptos;

        private PeriodoDePago periodoDePago;

        public void setAsignacionFamiliar(double asignacionfamiliar)
        {
            this.asignacionFamiliar= asignacionfamiliar;
        }
        public double getAsignacionFamiliar()
        {
            return asignacionFamiliar;
        }
        public void setDescuentoPorAFP(double descuentoPorAFP)
        {
            this.descuentoPorAFP = descuentoPorAFP;
        }
        public double getDescuentoPorAFP()
        {
            return descuentoPorAFP;
        }
        public void setSueldoBasico(double sueldoBasico)
        {
            this.sueldoBasico = sueldoBasico;
        }
        public double getSueldoBasico()
        {
            return sueldoBasico;
        }
        public void setSueldoNeto(double sueldoNeto)
        {
            this.sueldoNeto= sueldoNeto;
        }
        public double getSueldoNeto()
        {
            return sueldoNeto;
        }
        public void setTotalDeHoras(int totalDeHoras)
        {
             this.totalDeHoras = totalDeHoras;
        }
        public int getTotalDeHoras()
        {
            return totalDeHoras;
        }
        public void setTotalDeIngresos(double totalIngresos)
        {
            this.totalIngresos = totalIngresos;
        }
        public double getTotalDeIngresos()
        {
            return totalIngresos;
        }
        public void setTotalDeDescuentos(double totalDescuentos)
        {
            this.totalDescuentos = totalDescuentos;
        }
        public double getTotalDeDescuentos ()
        {
            return totalDescuentos;
        }
        public void setContrato(Contrato contrato)
        {
            this.contrato = contrato;
        }
        public Contrato getContrato()
        {
            return contrato;
        }
        public void setConcepto(ConceptoDeIngresosDescuentos conceptos)
        {
            this.conceptos = conceptos;
        }
        public ConceptoDeIngresosDescuentos getConcepto()
        {
            return conceptos;
        }
        public void setPeridoDePago(PeriodoDePago periodoDePago)
        {
            this.periodoDePago=periodoDePago;        
        }
        public PeriodoDePago getPeriodoDePago()
        {
            return periodoDePago;
        }


    }
}
