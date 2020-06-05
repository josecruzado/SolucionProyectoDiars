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
        private float totalHorasPorSemana { get; set; }
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
        public get()
        {
            return
        }
        public Boolean esContratoVigente()
        {
            if (estadoContrato == true)
            {
                return true; //valida si el estado del contrato esta vigente y devuelve true
            }
            else
            {
                return false// devuelve false si el contrato no esta vigente
            }
        }
        public Boolean esValidoLasHorasALaSemana()
        public Boolean sonValidasLasFechas()
        {

        }
    }
}
