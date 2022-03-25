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
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsUsuarios usuario = new ClsUsuarios();
            usuario.Usuario1 = textBox1.Text;
            usuario.Password = textBox2.Text;
            usuario.ConPassword = textBox3.Text;
            usuario.Nombre = textBox4.Text;

            try
            {


                ClsControl control = new ClsControl();
                String respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario Registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
