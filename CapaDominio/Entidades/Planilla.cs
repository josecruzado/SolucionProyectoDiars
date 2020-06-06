using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
	public class Planilla
	{
		private String idPlanilla;
		private DateTime fechaPlanilla;
		private Boleta boleta;

		public void setIdPlanilla(String idPlanilla)
        {
			this.idPlanilla = idPlanilla;
        }
		public String getPlanilla()
        {
            return idPlanilla;
        }
		public void setFechaPlanilla(DateTime fechaPlanilla)
        {
			this.fechaPlanilla = fechaPlanilla;
        }
		public DateTime getfechaPlanilla()
        {
			return fechaPlanilla;
        } 
		public void setBoleta(Boleta boleta)
        {
			this.boleta = boleta;
        }
		public Boleta getBoleta()
        {
			return boleta;
        }
	}
}
