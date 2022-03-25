using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class ClsLogicaFactura
    {

        public int agregarFactura(DateTime Pfecha, int Pnum_mesa, String Pnombre, String PRUC, int Pid_trabajador, int Pid_estado_factura)
        {
            ClsDatosFactura factura = new ClsDatosFactura();
            return factura.agregarFactura(Pfecha, Pnum_mesa, Pnombre, PRUC, Pid_trabajador, Pid_estado_factura);

        }

        public int agregarDatosFactura(int id_factura, String Pnombre, String PRUC, int Pid_trabajador)
        {
            ClsDatosFactura factura = new ClsDatosFactura();
            return factura.agregarDatosFactura(id_factura, Pnombre, PRUC, Pid_trabajador);

        }

        public DataTable listarFacturas(int idConjunto)
        {
            ClsDatosFactura factura = new ClsDatosFactura();
            String sql = "SELECT factura.id_factura AS Num, factura.total AS TOTAL, efectivo AS EFECTIVO, tarjeta AS TARJETA  FROM factura WHERE factura.id_conjunto = " + idConjunto;
            return factura.consulta(sql);

        }

        public Boolean validarFacturasCanceladas(int idConjunto)
        {
            ClsDatosFactura factura = new ClsDatosFactura();
            String sql = "SELECT * FROM factura WHERE factura.id_conjunto = "+idConjunto+" AND factura.id_estado_factura < 3";
            if (factura.consulta(sql).Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public String agregarPagoFactura(int idFactura, double Pefectivo, double Ptarjeta)
        {

            ClsDatosFactura factura = new ClsDatosFactura();
            int msj = factura.agregarPagoFactura(idFactura, Pefectivo, Ptarjeta);

            if(msj ==1)
            {
                return "Pago guardado correctamete";
            }
            else
            
            {
                return "Error en sintaxis Sql";
            }
        }

            public DataTable mostrarFacturasSinCancelarparaPanel(int idConjunto)
        {
            ClsDatosFactura factura = new ClsDatosFactura();
            String sql = "SELECT factura.id_factura AS ID, factura.id_estado_factura AS ESTADO FROM factura WHERE factura.id_conjunto = " + idConjunto + " AND (id_estado_factura = 1 OR id_estado_factura = 2)";
            return factura.consulta(sql);
        }

        public DataTable infoFactura(int idFactura)
        {
            ClsDatosFactura factura = new ClsDatosFactura();
            String sql = "SELECT * FROM factura WHERE factura.id_factura = " + idFactura;
            return factura.consulta(sql);
        }

        public String guardarTotalFactura(int PidFactura, double Ptotal)
        {
            ClsDatosFactura factura = new ClsDatosFactura();
            int msj = factura.guardarTotalFactura(PidFactura, Ptotal);
            
            if(msj == 1)
            {
                return "Guardado correctamente";
            }
            else
            {
                return "Error en sintaxis Sql";
            }
        }


        public DataTable mostrarFacturasparaPanel(int idConjunto)
        {
            ClsDatosFactura factura = new ClsDatosFactura();
            String sql = "SELECT factura.id_factura AS ID, factura.id_estado_factura AS ESTADO FROM factura WHERE factura.id_conjunto = "+idConjunto;
            Console.WriteLine(sql);
            return factura.consulta(sql);
        }

        public void cambiarEstadoFactura(int Pid_factura, int Pid_estado_factura)
        {
            ClsDatosFactura factura = new ClsDatosFactura();
            factura.cambiarEstadoFactura(Pid_factura, Pid_estado_factura);
        }

        public DataTable mostrarEstadoFactura(int idFactura)
        {
            ClsDatosFactura factura = new ClsDatosFactura();
            return factura.consulta("SELECT id_estado_factura FROM factura WHERE factura.id_factura = "+idFactura);
        
        }
        
    }
}
