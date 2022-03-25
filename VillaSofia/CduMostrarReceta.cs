using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace VillaSofia
{
    public partial class CduMostrarReceta : UserControl
    {

        int idReceta;
        VillaSofia principal;

        public CduMostrarReceta(VillaSofia principal)
        {
            this.principal = principal;
            idReceta = -1;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

       
        

        private void CduMostrarReceta_Load(object sender, EventArgs e)
        {
            LoadRecetas("");
            //LoadIngredientes("");

        }

        void LoadRecetas(String x)
        {
            ClsLogicaAddReceta Load = new ClsLogicaAddReceta();

            DgvRecetas.DataSource = Load.RecetaListaConNom(x);
            DgvRecetas.Columns[0].Visible = false;
            DgvRecetas.Columns[2].Visible = false;
            DgvRecetas.Columns[3].Visible = false;
        }
        void LoadIngredientes(String x)
        {
            CLsLogicaIngredienteReceta Load = new CLsLogicaIngredienteReceta();

            DgvIngredientes.DataSource = Load.ListarIngredientes(x);
            DgvIngredientes.Columns[0].Visible = false;
            DgvIngredientes.Columns[1].Visible = false;
            DgvIngredientes.Columns[2].Visible = false;
            DgvIngredientes.Columns[6].Visible = false;
            DgvIngredientes.Columns[7].Visible = false;

            DgvIngredientes.Columns[3].FillWeight = 2;
            DgvIngredientes.Columns[4].FillWeight = 0.5F;
            DgvIngredientes.Columns[5].FillWeight = 1;


        }

        void eliminarReceta()
        {
            ClsLogicaAddReceta receta = new ClsLogicaAddReceta();
            receta.eliminarReceta(idReceta);
            LblNombreReceta.Text = "Seleccione una receta";
            lblNumPorc.Text = "0";
            txtProcedimiento.Text = "";
            idReceta = -1;
            LoadIngredientes("-1");
            LoadRecetas("");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtBuscarReceta_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarReceta.Text == " ")
            {
                try
                {
                    DgvRecetas.Columns.Clear();
                }
                catch (Exception er)
                {


                }

            }
            else
            {
                LoadRecetas(TxtBuscarReceta.Text);
            }
        }

        private void lblNumPorc_Click(object sender, EventArgs e)
        {
            
          
        }

     

        private void TxtBuscarReceta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Space)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras, ingrese nuevamente el Nombre de la Receta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void DgvRecetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = DgvRecetas.SelectedRows[0].Cells[0].Value.ToString();
            idReceta = Convert.ToInt32(id);
            Convert.ToInt32(id);
            ClsLogicaAddReceta producto = new ClsLogicaAddReceta();
            DataTable DT = producto.RecetaLista(id);
            LblNombreReceta.Text = DT.Rows[0].Field<String>("nombre_receta");

            txtProcedimiento.Text= DT.Rows[0].Field<String>("procedimiento");

            lblNumPorc.Text = DT.Rows[0].Field<int>("num_porciones").ToString();

            LoadIngredientes(id);



        }

     

        private void lblPorciones_Click(object sender, EventArgs e)
        {

        }

        private void PanelReceta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarReceta();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmIngresarReceta ingr = new FrmIngresarReceta(idReceta, principal);
            ingr.Visible = true;
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for(int i=0; i<DgvIngredientes.RowCount; i++)
            {
                DgvIngredientes.Rows[i].Cells[4].Value = (Convert.ToDouble(DgvIngredientes.Rows[i].Cells[4].Value)) / Convert.ToDouble(lblNumPorc.Text) * Convert.ToDouble(txtCalcularPorciones.Text);

            }
        }

        private void txtCalcularPorciones_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros, ingrese nuevamente los digitos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
            principal.Controls.Add(new CduMenuPrincipal(principal));
            
        }
    }
}
