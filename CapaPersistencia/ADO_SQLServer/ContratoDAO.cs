using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia.ADO_SQLServer
{
    public class ContratoDAO
    {
        private GestorSQL gestorSQL;
        private EmpleadoDAO empleadoDAO;
        public ContratoDAO(GestorSQL gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }

        public void guardarContrato(Contrato contrato)
        {
            string insertarContratoSQL;
                insertarContratoSQL= "insert into contrato(idcontrato,cargo,estadocontrato,fechafin,fechainicio,tieneasignacionfamiliar,valorhora,idempleado,idafp) " +
                "values(@idcontrato,@cargo,@estadocontrato,@fechafin,@fechainicio,@tieneasignacionfamiliar,@valorhora,@idempleado,@idafp)";

        }

        public List<Contrato> contratos()
        {
            return null;
        }
    }
}
