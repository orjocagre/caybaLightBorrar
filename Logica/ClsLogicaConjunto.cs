using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class ClsLogicaConjunto
    {
        public int agregarConjunto(DateTime fechaInicio)
        {
            ClsDatosConjunto conjunto = new ClsDatosConjunto();
            return conjunto.agregarConjunto(fechaInicio);   
        }

        public String cerrarConjunto(int PidConjunto, DateTime Pfecha)
        {
            ClsDatosConjunto conjunto = new ClsDatosConjunto();
            return conjunto.cerrarConjunto(PidConjunto, Pfecha) == 1 ? "Conjunto cerrado" : "Error en sintaxis Sql";
        }
        public DataTable listarConjuntos()
        {
            ClsDatosConjunto conjunto = new ClsDatosConjunto();
            String sql = "SELECT id_conjunto AS ID, fecha_inicio AS FECHA, abierto AS ABIERTO FROM conjunto";
            return conjunto.consulta(sql);
        }

        public String buscarFechaConjunto(int idConjunto)
        {
            ClsDatosConjunto conjunto = new ClsDatosConjunto();
            String sql = "SELECT conjunto.fecha_inicio FROM conjunto WHERE conjunto.id_conjunto = "+idConjunto;
            return conjunto.consulta(sql).Rows[0].Field<DateTime>(0).ToString("dd-MM-yyy");
        }
    }
}
