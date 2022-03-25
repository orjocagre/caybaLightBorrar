using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class ClsLogicaMovimiento
    {

        public String agregarMovimiento(int Pid_conjunto, double Pmonto, int Pentrada, String Pdescripcion, DateTime Pfecha)
        {
            ClsDatosMovimiento movimiento = new ClsDatosMovimiento();
            int msj = movimiento.agregarMovimiento(Pid_conjunto, Pmonto, Pentrada, Pdescripcion, Pfecha);

            return msj == 1 ? "Guardado" : "Error en sintaxis Sql";
        }

        public void eliminarMovimientos(int idMovimiento)
        {
            ClsDatosMovimiento movimiento = new ClsDatosMovimiento();
            String sql = "DELETE FROM movimiento WHERE movimiento.id_movimiento = " + idMovimiento;
            movimiento.consulta(sql);
        }

        public DataTable listarMovimientos(int idConjunto)
        {
            ClsDatosMovimiento movimiento = new ClsDatosMovimiento();
            String sql = "SELECT movimiento.id_movimiento AS ID, movimiento.monto AS MONTO, movimiento.descripcion AS DESCRIPCIÓN, movimiento.fecha AS HORA, movimiento.entrada AS ENTRADA FROM movimiento WHERE movimiento.id_conjunto = " + idConjunto;
            return movimiento.consulta(sql);
        }
    }
}
