﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;
namespace CapaDominio.Contratos
{
    public interface IConceptosDeIngresosDescuentos
    {
        ConceptoDeIngresosDescuentos buscarPorContratoYPeriodo(Contrato contrato,PeriodoDePago periodoDePago);
        void guardar(ConceptoDeIngresosDescuentos concepto);
    }
}
