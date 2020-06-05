using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;


namespace CapaDominio.Entidades
{
    public class Contrato
    {
        private String cargo { get; set; }
        private Boolean estadoContrato { get; set; }
        private DateTime fechaFin { get; set; }
        private DateTime fechaInicio { get; set; }
        private Boolean tieneAsignacionFamiliar { get; set; }
        private int horasPorSemana { get; set; }
        private Double valorHora { get; set; }
        private Empleado empleado { get; set; }
        private List<ConceptoDeIngresosDescuentos> conceptos { set; get; }
        private AFP afp { set; get; }

        public void setEmpleado(Empleado empleado)
        {
            this.empleado=empleado;
        }
        public Empleado getEmpleado()
        {
            return empleado;
        }
        public void setTieneAsignacionFamiliar(Boolean tieneAsignacionFamiliar)
        {
            this.tieneAsignacionFamiliar=tieneAsignacionFamiliar;
        }
        public Boolean getTieneAsignacionFamiliar()
        {
            return tieneAsignacionFamiliar;
        }
        public void setCargo(String cargo)
        {
            this.cargo = cargo;
        }
        public String getCargo()
        {
            return cargo;
        }
        public void setEstadoContrato(Boolean estadoContrato)
        {
            this.estadoContrato = estadoContrato;
        }
        public Boolean getEstadoContrato()
        {
            return estadoContrato;
        }
        public void setFechaInicio(DateTime fechaInicio)
        {
            this.fechaInicio = fechaInicio;
        }
        public DateTime getFechaInicio()
        {
            return fechaInicio;
        }
        public void setFechaFin(DateTime fechaFin)
        {
            this.fechaFin = fechaFin;
        }
        public DateTime getFechaFin()
        {
            return fechaFin;
        }
        public void setHorasPorSemana(int horasPorSemana)
        {
            this.horasPorSemana=horasPorSemana;
        }
        public int gethorasPorSemana()
        {
            return horasPorSemana;
        }
        public void setValorHora(double valorHora)
        {
            this.valorHora = valorHora;
        }
        public double getValorHora()
        {
            return valorHora;
        }
        public void setConceptos(List<ConceptoDeIngresosDescuentos> conceptos)
        {
            this.conceptos = conceptos;
        }
        public List<ConceptoDeIngresosDescuentos> getConceptos()
        {
            return conceptos;
        }
        public void setAFP(AFP afp)
        {
            this.afp = afp;
        }
        public AFP GetAFP()
        {
            return afp;
        }


        public Boolean esValidoLasHorasALaSemana()
        {
            return true;
        }
        public Boolean sonValidasLasFechas()
        {
            return true;
        }
    }
}
