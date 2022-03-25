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
    public partial class FrmIngresarReceta : Form
    {
        VillaSofia VS;
        int idreceta;
        Boolean edicion;

        public FrmIngresarReceta(VillaSofia VS)
        {
            edicion = false;
            this.VS = VS;
            InitializeComponent();
        }

        public FrmIngresarReceta(int idreceta, VillaSofia VS)
        {
            this.VS = VS;
            this.idreceta = idreceta;
            edicion = true;
            InitializeComponent();
            llenarCampos();
        }

        void llenarCampos()
        {
            ClsLogicaAddReceta receta = new ClsLogicaAddReceta();
            DataTable DT = receta.RecetaLista(idreceta.ToString());

            txtNombreReceta.Text = DT.Rows[0].Field<String>("nombre_receta");
            txtPorciones.Text = DT.Rows[0].Field<int>("num_porciones").ToString();
            txtProcedimiento.Text = DT.Rows[0].Field<String>("procedimiento");

            LoadIngredientes(idreceta.ToString());
        }

        //MOTRAR DATOS EN EL FORMULARIO
        private void FrmIngresarReceta_Load(object sender, EventArgs e)
        {
            comboUM();
            //NO MOSTRAR SIEMPRE
           // LoadIngredientes("");
        }
        //MOSTRAR INGREDIENTES
        void LoadIngredientes(String x)
        {
           CLsLogicaIngredienteReceta Load = new CLsLogicaIngredienteReceta();

            dgvIngredientes.DataSource = Load.ListarIngredientes(x);
            dgvIngredientes.Columns[0].Visible = false;
            dgvIngredientes.Columns[1].Visible = false;
            dgvIngredientes.Columns[2].Visible = false;
            dgvIngredientes.Columns[2].Visible = false;
            dgvIngredientes.Columns[6].Visible = false;
            dgvIngredientes.Columns[7].Visible = false;
        }
        //VALIDAR TEXBOX VACIOS
        Boolean validarTexboxReceta()
        {

            if (txtNombreReceta.Text != "" && txtPorciones.Text != "" && txtProcedimiento.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        Boolean validarTexboxIngredientes()
        {

            if (/*TxtCantidades.Text != "" && */txtNombreIngrediente.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //METODO PARA INGRESAR DATOS
        void IngresarReceta()
        {
            string resp;
            CLsLogicaIngredienteReceta Receta = new CLsLogicaIngredienteReceta();
            resp = Receta.ingresarDatosReceta(txtNombreReceta.Text,Convert.ToInt32( txtPorciones.Text), txtProcedimiento.Text);
            idreceta = Convert.ToInt32(resp);
        }

        void editarReceta()
        {
            string resp;
            ClsLogicaAddReceta Receta = new ClsLogicaAddReceta();
            Receta.editarReceta(idreceta,txtNombreReceta.Text, Convert.ToInt32(txtPorciones.Text), txtProcedimiento.Text);
        }

        //METODO PARA INGRESAR DATOS
        string IngresarIngrediente()
        {
            string resp;
            CLsLogicaIngredienteReceta AddIngrediente = new CLsLogicaIngredienteReceta();
            resp = AddIngrediente.ingresarDatosIngrediente( txtNombreIngrediente.Text);

            return resp;

        }

     //MOSTRAR UNIDADES DE MEDIDA DISPONIBLES
        public void comboUM()
        {
            ClsLogicaUM UM = new ClsLogicaUM();
            cmbUM.DataSource = UM.UM();
            cmbUM.ValueMember = "ID";
            cmbUM.DisplayMember = "DESCRIPCION";

        }
        //GUARDAR UM
       /*string IngresarUM()
        {
            string resp;
          
            resp = Convert.ToString(cmbUM.SelectedIndex);

            return resp;

        }*/

        
        //AGREGAR MAS UNIDADES DE MEDIDA
        private void BtnAgregarMasUnidades_Click(object sender, EventArgs e)
        {
           

        }



        private void btnguardarIgredientes_Click(object sender, EventArgs e)
        {
           

            if (validarTexboxIngredientes() && validarTexboxReceta())
            {
                string msj;
                 int y = Convert.ToInt32(IngresarIngrediente());
                 int x = idreceta;
                this.idreceta = x;

                //int p= Convert.ToInt32(IngresarUM());
                 CLsLogicaIngredienteReceta addRECETAinGRE = new CLsLogicaIngredienteReceta();
                  msj = addRECETAinGRE.AddIngredienteR(y, x,Convert.ToDouble( TxtCantidades.Text),Convert.ToInt32( cmbUM.SelectedValue));
                
                MessageBox.Show(msj);
                LoadIngredientes(x.ToString());
            }
            else
            {
                MessageBox.Show("No supero la validaciòn");
            }
        }
        //Validacion de letras
        private void txtNombreIngrediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Space)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras, ingrese nuevamente el Nombre el ingrediente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }
        //Validacion de numeros
        private void TxtCantidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros, ingrese nuevamente los digitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //Validacion de numeros
        private void txtPorciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros, ingrese nuevamente los digitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //Validacion de letras
        private void txtNombreReceta_KeyPress(object sender, KeyPressEventArgs e)
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
        void eliminarIngrediente(int idIng, int idReceta)
        {
            CLsLogicaIngredienteReceta eliminarIngrediente = new CLsLogicaIngredienteReceta();

            String msj = eliminarIngrediente.EliminarRecetaIngrediente(idIng, idReceta);

            
        }

        private void dgvIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

           
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            String iding = dgvIngredientes.SelectedRows[0].Cells[7].Value.ToString();
            int ingreId = Convert.ToInt32( iding);
            ClsLogicaAddReceta ingrediente = new ClsLogicaAddReceta();
            // DataTable DT = ingrediente.RecetaLista(iding);


            eliminarIngrediente(idreceta, ingreId);
          

            LoadIngredientes(idreceta.ToString());


        }

        private void GbxReceta_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarMas_Click(object sender, EventArgs e)
        {
            FrmUM receta = new FrmUM(this);
            receta.Show();
            receta.BringToFront();

           
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(edicion)
            {
                
                editarReceta();
            }
            else
            {
                IngresarReceta();
                edicion = true;
            }
            txtProcedimiento.Enabled = false;
            txtNombreReceta.Enabled = false;
            txtPorciones.Enabled = false;
            txtNombreIngrediente.Focus();
            btnSiguiente.Enabled = false;
        }

        private void btnMostrarRecetas_Click(object sender, EventArgs e)
        {
            /*this.Close();
            CduMostrarReceta rec = new CduMostrarReceta(VS);
            VS.Controls.Add(rec);
            rec.BringToFront();*/

        }
    }
}






