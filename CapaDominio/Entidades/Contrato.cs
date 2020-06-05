using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Contrato
    {
        private String cargo { get; set; }
        private Boolean estadoContrato { get; set; }
        private DateTime fechaFin { get; set; }
        private DateTime fechaInicio { get; set; }
        private double sueldoBasico { get; set; }
        private Boolean tieneAsignacionFamiliar { get; set; }
        private float totalDeHoras { get; set; }
        private float totalHorasPorSemana { get; set; }
        private Double valorHora { get; set; }

        public Boolean esContratoVigente()
        {
            return 0;
        }
        public Boolean verificarFechaAnterior()//Es contrato valido
        {
            if (DateTime.Compare(fechaInicio, fechaFin) <= 0)
            {
                return true;
            }
            return false;
        }

        public Boolean esFechaInicioValida()
        {
            if (DateTime.Compare(fechaInicio, fechaFin) > 0)
            {
                return true;
            }
            return false;
        }
        public Boolean esFechaFinValida()
        {
            TimeSpan diferencia = fechaFin - fechaInicio;
            if (diferencia.TotalDays > 90 && diferencia.TotalDays < 365)
            {
                return true;
            }
            return false;
        }
        public Boolean r04EsHorasContratadasValida()
        {
            if (totalHorasPorSemana >= 8 && totalHorasPorSemana <= 40)
            {
                return true;
            }
            return false;
        }

        public double r05CalcularValorPorHora()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            switch (cargo)
            {
                case "primaria":
                    return random.Next(5, 10);
                case "secundaria":
                    return random.Next(5, 10);
                case "bachiller":
                    return random.Next(11, 20);
                case "profesional":
                    return random.Next(21, 30);
                case "magister":
                    return random.Next(31, 40);
                case "doctor":
                    return random.Next(41, 60);
            }
            return 0;
        }

        public double r08CalcularAsignacionFamiliar()
        {
            if (tieneAsignacionFamiliar == true)
            {
                return 40 * 0.1;
            }
            return 0;
        }
    }
}
