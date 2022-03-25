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
    public partial class FrmInsumoProducto : Form
    {
        CduProducto prod;
        int idProducto;

        public FrmInsumoProducto(CduProducto prod, int idProducto, String nomProducto)
        {
            this.prod = prod;
            this.idProducto = idProducto;
            InitializeComponent();
            lblProducto.Text = nomProducto;
            cargarTablaInsumos();
        }



        public void cargarTablaInsumos()
        {
            ClsLogicaInsumo ins = new ClsLogicaInsumo();
            dgvInsumos.DataSource = ins.listarInsumos();
            dgvInsumos.Columns[0].Visible = false;
            dgvInsumos.Columns[1].FillWeight = 2.5F;
            dgvInsumos.Columns[2].FillWeight = 1;


        }

        void agregarProductosInsumo()
        {
            ClsLogicaProducto producto = new ClsLogicaProducto();

            for(int i=0; i<dgvProducto.RowCount; i++)
            {
                double cant = Convert.ToDouble(dgvProducto.Rows[i].Cells[1].Value);
                String um = dgvProducto.Rows[i].Cells[2].Value.ToString();

                cant = um == "shot" ? cant * 29.5735 : (um == "lt" ? cant * 1000 : cant);

                MessageBox.Show(producto.insertarProductoInsumo(idProducto, Convert.ToInt32(dgvProducto.Rows[i].Cells[3].Value), cant));

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvProducto.Rows.Add();
            dgvProducto.Rows[dgvProducto.Rows.Count - 1].Cells[0].Value = dgvInsumos.SelectedRows[0].Cells[1].Value;
            dgvProducto.Rows[dgvProducto.Rows.Count - 1].Cells[3].Value = dgvInsumos.SelectedRows[0].Cells[0].Value;





            if (dgvInsumos.SelectedRows[0].Cells[2].Value.ToString() == "unidad")
            {
                dgvProducto.Rows[dgvProducto.Rows.Count - 1].Cells[2].ReadOnly = true;
                dgvProducto.Rows[dgvProducto.Rows.Count - 1].Cells[2].Value = "unidad";
            }
            else
            {
                DataGridViewComboBoxCell celda = new DataGridViewComboBoxCell();
                celda.Items.Add("shot");
                celda.Items.Add("ml");
                celda.Items.Add("lt");
                celda.Value = "shot";
                dgvProducto.Rows[dgvProducto.Rows.Count - 1].Cells[2] = celda;
            }

            


            dgvProducto.CurrentCell = dgvProducto.Rows[dgvProducto.Rows.Count - 1].Cells[1];
            dgvProducto.BeginEdit(true);

            

        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            FrmAgregarInsumo insumo = new FrmAgregarInsumo(prod, this);
            insumo.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregarProductosInsumo();
            this.Close();
        }
    }
}
