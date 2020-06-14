using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia.ADO_SQLServer
{
    public class PeriodoDePagoDAO
    {
        private GestorSQL gestorSQL;

        public PeriodoDePagoDAO(GestorSQL gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }

        public void actualizarPeriodo(PeriodoDePago periodoDePago)
        {

            String consultaSQL = "UPDATE PeriodoDePago SET estado = 'Procesado' WHERE PeriodoDePago.id = '" + periodoDePago.getidPeriodoDePago() + "';";
            
            
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    periodoDePago = obtenerPeriodo(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el Periodo de Pago");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public PeriodoDePago obtenerPeriodo(SqlDataReader resultadoSQL)
        {
            PeriodoDePago periodoDePago = new PeriodoDePago();
            periodoDePago.setidPeriodoDePago(resultadoSQL.GetString(0));
            periodoDePago.setEstado(resultadoSQL.GetString(1));
            periodoDePago.setFechaFin(resultadoSQL.GetDateTime(2));
            periodoDePago.setFechaInicio(resultadoSQL.GetDateTime(3));
            periodoDePago.setSemanasDePeriodo(resultadoSQL.GetInt32(3));
            return periodoDePago;
        }
    }
}
