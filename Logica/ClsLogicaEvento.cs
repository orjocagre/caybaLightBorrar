using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class ClsLogicaEvento
    {

        public void cambiarEstadoEvento(int Popcion, int estado, int PidEvento)
        {
            ClsDatosEvento eve = new ClsDatosEvento();
            eve.cambiarEstadoEvento(Popcion, estado, PidEvento);

        }

        public String editarEvento(int idEvento, DateTime Pfecha_contrato, DateTime Pfecha_evento, int Pid_tipo_evento, int Pnum_personas, String Phora_inicio, int Pid_tipo_servicio, int Psolo_local, String Phora_comida, int Phora_extra, String Pcomentarios, double Ptotal, double Panticipo, double Ppendiente, int PanticipoCancelado, int PtotalCancelado, String Pnombres, String Papellidos, String Pcedula, int Pnumero, int[] areas)
        {
            ClsDatosEvento evento = new ClsDatosEvento();
            int msj = evento.editarEvento(idEvento, Pfecha_contrato, Pfecha_evento, Pid_tipo_evento, Pnum_personas, Phora_inicio, Pid_tipo_servicio, Psolo_local, Phora_comida, Phora_extra, Pcomentarios, Ptotal, Panticipo, Ppendiente, PanticipoCancelado, PtotalCancelado, Pnombres, Papellidos, Pcedula, Pnumero);

            if (msj == 3)
            {
                return "Error en sintaxis Sql";
            }
            else
            {
                ClsDatosOrdenEvento orden = new ClsDatosOrdenEvento();
                int msj2 = orden.vincularOrdenEvento(idEvento);
                eliminarAreasEvento(idEvento);

                for (int i = 0; i < areas.Length; i++)
                {
                    if (areas[i] == 1)
                    {
                        if (agregarAreaEvento(i + 1, idEvento) == 3)
                        {
                            return "Error en sintaxis Sql";
                        }

                    }
                }

                return msj2 == 1 ? "Evento Actualizado" : "Error en sintaxis Sql";
            }
        }

        public String agregarEvento(DateTime Pfecha_contrato, DateTime Pfecha_evento, int Pid_tipo_evento, int Pnum_personas, String Phora_inicio, int Pid_tipo_servicio, int Psolo_local, String Phora_comida, int Phora_extra, String Pcomentarios, double Ptotal, double Panticipo, double Ppendiente, int PanticipoCancelado, int PtotalCancelado, String Pnombres, String Papellidos, String Pcedula, int Pnumero, int[] areas)
        {
            ClsDatosEvento evento = new ClsDatosEvento();
            int idEve = evento.agregarEvento(Pfecha_contrato, Pfecha_evento, Pid_tipo_evento, Pnum_personas, Phora_inicio, Pid_tipo_servicio, Psolo_local, Phora_comida, Phora_extra, Pcomentarios, Ptotal, Panticipo, Ppendiente, PanticipoCancelado, PtotalCancelado, Pnombres, Papellidos, Pcedula, Pnumero);

            if(idEve == -3)
            {
                return "Error en sintaxis Sql";
            }
            else
            {
                ClsDatosOrdenEvento orden = new ClsDatosOrdenEvento();
                int msj = orden.vincularOrdenEvento(idEve);

                for(int i=0; i<areas.Length; i++)
                {
                    if(areas[i] == 1)
                    {
                        if(agregarAreaEvento(i + 1, idEve) == 3)
                        {
                            return "Error en sintaxis Sql";
                        }

                    }
                }

                return msj == 1 ? "Evento Guardado" : "Error en sintaxis Sql";
            }
        }


        

        public int agregarAreaEvento(int idArea, int idEvento)
        {
            ClsDatosEvento evento = new ClsDatosEvento();
            return evento.agregarAreaEvento(idArea, idEvento);
            
        }

        public void eliminarAreasEvento(int idEvento)
        {
            ClsDatosEvento evento = new ClsDatosEvento();
            evento.consultas("DELETE FROM area_evento WHERE area_evento.id_evento = " + idEvento);
        }

        public void cambiarEstadoEvento(int Popcion, int PidEvento)
        {
            ClsDatosEvento eve = new ClsDatosEvento();
            eve.cambiarEstadoEvento(Popcion, PidEvento);

        }


        public DataTable buscarEventosCalendario(DateTime fechaInicio, DateTime fechaFin)
        {
            String sql = "SELECT id_evento, fecha_evento, tipo_evento.descripcion, persona.nombres, persona.apellidos  FROM evento, tipo_evento, cliente, persona WHERE tipo_evento.id_tipo_evento = evento.id_tipo_evento AND evento.id_cliente = cliente.id_cliente AND cliente.id_persona = persona.idPersona AND fecha_evento >= '" + fechaInicio.ToString("yyy-MM-dd") + "' AND fecha_evento <= '" + fechaFin.ToString("yyy-MM-dd") + "' ORDER BY fecha_evento";
            return new ClsDatosEvento().consultas(sql);
        
        }

        public DataTable cmbTipoEvento()
        {
            String sql = "SELECT id_tipo_evento AS ID, descripcion AS TIPO FROM tipo_evento";
            return new ClsDatosEvento().consultas(sql);
        }

        public DataTable infoEventosEditar(int idEvento)
        {
            String sql = "SELECT persona.nombres AS NOMBRE, persona.apellidos AS APELLIDO, telefono.numero AS TELEFONO, persona.cedula AS CEDULA, evento.id_tipo_evento AS TIPOEVENTO, evento.fecha_evento AS FECHA, evento.hora_inicio AS HORA, evento.hora_extra AS HORAEXTRA, evento.hora_comida AS HORACOMIDA, evento.comentarios AS COMENTARIOS, evento.num_personas AS PERSONAS, evento.id_tipo_servicio AS TIPOSERVICIO, evento.total AS TOTAL, anticipo AS ANTICIPO, evento.totalCancelado AS TOTALCANCELADO, evento.anticipoCancelado AS ANTICIPOCANCELADO FROM persona, cliente, evento, tipo_evento, telefono, telefono_persona, tipo_servicio WHERE tipo_servicio.id_tipo_servicio = evento.id_tipo_servicio AND persona.idPersona = cliente.id_persona AND evento.id_cliente = cliente.id_cliente AND tipo_evento.id_tipo_evento = evento.id_tipo_evento AND telefono_persona.id_persona = persona.idPersona AND telefono_persona.id_telefono = telefono.id_telefono AND evento.id_evento = " + idEvento;
            return new ClsDatosEvento().consultas(sql);
        }

        public DataTable InfoEventos(int idEvento)
        {
            String sql = "SELECT CONCAT_WS(' ',persona.nombres,persona.apellidos) AS NOMBRE, telefono.numero AS TELEFONO, persona.cedula AS CEDULA, tipo_evento.descripcion AS TIPOEVENTO, evento.fecha_evento AS FECHA, evento.hora_inicio AS HORA, evento.hora_extra AS HORAEXTRA, evento.hora_comida AS HORACOMIDA, evento.comentarios AS COMENTARIOS, evento.num_personas AS PERSONAS, tipo_servicio.descripcion AS TIPOSERVICIO, evento.total AS TOTAL, anticipo AS ANTICIPO, evento.totalCancelado AS TOTALCANCELADO, evento.anticipoCancelado AS ANTICIPOCANCELADO FROM persona, cliente, evento, tipo_evento, telefono, telefono_persona, tipo_servicio WHERE tipo_servicio.id_tipo_servicio = evento.id_tipo_servicio AND persona.idPersona = cliente.id_persona AND evento.id_cliente = cliente.id_cliente AND tipo_evento.id_tipo_evento = evento.id_tipo_evento AND telefono_persona.id_persona = persona.idPersona AND telefono_persona.id_telefono = telefono.id_telefono AND evento.id_evento = " + idEvento;
            return new ClsDatosEvento().consultas(sql);
        }

        public String areasEvento(int idEvento)
        {
            String sql = "SELECT area.descripcion FROM area, evento, area_evento WHERE area.id_area = area_evento.id_area AND area_evento.id_evento = evento.id_evento AND evento.id_evento = " + idEvento;
            DataTable DT = new ClsDatosEvento().consultas(sql);
            String msj = "En";

            for(int i=0; i<DT.Rows.Count; i++)
            {

                if(i != 0 && i != DT.Rows.Count - 1)
                {
                    msj += ",";
                }
                if (i == DT.Rows.Count - 1 && DT.Rows.Count != 1)
                {
                    msj += " y";
                }
                msj += " " + DT.Rows[i][0].ToString().ToLower();

            }

            return msj;

        
        }

        public DataTable InfoPlatos(int idEvento)
        {
            return new ClsLogicaOrdenEvento().tablaOrdenes(idEvento);
        }
    }
}
