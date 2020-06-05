using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
	public class Planilla
	{
		private int idPlanilla;
		private DateTime fechaPlanilla;
		private Boleta boleta;

		public void setIdPlanilla(int idPlanilla)
        {
			this.idPlanilla = idPlanilla;
        }

		public int getPlanilla()
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
	}
}
