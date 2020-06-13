﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;
namespace CapaDominio.Contratos
{
    public interface IContrato
    {
        void guardar(Contrato contrato);
        List<Contrato> listarContratos();
    }
}
