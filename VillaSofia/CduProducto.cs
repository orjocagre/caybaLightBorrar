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
    public partial class CduProducto : UserControl
    {

        VillaSofia VS;
        public Boolean editar = false;
        int idEditar = 0;

        public CduProducto(VillaSofia VS)
        {
            this.VS = VS;
            InitializeComponent();
            cargarTabla();
            cargarTablaInsumos();
            this.Dock = DockStyle.Fill;

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
        public void cargarTabla()
        {
            ClsLogicaProducto pro = new ClsLogicaProducto();
            dgvProducto.DataSource = pro.buscarProductoTabla(chbDeshabilitados.Checked);
            dgvProducto.Columns[0].Visible = false;
            dgvProducto.Columns[4].Visible = false;
            dgvProducto.Columns[5].Visible = false;
            dgvProducto.Columns[1].FillWeight = 5;
            dgvProducto.Columns[2].FillWeight = 2;
            dgvProducto.Columns[3].FillWeight = 2;
            dgvProducto.Columns[4].FillWeight = 2;
            dgvProducto.Columns[5].FillWeight = 2;


        }

        public void cargarTablaInsumos()
        {
            ClsLogicaInsumo ins = new ClsLogicaInsumo();
            dgvInsumos.DataSource = ins.listarInsumos();
            dgvInsumos.Columns[0].Visible = false;
            dgvInsumos.Columns[1].FillWeight = 2.5F;
            dgvInsumos.Columns[2].FillWeight = 1;


        }







        public void desactivarEdicion()
        {
            editar = false;
            
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

             

        void llenarCampos()
        {
            
            dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);

            String id = dgvProducto.SelectedRows[0].Cells[0].Value.ToString();
            idEditar = Convert.ToInt32(id);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pos = dgvProducto.FirstDisplayedScrollingRowIndex;
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
            dgvProducto.FirstDisplayedScrollingRowIndex = pos;

        }



        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!chbDeshabilitados.Checked)
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

        private void chbDeshabilitados_CheckedChanged(object sender, EventArgs e)
        {
            cargarTabla();
            if (chbDeshabilitados.Checked)
            {
                btnAgregarProducto.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnArriba.Enabled = false;
                btnAbajo.Enabled = false;
            }
            else
            {
                btnAgregarProducto.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnArriba.Enabled = true;
                btnAbajo.Enabled = true;
            }
        }

        
        
       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 0);
            //dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);

            String id = dgvProducto.SelectedRows[0].Cells[0].Value.ToString();
            idEditar = Convert.ToInt32(id);

            FrmAgregarProducto ap = new FrmAgregarProducto(this, idEditar);
            ap.Visible = true;

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            VS.Controls.Remove(this);
            this.Dispose();
            VS.Controls.Add(new CduMenuPrincipal(VS));
        }

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            FrmAgregarProducto ap = new FrmAgregarProducto(this);
            ap.Visible = true;
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            FrmAgregarInsumo insumo = new FrmAgregarInsumo(this);
            insumo.Visible = true;
        }
    }
}
