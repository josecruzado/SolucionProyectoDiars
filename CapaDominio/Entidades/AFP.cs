using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class AFP
    {
        private String codigoAFP;
        private String nombreAFP;
        private float porcentajeDescuentoAFP;

        public void setCodigoAFP(String codigoAFP)
        {
            this.codigoAFP = codigoAFP;
        }
        public String getCodigoAFP()
        {
            return codigoAFP;
        }
        public void setNombreAFP(String nombreAFP)
        {
            this.nombreAFP = nombreAFP;
        }
        public String getNombreAFP()
        {
            return nombreAFP;
        }
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
