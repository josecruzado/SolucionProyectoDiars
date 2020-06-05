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
        
        public void setAsignacionFamiliar(double asignacionfamiliar)
        {
            this.asignacionFamiliar= asignacionFamiliar;
        }

        public double getAsignacionFamiliar()
        {
            return asignacionFamiliar;
        }


    }
}
