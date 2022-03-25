using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class ClsLogicaInventario
    {
        public int agregarInventario(DateTime fecha, int inicial)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            return inventario.agregarInventario(fecha, inicial);

        }

        public String agregarInventarioInsumo(int Pid_inventario, int Pid_insumo, double Pcantidad, int PporPeso)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            int msj = inventario.agregarInventarioProducto(Pid_inventario, Pid_insumo, Pcantidad, PporPeso);

            return msj == 1 ? "Item agregado" : "Error en sintaxis Sql";
        }

        public int buscarInventario(int idConjunto, int inicial)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "SELECT inventario.id_inventario FROM inventario WHERE inventario.id_conjunto = "+idConjunto+ " AND inventario.inicial = "+inicial;
            DataTable DT = inventario.consulta(sql);

            if(DT.Rows.Count > 0)
            {
                return DT.Rows[DT.Rows.Count-1].Field<int>(0);
                    
            }
            else
            {
                return -1;
            }
        }


        public DataTable listarInventarioCierre(int idConjunto, int inicial)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "SELECT producto.orden AS ORDEN, producto.idProducto AS ID ,producto.nombre AS NOMBRE, inventario_producto.cantidad AS CANTIDAD FROM producto, inventario_producto, inventario WHERE producto.idProducto = inventario_producto.id_producto AND inventario_producto.id_inventario = inventario.id_inventario AND inventario.id_conjunto = "+idConjunto+" AND producto.visible = 1 AND inventario.inicial = "+inicial+" ORDER BY producto.orden";
            return inventario.consulta(sql);
        }

        public DataTable listarVentasBarraCierre(int idConjunto)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "SELECT producto.orden AS ORDEN, producto.idProducto AS ID ,producto.nombre AS NOMBRE, SUM(orden.cantidad) AS VENTA FROM orden, producto, factura WHERE orden.id_producto = producto.idProducto AND orden.id_factura = factura.id_factura AND factura.id_conjunto = " + idConjunto + " AND producto.id_procedencia = 2 GROUP BY producto.idProducto ORDER BY producto.orden";
            return inventario.consulta(sql);
        }


        public DataTable listarVentasCierre(int idConjunto)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "SELECT producto.orden AS ORDEN, producto.idProducto AS ID ,producto.nombre AS NOMBRE, SUM(orden.cantidad) AS VENTA FROM orden, producto, factura WHERE orden.id_producto = producto.idProducto AND orden.id_factura = factura.id_factura AND factura.id_conjunto = "+idConjunto+" GROUP BY producto.idProducto ORDER BY producto.orden";
            return inventario.consulta(sql);
        }

        public DataTable listarInventarioPreguardado(int idInventario)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "SELECT inventario_insumo.cantidad, inventario_insumo.id_insumo, inventario_insumo.id_inventario FROM inventario_insumo, insumo WHERE id_inventario = "+idInventario+" AND insumo.id_insumo = inventario_insumo.id_insumo ORDER BY insumo.orden";
            return inventario.consulta(sql);
        }

        public DataTable listarInventarioPreguardadoA(int idInventario)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "SELECT inventario_insumo.cantidad, inventario_insumo.id_insumo, inventario_insumo.id_inventario, insumo.peso_liquido, insumo.peso_vacia FROM inventario_insumo, insumo WHERE inventario_insumo.id_inventario = " + idInventario+" AND insumo.id_insumo = inventario_insumo.id_insumo AND insumo.peso_vacia IS NOT NULL ORDER BY insumo.orden";
            return inventario.consulta(sql);
        }

        public DataTable listarMlporGr(int idInventario)
        {
            ClsDatosInventario inventario = new ClsDatosInventario();
            String sql = "SELECT inventario_insumo.cantidad, inventario_insumo.id_insumo, inventario_insumo.id_inventario FROM inventario_insumo, insumo WHERE id_inventario = " + idInventario + " AND insumo.id_insumo = inventario_insumo.id_insumo AND insumo.peso_vacia IS NOT NULL ORDER BY insumo.orden";
            return inventario.consulta(sql);
        }

        //public DateTime fechaInventario(int idInventario)
        //{
        //    ClsDatosInventario inventario = new ClsDatosInventario();
        //    String sql = "SELECT inventario.fecha, inventario.hora FROM inventario WHERE inventario.id_inventario = "+idInventario;
        //    DataTable DT = inventario.consulta(sql);

        //    DateTime fecha = new DateTime(Convert.ToInt32(DT.Rows[0][0].ToString().Substring(6, 4)), Convert.ToInt32(DT.Rows[0][0].ToString().Substring(3, 2)), Convert.ToInt32(DT.Rows[0][0].ToString().Substring(0, 2)), Convert.ToInt32(DT.Rows[0][1].ToString().Substring(0, 2)), Convert.ToInt32(DT.Rows[0][1].ToString().Substring(3, 2)), Convert.ToInt32(DT.Rows[0][1].ToString().Substring(6, 2)));

        //    return fecha;

        //}

    }
}
