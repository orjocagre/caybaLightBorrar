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
    public partial class FrmRegistroTrabajador : Form
    {
        VillaSofia VS;
        Boolean editar;
        int idTrabajador;

        public FrmRegistroTrabajador(VillaSofia VS)
        {
            this.VS = VS;
            editar = false;
            this.idTrabajador = -1;
            InitializeComponent();
        }

        private void FrmRegistroTrabajador_Load(object sender, EventArgs e)
        {

            LoadTrabajadores("");

            comboTipoTrabajador();
        }
        void LoadTrabajadores(String x)
        {
            ClsLogicaRegistroTrabajador Load = new ClsLogicaRegistroTrabajador();

            dagTrabajadores.DataSource = Load.ListarTrabajadores(x);

            dagTrabajadores.Columns[6].Visible = false;


        }

        Boolean validarTexbox()
        {

            if (txtNombres.Text != "" && txtApellidos.Text != "" && txtCedula.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        Boolean ValidarTexboxNumerales()
        {
            if (txtTelefono.Text != "" && TxtSalario.Text != "" )
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        Boolean validarCedula()
        {

            if (txtCedula.Text.Length == 16)
            {
                for (int i = 0; i < 16; i++)
                {
                    char c = txtCedula.Text.ToCharArray()[i];
                    if (i == 15)
                    {
                        if (!char.IsLetter(c))
                        {
                            return false;
                        }
                    }
                    else if (i == 3 || i == 10)
                    {
                        if (c != '-')
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (!char.IsNumber(c))
                        {
                            return false;
                        }
                    }
                }

                if (Convert.ToInt32(txtCedula.Text.Substring(4,2)) > 0 && Convert.ToInt32(txtCedula.Text.Substring(4, 2)) <= 31 && Convert.ToInt32(txtCedula.Text.Substring(6, 2)) > 0 && Convert.ToInt32(txtCedula.Text.Substring(6, 2)) <= 12 && Convert.ToInt32(txtCedula.Text.Substring(6, 2)) > 0 && Convert.ToInt32(txtCedula.Text.Substring(6, 2)) <= 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        string IngresarPersona()
        {
            String resp;
            ClsLogicaRegistroTrabajador AddTrabajador = new ClsLogicaRegistroTrabajador();
            resp = AddTrabajador.ingresarDatosTrabajador(txtCedula.Text, txtNombres.Text, txtApellidos.Text);

           

            return resp;

         }
        int IngresarTelefono()
        {
            int resp;
            ClsLogicaRegistroTrabajador AddTrabajador = new ClsLogicaRegistroTrabajador();
            resp = AddTrabajador.ingresarTelefonoTrabajador(Convert.ToInt32(txtTelefono.Text));



            return resp;

        }



        public void comboTipoTrabajador()
        {
            ClsLogicaTipoTrabajador tipo = new ClsLogicaTipoTrabajador();
            cmbxCargo.DataSource = tipo.ListarTrabajadores();
            cmbxCargo.DisplayMember = "descripcion";
            cmbxCargo.ValueMember = "id_tipo_trabajador";

        }


        private void btnGuardarTrabajador_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                if (validarTexbox() && ValidarTexboxNumerales() && validarCedula())
                {
                    ClsLogicaRegistroTrabajador regtra = new ClsLogicaRegistroTrabajador();
                    String msj = regtra.editarTrabajador(idTrabajador, txtCedula.Text, txtNombres.Text, txtApellidos.Text, Convert.ToInt32(cmbxCargo.SelectedValue), Convert.ToDouble(TxtSalario.Text), Convert.ToInt32(txtTelefono.Text));

                    MessageBox.Show(msj);

                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtCedula.Text = "";
                    TxtSalario.Text = "";
                    txtTelefono.Text = "";
                    editar = false;
                    BtnEditar.FillColor = Color.Teal;

                    LoadTrabajadores("");

                }
                else
                {
                    MessageBox.Show("No supero la validaciòn");
                }
            }
            else
            {
                if (validarTexbox() && ValidarTexboxNumerales() && validarCedula())
                {



                    int x = Convert.ToInt32(IngresarPersona());
                    int y = IngresarTelefono();
                    ClsLogicaRegistroTrabajador addpersonaTelefono = new ClsLogicaRegistroTrabajador();
                    ClsLogicaRegistroTrabajador addTrabajador = new ClsLogicaRegistroTrabajador();

                    addpersonaTelefono.ingresarPersonaTelefono(x, y);
                    string mx = addTrabajador.ingresarTrabajador(x, Convert.ToInt32(cmbxCargo.SelectedValue), Convert.ToDouble(TxtSalario.Text));
                    LoadTrabajadores("");

                    MessageBox.Show(mx);
                }
                else
                {
                    MessageBox.Show("No supero la validaciòn");
                }
            }
        }
        //validación de texbox numerales 
       private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar))&&(e.KeyChar!=(char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros, ingrese nuevamente los digitos","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
       }

        private void TxtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros, ingrese nuevamente los digitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //validación de texbox letras
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Space)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras, ingrese nuevamente el Nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }

        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Space)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras, ingrese nuevamente los apellidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void btnAddTipoTrabajador_Click(object sender, EventArgs e)
        {
            FrmTipoTrabajador TipoT = new FrmTipoTrabajador();
            TipoT.Show();
            TipoT.BringToFront();
        }


        void eliminarTrabajador(int idTrabajador)
        {
            ClsLogicaRegistroTrabajador eliminarTrabajador = new ClsLogicaRegistroTrabajador();

            String msj = eliminarTrabajador.EliminarTrabajador(idTrabajador);


        }
        private void BtnEliminarTrabajador_Click(object sender, EventArgs e)
        {
            String idT = dagTrabajadores.SelectedRows[0].Cells[6].Value.ToString();
            int IdT = Convert.ToInt32(idT);
            //ClsLogicaAddReceta ingrediente = new ClsLogicaAddReceta();
            eliminarTrabajador(IdT);

            LoadTrabajadores("");

        }

        private void dagTrabajadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtCedula.Text = "";
                TxtSalario.Text = "";
                txtTelefono.Text = "";
                editar = false;
                BtnEditar.FillColor = Color.Teal;


            }
            else
            {
                txtNombres.Text = dagTrabajadores.SelectedRows[0].Cells[4].Value.ToString();
                txtApellidos.Text = dagTrabajadores.SelectedRows[0].Cells[5].Value.ToString();
                txtCedula.Text = dagTrabajadores.SelectedRows[0].Cells[3].Value.ToString();
                TxtSalario.Text = dagTrabajadores.SelectedRows[0].Cells[0].Value.ToString();
                txtTelefono.Text = dagTrabajadores.SelectedRows[0].Cells[2].Value.ToString();
                editar = true;
                idTrabajador = Convert.ToInt32(dagTrabajadores.SelectedRows[0].Cells[6].Value);
                BtnEditar.FillColor = Color.Orange;
            }
        }
    }
}
