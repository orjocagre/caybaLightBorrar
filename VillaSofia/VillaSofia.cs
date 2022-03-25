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
    public partial class VillaSofia : Form
    {
        private int childFormNumber = 0;

        public VillaSofia()
        {
            InitializeComponent();
        }
       
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
            
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void VillaSofia_Load(object sender, EventArgs e)
        {
            CduMenuPrincipal mp = new CduMenuPrincipal(this);
            this.Controls.Add(mp);

            int tipousuario = ClsSession.id_tipo;
            if (tipousuario == 1)
            {
                
                
            }
            else if (tipousuario == 2)
            {
                //this.lblCajero.Visible = true;
                //this.lblRol.Visible = false;
                //this.fileMenu.Visible = false;
            }
            

           
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto pro = new FrmProducto(this);
            pro.Show();
            pro.BringToFront();
        }

        private void trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroTrabajador trabajador = new FrmRegistroTrabajador(this);
            trabajador.Show();
            trabajador.BringToFront();


        }

        private void recetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarReceta receta = new FrmIngresarReceta(this);
            receta.Show();
            receta.BringToFront();
        }

        private void inicioSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminstrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario registro = new FrmRegistroUsuario();
            registro.Show();
            registro.BringToFront();
               
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            FrmLoginUsuario sesion = new FrmLoginUsuario();
            sesion.Show();
            VillaSofia frm = new VillaSofia();
            frm.Close();
            frm.Visible = false;

        }
    }
}
