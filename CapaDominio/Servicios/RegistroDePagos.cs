using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class RegistroDePagos
    {
        public void existePerdioDePago(PeriodoDePago periodoDePago) {

            //PASO 4 PROCESAR PAGO
            if (periodoDePago.sePuedeProcesar() == false)
            {
                throw new Exception("El periodo de pago no esta activo");
            }

        }

    }
}
