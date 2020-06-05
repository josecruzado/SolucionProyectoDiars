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
            return semanasDePeriodo
        }

        public Boolean sePuedeProcesar() 
        {
        
        }
    }
}
