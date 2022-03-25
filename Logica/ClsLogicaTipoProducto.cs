using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Logica
{
    public class ClsLogicaTipoProducto
    {
        public String eliminarTipoProducto(int id)
        {
            ClsDatosTipoProducto tipoProducto = new ClsDatosTipoProducto();
            int msj = tipoProducto.eliminarTipoProducto(id);

            String mensaje;

            if (msj == 1)
            {
                mensaje = "";
            }
            else if (msj == 2)
            {
                mensaje = "La clasificación no se puede eliminar\nYa que fue usada en Productos";
            }
            else if (msj == 3)
            {
                mensaje = "Error en sintaxis Sql";
            }
            else
            {
                mensaje = "Error no determinado";
            }

            return mensaje;
        }
        public String moverTipoProducto(int id, int posFinal)
        {
            ClsDatosTipoProducto tipoProducto = new ClsDatosTipoProducto();

            int msj = tipoProducto.moverTipoProducto(id, posFinal);

            if (msj == 1)
            {
                return "";
            }
            else
            {
                return "Error en sintaxis Sql";
            }
        }

        public String subirBajarTipoProducto(int id, int upDown)
        {
            ClsDatosTipoProducto tipoProducto = new ClsDatosTipoProducto();
            int msj = tipoProducto.bajarSubirTipoProducto(id, upDown);

            if (msj == 1)
            {
                return "";
            }
            else
            {
                return "Error en sintaxis Sql";
            }
        }
        public String editarTipoProducto(int id, String descripcion)
        {

            ClsDatosTipoProducto tipoProducto = new ClsDatosTipoProducto();
            int msj = tipoProducto.actualizarTipoProducto(id, descripcion);
            String mensaje;

            if (msj == 1)
            {
                mensaje = "Clasificación Actualizada";
            }
            else if (msj == 2)
            {
                mensaje = "Clasificación ya existente";
            }
            else if (msj == 3)
            {
                mensaje = "Error en sintaxis Sql";
            }
            else
            {
                mensaje = "Error no determinado";
            }
            return mensaje;


        }

        public String insertarTipoProducto(String descripcion, int orden)
        {

            String mensaje;



            ClsDatosTipoProducto tipoProducto = new ClsDatosTipoProducto();
            int msj = tipoProducto.insertarTipoProducto(descripcion, orden);

            if (msj == 1)
            {
                mensaje = "Clasificación Guardada";

            }
            else if (msj == 2)
            {
                mensaje = "La clasificación ya existe";

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

        //public DataTable buscarProducto(String idTipoProd)
        //{
        //    String sql = "SELECT descripcion AS Clasificación FROM tipoproducto WHERE idTipoProducto LIKE '%" + idTipoProd + "%'";
        //    return new ClsDatosTipoProducto().buscarTipoProducto(sql);

        //}
        public DataTable buscarProducto()
        {
            String sql = "SELECT * FROM tipoproducto ORDER BY orden";
            return new ClsDatosTipoProducto().buscarTipoProducto(sql);

        }
        //public DataTable buscarProductoxClasificacion(String clasificacion)
        //{
        //    String sql = "SELECT idTipoProducto AS idTP FROM tipoproducto WHERE descripcion LIKE '%" + clasificacion + "%'";
        //    return new ClsDatosTipoProducto().buscarTipoProducto(sql);

        //}
    }
}
