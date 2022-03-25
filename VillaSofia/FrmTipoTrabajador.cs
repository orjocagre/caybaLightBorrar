using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace VillaSofia
{
    public partial class FrmTipoTrabajador : Form
    {
        public FrmTipoTrabajador()
        {
            InitializeComponent();
        }

      

        private void FrmTipoTrabajador_Load(object sender, EventArgs e)
        {
            LoadTipoTrabajador();

        }
        void LoadTipoTrabajador()
        {
            ClsLogicaTipoTrabajador Load = new ClsLogicaTipoTrabajador();

            dagTipoTrabajadores.DataSource = Load.ListarTrabajadores();
            dagTipoTrabajadores.Columns[0].Visible = false;

        }
        Boolean ValidarTexbox()
        {
            if (TxtTipoTrabajador.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        //Validacion de texbox letras

        private void TxtTipoTrabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar!=(char)Keys.Space)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras, ingrese nuevamente el cargo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
           

        }
        string IngresarTipoT()
        {
            string resp;
            ClsLogicaTipoTrabajador AddTTipo = new ClsLogicaTipoTrabajador();
            resp = AddTTipo.AddTipoT(TxtTipoTrabajador.Text);



            return resp;

        }
      

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (ValidarTexbox())
            {


                string msj = IngresarTipoT();
                LoadTipoTrabajador();

                MessageBox.Show(msj);
            }
            else
            {
                MessageBox.Show("No supero la validaciòn");
            }
        }
    }
}
