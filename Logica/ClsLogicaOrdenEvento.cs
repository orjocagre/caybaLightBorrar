using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class ClsLogicaOrdenEvento
    {
        public String agregarOrdenEvento(int Pid_Producto, double Pcantidad, double Pprecio_unitario)
        {
            ClsDatosOrdenEvento orden = new ClsDatosOrdenEvento();
            int msj = orden.agregarOrdenEvento(Pid_Producto, Pcantidad, Pprecio_unitario);

            return msj == 1 ? "Guardado Correctamente" : "Error en sintaxis Sql";

        }

        public int vincularOrdenEvento(int idEvento)
        {
            ClsDatosOrdenEvento orden = new ClsDatosOrdenEvento();
            return orden.vincularOrdenEvento(idEvento);


        }
        public int desVincularOrdenEvento(int idEvento)
        {
            ClsDatosOrdenEvento orden = new ClsDatosOrdenEvento();
            return orden.desVincularOrdenEvento(idEvento);


        }

        public double precioOrdenes()
        {
            ClsDatosOrdenEvento orden = new ClsDatosOrdenEvento();
            String sql = "SELECT SUM(cantidad * precio_unitario) FROM orden_evento WHERE ISNULL(id_evento)";
            DataTable DT = orden.consulta(sql);
            try
            {
                return DT.Rows[0].Field<Double>(0);

            }
            catch(InvalidCastException e)
            {
                return 0;
            }

        }

        public DataTable tablaOrdenesSinIdEvento()
        {
            ClsDatosOrdenEvento orden = new ClsDatosOrdenEvento();
            String sql = "SELECT id_producto AS ID_PRODUCTO, cantidad AS CANTIDAD, nombre AS NOMBRE, precio_unitario AS PRECIO FROM orden_evento, producto WHERE orden_evento.id_producto = producto.idProducto AND ISNULL(id_evento)";
            return orden.consulta(sql);
        }

        public DataTable tablaOrdenes(int idEvento)
        {
            ClsDatosOrdenEvento orden = new ClsDatosOrdenEvento();
            String sql = "SELECT id_producto AS ID_PRODUCTO, cantidad AS CANT, nombre AS NOMBRE, precio_unitario AS PRECIO FROM orden_evento, producto WHERE orden_evento.id_producto = producto.idProducto AND id_evento = "+idEvento;
            return orden.consulta(sql);
        }



        public void eliminarRegistrosAnonimos()
        {
            ClsDatosOrdenEvento orden = new ClsDatosOrdenEvento();
            String sql = "DELETE FROM orden_evento WHERE ISNULL(id_evento)";
            orden.consulta(sql);
        }
    }
}
