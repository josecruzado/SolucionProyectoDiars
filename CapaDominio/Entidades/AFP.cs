using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class AFP
    {
        private float porcentajeDescuentoAFP { set; get; }
        public void setPorcentajeDescuentoAFP(float porcentajeDescuentoAFP)
        {
            this.porcentajeDescuentoAFP = porcentajeDescuentoAFP;
        }

        public float getPorcentajeDescuentoAFP()
        {
            return porcentajeDescuentoAFP;
        }


    }
}
