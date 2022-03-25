using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class ClsLogicaOrden
    {
        public String agregarOrden(int Pid_Producto, int Pid_factura, double Pcantidad, double Pprecio_unitario)
        {
            ClsDatosOrden orden = new ClsDatosOrden();
            int msj = orden.agregarOrden(Pid_Producto, Pid_factura, Pcantidad, Pprecio_unitario);

            if(msj == 1)
            {
                return "Agregada correctamente";
            }
            else
            {
                return "Error en sintaxis Sql";
            }


        }
        
        public DataTable vaciarFactura(int idFactura)
        {
            ClsDatosOrden orden = new ClsDatosOrden();
            String sql = "DELETE FROM orden WHERE orden.id_factura = " + idFactura;
            return orden.consulta(sql);
        }

        public DataTable listarOrdenes(int idFactura)
        {
            ClsDatosOrden orden = new ClsDatosOrden();
            String sql = "SELECT producto.idProducto AS ID, orden.cantidad AS CANTIDAD, producto.nombre AS NOMBRE, orden.precio_unitario AS PRECIO FROM producto, orden WHERE producto.idProducto = orden.id_producto AND orden.id_factura = " + idFactura;
            return orden.consulta(sql);
        }
    }
}
