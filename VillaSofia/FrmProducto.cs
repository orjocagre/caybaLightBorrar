using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace VillaSofia
{
    public partial class FrmProducto : Form
    {

        VillaSofia VS;
        Boolean editar = false;
        int idEditar = 0;

        public FrmProducto(VillaSofia VS)
        {
            this.VS = VS;
            InitializeComponent();
            btnCancelar.Visible = false;
            comboClasificacion();
            cargarTabla();

        }

        Boolean validarNombre()
        {
            if (txtNombre.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        Boolean validarint(String a)
        {
            if (a != "")
            {
                try
                {
                    int b = Convert.ToInt32(a);
                    return true;
                }
                catch (FormatException e)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        Boolean validarPrecio()
        {
            if (txtPrecio.Text != "")
            {
                try
                {
                    double y = Convert.ToDouble(txtPrecio.Text);
                    return true;
                }
                catch (FormatException e)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        void insertarProducto(int orden)
        {
            int posi = dgvProducto.FirstDisplayedScrollingRowIndex;
            ClsLogicaProducto producto = new ClsLogicaProducto();
            int cocinaBarra;
            int reseve;
            if (rdbCocina.Checked)
            {
                cocinaBarra = 1;
            }
            else
            {
                cocinaBarra = 2;
            }
            if (chbRestaurante.Checked)
            {
                reseve = 1;
                if (chbEventos.Checked)
                {
                    reseve = 3;
                }
            }
            else if (chbEventos.Checked)
            {
                reseve = 2;
            }
            else
            {
                reseve = 4;
            }
            String mensaje = producto.insertarProducto(reseve, txtNombre.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(cmbTipoProducto.SelectedValue), cocinaBarra, orden);
            if (validarint(mensaje))
            {
                guardarSinonimos(Convert.ToInt32(mensaje));
                MessageBox.Show("Guardado");
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtSinonimos.Text = "";
            }
            else
            {
                MessageBox.Show(mensaje);
            }
            cargarTabla();
            dgvProducto.FirstDisplayedScrollingRowIndex = posi;

        }
        void subirBajarProducto(int updown)
        {
            ClsLogicaProducto producto = new ClsLogicaProducto();
            int id = Convert.ToInt32(dgvProducto.SelectedRows[0].Cells[0].Value);
            int scro = dgvProducto.FirstDisplayedScrollingRowIndex;
            int ord = dgvProducto.SelectedRows[0].Index;
            String msj = producto.subirBajarProducto(id, updown);

            if (msj != "")
            {
                MessageBox.Show(msj);
            }
            else
            {
                cargarTabla();
                dgvProducto.FirstDisplayedScrollingRowIndex = scro;
                if (updown == 1 && ord - 1 >= 0)
                {
                    dgvProducto.Rows[ord - 1].Selected = true;
                }
                else if (ord + 1 < dgvProducto.Rows.Count)
                {
                    dgvProducto.Rows[ord + 1].Selected = true;

                }

            }
        }
        void cargarTabla()
        {
            ClsLogicaProducto pro = new ClsLogicaProducto();
            dgvProducto.DataSource = pro.buscarProductoTabla(chbDeshabilitados.Checked);
            dgvProducto.Columns[0].Visible = false;
            dgvProducto.Columns[1].FillWeight = 5;
            dgvProducto.Columns[2].FillWeight = 2;
            dgvProducto.Columns[3].FillWeight = 2;
            dgvProducto.Columns[4].FillWeight = 2;
            dgvProducto.Columns[5].FillWeight = 2;


        }


        public void comboClasificacion()
        {
            ClsLogicaTipoProducto tipo = new ClsLogicaTipoProducto();
            cmbTipoProducto.DataSource = tipo.buscarProducto();
            cmbTipoProducto.DisplayMember = "descripcion";
            cmbTipoProducto.ValueMember = "idTipoProducto";
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cargarTabla();
            comboClasificacion();
        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            //FrmClasificacion clasi = new FrmClasificacion(this);
            //clasi.Show();
        }
        void guardarSinonimos(int idProducto)
        {
            ClsLogicaSinonimo sinonimo = new ClsLogicaSinonimo();
            sinonimo.eliminarSinonimos(idProducto);
            sinonimo.agregarSinonimoPrincipal(idProducto, txtNombre.Text);
            sinonimo.agregarSinonimo(idProducto,txtSinonimos.Text);
        }
        void desactivarEdicion()
        {
            gbAgregarEditar.CustomBorderColor = Color.FromArgb(213, 218, 223);
            gbAgregarEditar.ForeColor = Color.FromArgb(125, 137, 149);
            gbAgregarEditar.Text = "Agregar Producto";
            btnGuardar.FillColor = Color.FromArgb(94, 148, 255);
            btnGuardar.Text = "GUARDAR";
            btnCancelar.Visible = false;
            editar = false;
            txtSinonimos.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                if (validarNombre() && validarPrecio())
                {
                    editarProducto();
                    desactivarEdicion();
                }
            }
            else
            {
                if (validarNombre() && validarPrecio())
                {
                    insertarProducto(-1);
                    cargarTabla();
                    //dgvProducto.Rows[dgvProducto.Rows.Count - 1].Selected = true;

                    try
                    {
                        dgvProducto.FirstDisplayedScrollingRowIndex = dgvProducto.RowCount - 1;

                    }
                    catch (ArgumentOutOfRangeException) { }
                }
            }
        }
        void eliminarProducto(int id)
        {
            ClsLogicaProducto producto = new ClsLogicaProducto();

            String msj = producto.eliminarProducto(id);
            if (msj != "")
            {
                MessageBox.Show(msj);

                if (msj == "El producto ya fue usado\nEn lugar de eliminarse se deshabilitará")
                {
                    producto.cambiarVisibilidad(id);
                }
            }
            cargarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int num = dgvProducto.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (num > 0)
            {
                int orden = dgvProducto.SelectedRows[0].Index;

                if (orden == dgvProducto.RowCount - 1)
                {
                    orden -= 1;
                }

                eliminarProducto(Convert.ToInt32(dgvProducto.SelectedRows[0].Cells[0].Value));

                if (dgvProducto.RowCount > 0)
                {
                    dgvProducto.Rows[orden].Selected = true;
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int hayFilSel = dgvProducto.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (hayFilSel > 0)
            {
                if (chbDeshabilitados.Checked)
                {
                    ClsLogicaProducto producto = new ClsLogicaProducto();
                    producto.cambiarVisibilidad(Convert.ToInt32(dgvProducto.SelectedRows[0].Cells[0].Value));
                    cargarTabla();
                }
                else
                {
                    if(validarNombre() && validarPrecio())
                    {
                        int orden = dgvProducto.SelectedRows[0].Index;
                        insertarProducto(orden);
                        dgvProducto.Rows[orden].Selected = true;
                    }
                }
            }

            
        }

        void editarProducto()
        {
            int posi = dgvProducto.FirstDisplayedScrollingRowIndex;
            ClsLogicaProducto producto = new ClsLogicaProducto();
            int cocinaBarra, reseve;
            if (rdbCocina.Checked)
            {
                cocinaBarra = 1;
            }
            else
            {
                cocinaBarra = 2;
            }
            if (chbRestaurante.Checked)
            {
                reseve = 1;
                if (chbEventos.Checked)
                {
                    reseve = 3;
                }
            }
            else if (chbEventos.Checked)
            {
                reseve = 2;
            }
            else
            {
                reseve = 4;
            }
            String mensaje = producto.editarProducto(reseve, idEditar, txtNombre.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(cmbTipoProducto.SelectedValue), cocinaBarra);
            if (mensaje == "Producto Actualizado")
            {
                guardarSinonimos(idEditar);
                MessageBox.Show("Producto Actualizado");
                cargarTabla();
                dgvProducto.FirstDisplayedScrollingRowIndex = posi;
            }
            else
            {
                MessageBox.Show(mensaje);
            }


        }

        void llenarCampos()
        {
            gbAgregarEditar.CustomBorderColor = Color.FromArgb(255, 128, 0);
            gbAgregarEditar.ForeColor = Color.Black;
            gbAgregarEditar.Text = "Editar Producto";
            btnGuardar.FillColor = Color.FromArgb(255, 128, 0);
            btnGuardar.Text = "ACTUALIZAR";
            dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);

            //213, 218, 223 border
            //125, 137, 149 fore color
            // 94, 148, 255 fillcolor

            btnCancelar.Visible = true;

            String id = dgvProducto.SelectedRows[0].Cells[0].Value.ToString();
            idEditar = Convert.ToInt32(id);

            ClsLogicaProducto producto = new ClsLogicaProducto();
            DataTable DT = producto.buscarProducto(id);

            txtNombre.Text = DT.Rows[0].Field<String>("Nombre");
            txtPrecio.Text = DT.Rows[0].Field<double>("Precio").ToString();
            cmbTipoProducto.SelectedValue = DT.Rows[0].Field<int>("Clasificación");

            if (DT.Rows[0].Field<int>("Procedencia") == 1)
            {
                rdbCocina.Checked = true;
                rdbBarra.Checked = false;

            }
            else
            {
                rdbCocina.Checked = false;
                rdbBarra.Checked = true;
            }
            if (DT.Rows[0].Field<int>("Menu") == 1)
            {
                chbRestaurante.Checked = true;
                chbEventos.Checked = false;
            }
            else if (DT.Rows[0].Field<int>("Menu") == 2)
            {
                chbRestaurante.Checked = false;
                chbEventos.Checked = true;
            }
            else
            {
                chbRestaurante.Checked = true;
                chbEventos.Checked = true;
            }

            ClsLogicaSinonimo sinonimo = new ClsLogicaSinonimo();
            txtSinonimos.Text = sinonimo.buscarSinonimos(idEditar);
            gpSinonimos.Visible = true;
            gpSinonimos.Focus();

        }
        void moverProducto(int posFinal)
        {
            ClsLogicaProducto producto = new ClsLogicaProducto();

            String msj = producto.moverProducto(idEditar, posFinal);

            if (msj != "")
            {
                MessageBox.Show(msj);
            }
            desactivarEdicion();
            cargarTabla();
            dgvProducto.Rows[posFinal].Selected = true;
        }

        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!chbDeshabilitados.Checked)
            {
                if (editar)
                {
                    moverProducto(dgvProducto.SelectedRows[0].Index);
                }
                else
                {
                    editar = true;
                    llenarCampos();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarEdicion();
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            int hayFilSel = dgvProducto.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (hayFilSel > 0)
            {
                subirBajarProducto(1);
            }
        }
       
        private void btnAbajo_Click(object sender, EventArgs e)
        {
            int hayFilSel = dgvProducto.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (hayFilSel > 0)
            {
                subirBajarProducto(2);
            }
        }

        private void btnSinonimos_Click(object sender, EventArgs e)
        {
            gpSinonimos.Visible = true;
            txtSinonimos.Focus();
        }

        private void gpSinonimos_Leave(object sender, EventArgs e)
        {
            gpSinonimos.Visible = false;
        }

        private void chbDeshabilitados_CheckedChanged(object sender, EventArgs e)
        {
            cargarTabla();
            if (chbDeshabilitados.Checked)
            {
                gbAgregarEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnArriba.Enabled = false;
                btnAbajo.Enabled = false;
            }
            else
            {
                gbAgregarEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnArriba.Enabled = true;
                btnAbajo.Enabled = true;
            }
        }
    }
}
