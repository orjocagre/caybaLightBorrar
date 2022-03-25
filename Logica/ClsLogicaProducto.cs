using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Logica
{
    public class ClsLogicaProducto
    {
        public String eliminarProducto(int id)
        {
            ClsDatosProducto producto = new ClsDatosProducto();
            int msj = producto.eliminarProducto(id);
            if (msj == 1)
            {
                return "";
            }
            else if (msj == 2)
            {
                return "El producto ya fue usado\nEn lugar de eliminarse se deshabilitará";
            }
            else
            {
                return "Error de sentencia SQL";
            }
        }
        public String insertarProductoInsumo(int Pid_producto, int Pid_insumo, double Pcantidad)
        {
            ClsDatosProducto producto = new ClsDatosProducto();
            int msj = producto.insertarProductoInsumo(Pid_producto, Pid_insumo, Pcantidad);
            String mensaje;
            if(msj == 1)
            {
                mensaje = "Guardado";
            }
            else if(msj == 2)
            {
                mensaje = "Id de producto o de insumo invalidos";
            }
            else
            {
                mensaje = "Error en sintaxis Sql";
            }
            return mensaje;
        }
        public void cambiarVisibilidad(int idProducto)
        {
            ClsDatosProducto producto = new ClsDatosProducto();
            producto.cambiarVisibilidad(idProducto);
        }

        //public String[] listadoClasificaciones()
        //{
        //    ClsLogicaTipoProducto tipoProd = new ClsLogicaTipoProducto();
        //    DataTable DT = tipoProd.buscarProducto("");

        //    String[] clasi = new string[DT.Rows.Count];

        //    for(int i=0; i<clasi.Length; i++)
        //    {
        //        clasi[i] = DT.Rows[i][0].ToString();
        //    }

        //    return clasi;
        //}
        public String insertarProducto(int reseve, String nombre, double precio, int clasificacion, int idProcedencia, int orden)
        {

            String mensaje;
            int msj;
            String nombrec = nombre.Replace(" ", "").ToLower();

            ClsDatosProducto producto = new ClsDatosProducto();

            msj = producto.insertarProducto(reseve, DateTime.Now, nombre, precio, clasificacion, idProcedencia, orden);

            if (msj == -2)
            {
                mensaje = "El producto ya existe";

            }
            else if (msj == -3)
            {
                mensaje = "Error al guardar";

            }
            else
            {
                mensaje = msj.ToString();
            }

            return mensaje;
        }

        public String moverProducto(int id, int posFinal)
        {
            ClsDatosProducto producto = new ClsDatosProducto();

            int msj = producto.moverProducto(id, posFinal);

            if (msj == 1)
            {
                return "";
            }
            else
            {
                return "Error en sintaxis Sql";
            }
        }

        public String editarProducto(int idreseve, int idProducto, String nombre, double precio, int clasificacion, int idProcedencia)
        {

            String mensaje;
            int msj;

            ClsDatosProducto producto = new ClsDatosProducto();

            msj = producto.editarProducto(idreseve, idProducto, nombre, precio, clasificacion, idProcedencia);



            if (msj == 1)
            {
                mensaje = "Producto Actualizado";

            }
            else if (msj == 2)
            {
                mensaje = "El producto ya existe";

            }
            else if (msj == 3)
            {
                mensaje = "Error al guardar";

            }
            else
            {
                mensaje = "Error no determinado";
            }

            return mensaje;
        }

        public String subirBajarProducto(int id, int upDown)
        {
            ClsDatosProducto producto = new ClsDatosProducto();
            int msj = producto.bajarSubirProducto(id, upDown);

            if (msj == 1)
            {
                return "";
            }
            else
            {
                return "Error en sintaxis Sql";
            }
        }

        public DataTable buscarProducto(String idProd)
        {
            String sql = "SELECT nombre AS Nombre, precio_actual AS Precio, producto.id_tipo_producto AS Clasificación, producto.id_procedencia AS Procedencia, idProducto AS Id, producto.id_restaurante_evento AS Menu FROM producto WHERE idProducto LIKE '%" + idProd + "%'";
            return new ClsDatosProducto().consulta(sql);
        }

        public DataTable buscarProductoTabla(Boolean deshabilitados)
        {
            String sql;
            if (deshabilitados)
            {
                sql = "SELECT producto.idProducto AS Id, producto.nombre AS Nombre, producto.precio_actual AS Precio, tipoproducto.descripcion AS Clasificacion, procedencia.descripcion AS Procedencia, restaurante_evento.descripcion AS Menu FROM producto, tipoproducto, procedencia, restaurante_evento WHERE restaurante_evento.id_restaurante_evento = producto.id_restaurante_evento AND tipoproducto.idTipoProducto = producto.id_tipo_producto AND procedencia.id_procedencia = producto.id_procedencia AND visible = 2 ORDER BY producto.orden";
            }
            else
            {
                sql = "SELECT producto.idProducto AS Id, producto.nombre AS Nombre, producto.precio_actual AS Precio, tipoproducto.descripcion AS Clasificacion, procedencia.descripcion AS Procedencia, restaurante_evento.descripcion AS Menu FROM producto, tipoproducto, procedencia, restaurante_evento WHERE restaurante_evento.id_restaurante_evento = producto.id_restaurante_evento AND tipoproducto.idTipoProducto = producto.id_tipo_producto AND procedencia.id_procedencia = producto.id_procedencia AND visible = 1 ORDER BY producto.orden";
            }
            return new ClsDatosProducto().consulta(sql);
        }

        


        public DataTable listarProductos(int id_restaurante_evento)
        {
            ClsDatosProducto registro = new ClsDatosProducto();
            String sql = "SELECT sinonimo.nombreF AS sinF, sinonimo.nombre AS sin, producto.nombre AS nom, producto.idProducto AS id FROM sinonimo, producto WHERE producto.idProducto = sinonimo.idProducto AND (producto.id_restaurante_evento = " + id_restaurante_evento.ToString() + " OR producto.id_restaurante_evento = 3) AND producto.visible = 1";
            return registro.consulta(sql);
        }

        
    }
}
