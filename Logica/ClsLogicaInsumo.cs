using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class ClsLogicaInsumo
    {

        public String agregarInsumo(String Pdescripcion, int Porden, int Pid_um, double Ppeso_llena, double Ppeso_vacia, double Ptamano)
        {
            String mensaje;
            int msj;
            String PdescripcionF = Pdescripcion.Replace(" ", "").ToLower();

            ClsDatosInsumo insumo = new ClsDatosInsumo();

            msj = insumo.agregarInsumo(Pdescripcion, PdescripcionF, Porden, Pid_um, Ppeso_llena, Ppeso_vacia,Ptamano);

            if (msj == -2)
            {
                mensaje = "El insumo ya existe";

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

        public DataTable listarInsumos()
        {
            ClsDatosInsumo insumo = new ClsDatosInsumo();
            String sql = "SELECT insumo.id_insumo AS ID, insumo.descripcion AS DESCRIPCION, um.descripcion AS UM FROM insumo, um WHERE insumo.id_um = um.id_um AND insumo.visible = 1 ORDER BY insumo.orden";
            return insumo.consulta(sql);
        }


        public DataTable listarInsumosInventario()
        {
            ClsDatosInsumo insumo = new ClsDatosInsumo();
            String sql = "SELECT insumo.id_insumo AS ID, insumo.descripcion AS NOMBRE FROM insumo WHERE insumo.visible = 1 ORDER BY insumo.orden";
            return insumo.consulta(sql);
        }

        public DataTable listarInsumosInventarioA()
        {
            ClsDatosInsumo insumo = new ClsDatosInsumo();
            String sql = "SELECT insumo.id_insumo AS ID, insumo.descripcion AS NOMBRE FROM insumo WHERE insumo.visible = 1 AND insumo.peso_llena IS NOT NULL ORDER BY insumo.orden";
            return insumo.consulta(sql);
        }

        public DataTable listarInsumosBarra()
        {
            ClsDatosProducto registro = new ClsDatosProducto();
            String sql = "SELECT insumo.descripcionF AS sinF, insumo.descripcion AS sin, insumo.descripcion AS nom, insumo.id_insumo AS id FROM insumo WHERE insumo.visible = 1";
            return registro.consulta(sql);
        }

        public DataTable listarInsumosBarraA()
        {
            ClsDatosProducto registro = new ClsDatosProducto();
            String sql = "SELECT insumo.descripcionF AS sinF, insumo.descripcion AS sin, insumo.descripcion AS nom, insumo.id_insumo AS id FROM insumo WHERE insumo.visible = 1 AND insumo.peso_llena IS NOT NULL";
            return registro.consulta(sql);
        }
    }
}
