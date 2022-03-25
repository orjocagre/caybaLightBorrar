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
    public partial class FrmMovimientosCaja : Form
    {
        int idConjunto;

        public FrmMovimientosCaja(int idConjunto)
        {
            this.idConjunto = idConjunto;
            InitializeComponent();
            llenarDgvMovimientos();
        }

        void llenarDgvMovimientos()
        {
            ClsLogicaMovimiento movimiento = new ClsLogicaMovimiento();
            DataTable DT = movimiento.listarMovimientos(idConjunto);
            dgvCaja.Rows.Clear();
            for(int i=0; i<DT.Rows.Count; i++)
            {
                dgvCaja.Rows.Add();

                dgvCaja.Rows[i].Cells[0].Value = DT.Rows[i].Field<int>("ID");

                double monto = DT.Rows[i].Field<double>("MONTO");
                if (DT.Rows[i].Field<int>("ENTRADA") == 0)
                {
                    monto = (monto * -1);
                    dgvCaja.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                    dgvCaja.Rows[i].Cells[1].Style.SelectionForeColor = Color.Red;
                }
                dgvCaja.Rows[i].Cells[1].Value = monto;

                dgvCaja.Rows[i].Cells[2].Value = DT.Rows[i].Field<String>("DESCRIPCIÓN");

                String hora = DT.Rows[i].Field<DateTime>("HORA").ToString("hh:mm tt");
                dgvCaja.Rows[i].Cells[3].Value = hora;
            }

        }

        void eliminarMovimiento()
        {
            ClsLogicaMovimiento movimiento = new ClsLogicaMovimiento();
            movimiento.eliminarMovimientos(Convert.ToInt32(dgvCaja.SelectedRows[0].Cells[0].Value));
            llenarDgvMovimientos();
        }
        void agregarMovimiento(int entrada)
        {
            ClsLogicaMovimiento movimiento = new ClsLogicaMovimiento();
            String msj = movimiento.agregarMovimiento(idConjunto, Convert.ToDouble(txtMonto.Text), entrada, txtDescripcion.Text, DateTime.Now);
            MessageBox.Show(msj);
            llenarDgvMovimientos();
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {
            agregarMovimiento(1);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            agregarMovimiento(0);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvCaja.RowCount > 0)
            {
                eliminarMovimiento();
            }
        }
    }
}
