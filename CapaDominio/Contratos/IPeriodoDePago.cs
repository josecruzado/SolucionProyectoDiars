using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Contratos
{
    public interface IPeriodoDePago
    {
        PeriodoDePago buscar(String id);
        PeriodoDePago buscarPorfecha(DateTime fecha);
    }
}
