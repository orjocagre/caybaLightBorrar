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
    public partial class FrmClasificacion : Form
    {
        FrmAgregarProducto producto;
        Boolean editar = false;
        int idEditar;

        public FrmClasificacion(FrmAgregarProducto producto)
        {
            this.producto = producto;
            InitializeComponent();
        }

        Boolean validarClasificacion()
        {
            if (txtClasificacion.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void cargarTablaClasi()
        {
            ClsLogicaTipoProducto tipoPro = new ClsLogicaTipoProducto();
            dgvTipoProducto.DataSource = tipoPro.buscarProducto();
            dgvTipoProducto.Columns[0].Visible = false;
            dgvTipoProducto.Columns[2].Visible = false;
            producto.comboClasificacion();
        }
        void guardarClasificacion(int orden)
        {
            ClsLogicaTipoProducto tipoProd = new ClsLogicaTipoProducto();
            String mensaje = tipoProd.insertarTipoProducto(txtClasificacion.Text, orden);
            MessageBox.Show(mensaje);
        }
        void editarClasificacion()
        {
            ClsLogicaTipoProducto tipoProd = new ClsLogicaTipoProducto();
            String mensaje = tipoProd.editarTipoProducto(idEditar, txtClasificacion.Text);
            MessageBox.Show(mensaje);
        }

        void subirBajarProducto(int updown)
        {
            ClsLogicaTipoProducto tipoProducto = new ClsLogicaTipoProducto();
            int id = Convert.ToInt32(dgvTipoProducto.SelectedRows[0].Cells[0].Value);
            int scro = dgvTipoProducto.FirstDisplayedScrollingRowIndex;
            int ord = dgvTipoProducto.SelectedRows[0].Index;
            String msj = tipoProducto.subirBajarTipoProducto(id, updown);

            if (msj != "")
            {
                MessageBox.Show(msj);
            }
            else
            {
                cargarTablaClasi();
                dgvTipoProducto.FirstDisplayedScrollingRowIndex = scro;
                if (updown == 1 && ord - 1 >= 0)
                {
                    dgvTipoProducto.Rows[ord - 1].Selected = true;
                }
                else if (ord + 1 < dgvTipoProducto.Rows.Count)
                {
                    dgvTipoProducto.Rows[ord + 1].Selected = true;

                }

            }

        }

        private void FrmClasificacion_Load(object sender, EventArgs e)
        {
            cargarTablaClasi();
            btnCancelar.Visible = false;
        }
        void desactivarEdicion()
        {
            btnCancelar.Visible = false;
            btnGuardar.FillColor = Color.FromArgb(94, 148, 255);
            btnGuardar.Text = "GUARDAR";
            cargarTablaClasi();
            editar = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                if (validarClasificacion())
                {
                    editarClasificacion();
                    desactivarEdicion();
                }
            }
            else
            {
                if (validarClasificacion())
                {
                    guardarClasificacion(-1);
                    cargarTablaClasi();
                }
            }
        }

        void llenarCampos()
        {
            btnGuardar.FillColor = Color.FromArgb(255, 128, 0);
            btnGuardar.Text = "ACTUALIZAR";
            dgvTipoProducto.Rows[dgvTipoProducto.SelectedRows[0].Index].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dgvTipoProducto.Rows[dgvTipoProducto.SelectedRows[0].Index].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);


            editar = true;
            btnCancelar.Visible = true;

            String id = dgvTipoProducto.SelectedRows[0].Cells[0].Value.ToString();
            idEditar = Convert.ToInt32(id);

            txtClasificacion.Text = dgvTipoProducto.SelectedRows[0].Cells[1].Value.ToString();


        }
        void moverTipoProducto(int posFinal)
        {
            ClsLogicaTipoProducto tipoProducto = new ClsLogicaTipoProducto();

            String msj = tipoProducto.moverTipoProducto(idEditar, posFinal);

            if (msj != "")
            {
                MessageBox.Show(msj);
            }
            desactivarEdicion();

        }

        private void dgvTipoProducto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (editar)
            {
                moverTipoProducto(dgvTipoProducto.SelectedRows[0].Index);

            }
            else
            {
                llenarCampos();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if(dgvTipoProducto.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 && validarClasificacion())
            {
                guardarClasificacion(dgvTipoProducto.SelectedRows[0].Index);
                cargarTablaClasi();
            }

        }

        void eliminarClasificacion()
        {
            
            ClsLogicaTipoProducto tipoProducto = new ClsLogicaTipoProducto();
            String msj = tipoProducto.eliminarTipoProducto(Convert.ToInt32(dgvTipoProducto.SelectedRows[0].Cells[0].Value));

            if (msj != "")
            {
                MessageBox.Show(msj);
            }
            else
            {
                cargarTablaClasi();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipoProducto.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                eliminarClasificacion();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarEdicion();

        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            int hayfilsel = dgvTipoProducto.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (hayfilsel > 0)
            {
                subirBajarProducto(1);

            }

        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            int hayfilsel = dgvTipoProducto.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (hayfilsel > 0)
            {
                subirBajarProducto(2);

            }

        }
    }
}
