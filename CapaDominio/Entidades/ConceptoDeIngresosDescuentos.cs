using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class ConceptoDeIngresosDescuentos
    {
        private float montoDeOtrosDescuentos {set;get;}
        private float montoDeOtrosIngresos {set;get;}
        private float montoPorAdelantos {set;get;}
        private float montoPorHorasAusentes{ set; get; }
        private float montoPorHorasExtras{ set; get; }
        private float montoPorReintegros{ set; get; }
        private PeriodoDePago periodoDePago { set; get; }

        public void setMontoDeOtrosDescuentos(float montoDeOtrosDescuentos)
        {
            this.montoDeOtrosDescuentos = montoDeOtrosDescuentos;
        }

        public float getMontoDeOtrosDescuentos()
        {
            return montoDeOtrosDescuentos;
        }

        public void setMontoDeOtrosIngresos(float montoDeOtrosIngresos)
        {
            this.montoDeOtrosIngresos = montoDeOtrosIngresos;
        }

        public float getMontoDeOtrosIngresos()
        {
            return montoDeOtrosIngresos;
        }

        public void setMontoPorAdelantos(float montoPorAdelantos)
        {
            this.montoPorAdelantos = montoPorAdelantos;
        }

        public float getMontoPorAdelantos()
        {
            return montoPorAdelantos;
        }

        public void setMontoPorHorasAusentes(float montoPorHorasAusentes)
        {
            this.montoPorHorasAusentes = montoPorHorasAusentes;
        }

        public float getMontoPorHorasAusentes()
        {
            return montoPorHorasAusentes;
        }

        public void setMontoPorHorasExtras(float montoPorHorasExtras)
        {
            this.montoPorHorasExtras = montoPorHorasExtras;
        }

        public float getMontoPorHorasExtra()
        {
            return montoPorHorasExtras;
        }

        public void setMontoPorReintegros(float montoPorReintegros)
        {
            this.montoPorReintegros = montoPorReintegros;
        }

        public float getMontoPorReintegros()
        {
            return montoPorReintegros;
        }

        public void setPeriodoDePago (PeriodoDePago periodoDePago)
        {
             this.periodoDePago = periodoDePago;
        }

        public PeriodoDePago getPeriodoDePago()
        {
            return periodoDePago;
        }
        private double calcularConceptosDeIngresos()
        {

        }

        private double ConceptoDeDescuentos()
        {

        }
    }
}


