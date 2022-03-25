using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class ClsLogicaProforma
    {

        public DataTable buscarProductosEventos()
        {
            String sql = "SELECT idProducto AS Id, nombre AS NOMBRE, precio_actual AS PRECIO FROM producto WHERE producto.id_restaurante_evento <> 1";
            ClsDatosProforma proforma = new ClsDatosProforma();
            return proforma.consulta(sql);
        
        }

        
    }
}
