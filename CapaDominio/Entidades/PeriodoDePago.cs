using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class PeriodoDePago
    {
        private Boolean estado { get; set;}
        private DateTime fechaFin { get; set;}
        private DateTime fechaInicio { get; set;}
        private int semanasDePeriodo { get; set; }

        public Boolean sePuedeProcesar() 
        {
        
        }
    }
}
