﻿using System;
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
        {
            switch (empleado.getGradoAcademico())
            {
                case"Primaria":
                    {
                        if (valorHora <= 5 && valorHora <= 10)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
               case "Secundaria":
                    {
                        if (valorHora <= 5 && valorHora <= 10)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case "Bachiller":
                    {
                        if (valorHora <= 11 && valorHora <= 20)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case "Profesional":
                    {
                        if (valorHora <= 21 && valorHora <= 30)
                        {
                            return true;
                        }
                        else
                        {
                            return false;                        
                        }
                    }
                case "Magister":
                    {
                        if (valorHora <= 31 && valorHora <= 40)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case "Doctor":
                    {
                        if (valorHora <= 41 && valorHora <= 60)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
            
            }
            return false;
        }

        public Boolean sonValidasLasFechas()
        {

        }
    }
}
