using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillaSofia
{
    public partial class FrmLoginUsuario : Form
    {
        public FrmLoginUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string password = txtpassword.Text;

            try
            {
                ClsControl ctrl = new ClsControl();
                string respuesta = ctrl.crtlLogin(usuario, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    VillaSofia frm = new VillaSofia();
                    frm.Visible = true;
                    this.Visible = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario registro = new FrmRegistroUsuario();
            registro.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLoginUsuario_Load(object sender, EventArgs e)
        {
            this.btnregistro.Visible = false;
            this.lblregistro.Visible = false;
        }
    }
}
