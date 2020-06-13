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
        private String cargo;
        private Boolean estadoContrato;
        private DateTime fechaFin;
        private DateTime fechaInicio;
        private Boolean tieneAsignacionFamiliar;
        private int horasPorSemana;
        private Double valorHora;

        private Empleado empleado;

        private AFP afp;

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
            if(horasPorSemana >= 8 && horasPorSemana <= 40)
            {
                return true;
            }
            return false;
        }
        public Boolean sonValidasLasFechas()
        {
            TimeSpan resultado = fechaFin - fechaInicio;
            int dias = resultado.Days;

            if(dias >= 90 && dias <= 365)
            {
                return true;
            }
            return false;
        }
        public Boolean ValorPorHora()
        {
            switch(empleado.getGradoAcademico())
            {
                case "Primaria":
                    {
                        if(valorHora >= 5 && valorHora <= 10)
                        {
                            return true;
                        }
                        return false;
                    }
                case "Secundaria":
                    {
                       if(valorHora >= 5 && valorHora <= 10)
                        {
                            return true;
                        }
                        return false; 
                    }
                case "Bachiller":
                    {
                        if(valorHora >= 11 && valorHora <= 20)
                        {
                            return true;
                        }
                        return false;   
                    }
                case "Profesional":
                    {
                        if(valorHora >= 21 && valorHora <= 30)
                        {
                            return true;
                        }
                        return false;
                    }
                case "Magister":
                    {
                        if(valorHora >= 31 && valorHora <= 40)
                        {
                            return true;
                        }
                        return false;
                    }
                case "Doctor":
                    {
                        if(valorHora >= 41 && valorHora <= 60)
                        {
                            return true;
                        }
                        return false;
                    }
            }
            return false;
        }
        public Boolean eslaFechaInicioValida(DateTime fechaFinal)
        {
            int resultado = DateTime.Compare(fechaFinal,fechaInicio);
            if(resultado < 0)
            {
                return true;
            }
            return false;
        }
        public Boolean esVigente()
        {
            DateTime fechaActual = DateTime.Now;
            int resultado = DateTime.Compare(fechaActual,fechaFin); 
            if(resultado >= 0 && estadoContrato == true)
            {
                return true;
            }
            return false;
        }

    }
}
