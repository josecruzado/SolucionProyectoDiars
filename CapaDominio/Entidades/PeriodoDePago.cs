using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class PeriodoDePago
    {
        private Boolean estado;
        private DateTime fechaFin;
        private DateTime fechaInicio;
        private int semanasDePeriodo;

        public void setEstado(Boolean estado)
        {
            this.estado=estado;
        }
        public Boolean getEstado()
        {
            return estado;
        }
        public void setFechaFin(DateTime fechaFin)
        {
            this.fechaFin=fechaFin;
        }
        public DateTime getFechaFin()
        {
            return fechaFin;
        }
        public void setFechaInicio(DateTime fechaInicio)
        {
            this.fechaInicio =fechaInicio;
        }
        public DateTime getFechaInicio()
        {
            return fechaInicio;
        }
        public void setSemanasDePeriodo(int semanasDePeriodo)
        {
            this.semanasDePeriodo = semanasDePeriodo;
        }
        public int getSemanasDePeriodo()
        {
            return semanasDePeriodo;
        }

        public Boolean sePuedeProcesar() 
        {
            DateTime fechaActual = DateTime.Now;
            int resultado = DateTime.Compare(fechaActual,fechaFin);
            if(resultado <=0)
            {
                return true;
            }
            return false;
        }

    }
}
