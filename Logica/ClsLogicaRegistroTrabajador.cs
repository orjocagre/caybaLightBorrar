using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Logica
{
   public class ClsLogicaRegistroTrabajador
    {

        public String ingresarDatosTrabajador(string cedula, string nombre, string apellidos)
        {

            ClsLogicaPersona AddPersona = new ClsLogicaPersona();


            string X = AddPersona.Agregarpersona(cedula, nombre, apellidos);
            return X;

        }


        public int ingresarTelefonoTrabajador(int numero)
        {

            ClsLogicaTelefono AddTelefono = new ClsLogicaTelefono();


            int X = AddTelefono.agregarTelefono(numero);
            return X;

        }

        public void ingresarPersonaTelefono(int numero, int idPersona)
        {

            ClsLogicaTelefonoPersona AddPersonaTelefono = new ClsLogicaTelefonoPersona();
            AddPersonaTelefono.ingresarTelefonoPersona(numero, idPersona);


        }


        public string ingresarTrabajador(int idPersona, int idTipoTraabajador, double salario)
        {


            ClsDatosRegistroTrabajador AddTrabahador = new ClsDatosRegistroTrabajador();

            int a = AddTrabahador.agregarTrabajador(idPersona, idTipoTraabajador, salario);
            string U = "";

            if (a == 1)
            {

                U = "Este trabajador ya esta registrado, ingrese un nuevo trabajador";



            }
            if (a == 7)
            {
                U = "Este trabajador se registro con exito!";
            }

            return U;



        }

        public String editarTrabajador(int PidTrabajador, String Pcedula, String Pnombres, String Papellidos, int Pid_tipo_trabajador, double Psalario, int Pnumero)
        {
            ClsDatosRegistroTrabajador regtra = new ClsDatosRegistroTrabajador();
            int msj = regtra.editarTrabajador(PidTrabajador, Pcedula, Pnombres, Papellidos, Pid_tipo_trabajador, Psalario, Pnumero);
            if (msj == 1)
            {
                return "Producto actualizado";
            }
            else
            {
                return "Error en sintaxis Sql";
            }
        }

        public string EliminarTrabajador(int idTrabajador)
        {
            int i;
            ClsDatosRegistroTrabajador trabajador = new ClsDatosRegistroTrabajador();

            i = trabajador.EliminarTrabajador(idTrabajador);
            String mensaje;



            if (i == -1)
            {
                mensaje = "Error al Eliminar";
            }
            else
            {
                mensaje = "Error al Eliminar";
            }



            return mensaje;
        }

        public DataTable llenarCmbMeseros()
        {
            ClsDatosRegistroTrabajador trabajador = new ClsDatosRegistroTrabajador();
            String sql = "SELECT trabajador.id_trabajador AS ID, persona.nombres AS NOMBRE FROM persona, trabajador WHERE persona.idPersona = trabajador.id_Persona AND trabajador.id_tipo_trabajador = 1";
            DataTable DT = trabajador.ListarTrabajadores(sql);
            DT.Rows.Add();
            DT.Rows[DT.Rows.Count - 1][0] = -1;
            DT.Rows[DT.Rows.Count - 1][1] = "Barra";
            return DT;
        }

        public DataTable ListarTrabajadores(String x)
        {
            String sql = "SELECT * FROM vistatrabajador WHERE vistatrabajador.cedula LIKE '%" + x + "%'";
            Datos.ClsDatosRegistroTrabajador Lista = new Datos.ClsDatosRegistroTrabajador();

            DataTable DT = new DataTable();
            DT = Lista.ListarTrabajadores(sql);
            return DT;
        }




    }
}
