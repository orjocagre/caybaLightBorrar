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
    public partial class FrmUM : Form
    {
        FrmIngresarReceta receta;
        public FrmUM(FrmIngresarReceta receta)
        {
            this.receta = receta;
            InitializeComponent();
        }

        private void FrmUM_Load(object sender, EventArgs e)
        {
            LoadUM();
            
        }


        Boolean ValidarTexbox()
        {
            if (txtUM.Text != "" )
            {
                return true;
            }
            else
            {
                return false;
            }


        }



        void LoadUM()
        {
            ClsLogicaUM Load = new ClsLogicaUM();

            dgvUM.DataSource = Load.UM();
            receta.comboUM();


        }
        //Validacion de texbox letras
        private void txtUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Space)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se letras, ingrese nuevamente la unidad de medida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }

        }
        string IngresarUM()
        {
            string resp;
            ClsLogicaUM AddUM = new ClsLogicaUM();
            resp = AddUM.AddUM(txtUM.Text);



            return resp;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarTexbox())
            {


                string msj= IngresarUM();
                LoadUM();

                MessageBox.Show(msj);
            }
            else
            {
                MessageBox.Show("No supero la validaciòn");
            }

        }

        
    }
    }

