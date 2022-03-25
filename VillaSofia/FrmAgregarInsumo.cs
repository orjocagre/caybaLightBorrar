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
    public partial class FrmAgregarInsumo : Form
    {
        CduProducto prod;
        Boolean invocadoxFrmInsPro;
        FrmInsumoProducto inspro;
        public FrmAgregarInsumo(CduProducto prod)
        {
            invocadoxFrmInsPro = false;
            this.prod = prod;
            InitializeComponent();
            cmbPesoLlena.SelectedIndex = 0;
            cmbPesoVacia.SelectedIndex = 0;
            cmbTamano.SelectedIndex = 0;

        }
        public FrmAgregarInsumo(CduProducto prod, FrmInsumoProducto inspro)
        {
            invocadoxFrmInsPro = true;
            this.inspro = inspro;
            this.prod = prod;
            InitializeComponent();
        }
        void guardarInsumo()
        {
            ClsLogicaInsumo insumo = new ClsLogicaInsumo();

            if (rbtUnidad.Checked)
            {
                insumo.agregarInsumo(txtNombre.Text, -1, 1, 0, 0, 0);
            }
            else
            {
                double pll, pv, tam;
                pll = cmbPesoLlena.SelectedItem.ToString() == "gramos" ? Convert.ToDouble(txtPesoLlena.Text) : (cmbPesoLlena.SelectedItem.ToString() == "kilos" ? Convert.ToDouble(txtPesoLlena.Text) * 1000 : Convert.ToDouble(txtPesoLlena.Text) * 453.592);
                pv = cmbPesoVacia.SelectedItem.ToString() == "gramos" ? Convert.ToDouble(txtPesoVacia.Text) : (cmbPesoVacia.SelectedItem.ToString() == "kilos" ? Convert.ToDouble(txtPesoVacia.Text) * 1000 : Convert.ToDouble(txtPesoVacia.Text) * 453.592);
                tam = cmbTamano.SelectedItem.ToString() == "mililitros" ? Convert.ToDouble(txtTamano.Text) : Convert.ToDouble(txtTamano.Text) * 1000;
                insumo.agregarInsumo(txtNombre.Text, -1, 2, pll, pv, tam);
            }


        }




        private void rbtUnidad_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtMililitro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMililitro.Checked)
            {
                lblPesollena.Visible = txtPesoLlena.Visible = cmbPesoLlena.Visible = true;
                tempo.Start();
            }
            else
            {
                lblPesollena.Visible = txtPesoLlena.Visible = cmbPesoLlena.Visible = false;
                tempo.Start();
            }
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            
            if (rbtMililitro.Checked)
            {
                this.Size = new Size(this.Size.Width, this.Size.Height + 20);
            }
            else
            {
                this.Size = new Size(this.Size.Width, this.Size.Height - 20);

            }
            if (this.MaximumSize == this.Size || this.MinimumSize == this.Size)
            {
                tempo.Stop();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarInsumo();
            prod.cargarTablaInsumos();
            if (invocadoxFrmInsPro) inspro.cargarTablaInsumos();
            this.Close();
        }
    }
}
