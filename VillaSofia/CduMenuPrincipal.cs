using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Logica;

namespace VillaSofia
{
    public partial class CduMenuPrincipal : UserControl
    {
        VillaSofia vs;
        public CduMenuPrincipal(VillaSofia vs)
        {
            this.vs = vs;
            InitializeComponent();
            llenarDgvConjuntos();
            this.Dock = DockStyle.Fill;
        }


        void llenarDgvConjuntos()
        {
            ClsLogicaConjunto conjunto = new ClsLogicaConjunto();
            DataTable DT = conjunto.listarConjuntos();

            for(int i=0; i<DT.Rows.Count; i++)
            {
                dgvConjunto.Rows.Add();
                dgvConjunto.Rows[i].Cells[0].Value = DT.Rows[i].Field<int>(0);
                dgvConjunto.Rows[i].Cells[1].Value = DT.Rows[i].Field<DateTime>(1).ToString("dd-MM-yyy");
                dgvConjunto.Rows[i].Cells[2].Value = DT.Rows[i].Field<int>(2) == 0 ? "cerrado" : "abierto";
            }
        }
       

        private void btnCaja_Click(object sender, EventArgs e)
        {
            vs.Controls.Remove(this);
            vs.Controls.Add(new CduMenuConjunto(vs));
            this.Dispose();
        }

        
        private void btnProductos_Click(object sender, EventArgs e)
        {
            vs.Controls.Remove(this);
            vs.Controls.Add(new CduProducto(vs));
            this.Dispose();
        }

        private void dgvConjunto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //vs.Controls.Remove(this);
            //vs.Controls.Add(new CduFacturacion(vs, Convert.ToInt32(dgvConjunto.SelectedRows[0].Cells[0].Value)));
            //this.Dispose();

            vs.Controls.Remove(this);
            vs.Controls.Add(new CduMenuConjunto(vs, Convert.ToInt32(dgvConjunto.SelectedRows[0].Cells[0].Value)));
            this.Dispose();
        }
    }
}
