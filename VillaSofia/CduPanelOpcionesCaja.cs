using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillaSofia
{
    public partial class CduPanelOpcionesCaja : UserControl
    {
        CduFacturacion fact;
        public CduPanelOpcionesCaja(CduFacturacion fact)
        {
            this.fact = fact;
            InitializeComponent();
        }

        private void btnInventarioInicial_Click(object sender, EventArgs e)
        {
            //FrmInventario inventario = new FrmInventario(1,fact);
            //inventario.Visible = true;
            //this.SendToBack();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //FrmInventario inventario = new FrmInventario(0,fact);
            //inventario.Visible = true;
            //this.SendToBack();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //FrmMovimientosCaja movimientos = new FrmMovimientosCaja(fact.idConjunto);
            //movimientos.Visible = true;
            //this.SendToBack();
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            //fact.cerrarConjunto();
            //FrmCierreCaja cierre = new FrmCierreCaja(fact.idConjunto);
            //cierre.Visible = true;
            //this.SendToBack();
        }
    }
}
