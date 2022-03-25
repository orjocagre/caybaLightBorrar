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
    public partial class FrmCancelarFactura : Form
    {
        int idFactura;
        double total;
        CduFacturacion fact;
        public FrmCancelarFactura(double total, CduFacturacion fact, int idFactura)
        {
            this.idFactura = idFactura;
            this.total = total;
            this.fact = fact;
            InitializeComponent();
            
        }

        private void FrmCancelarFactura_Load(object sender, EventArgs e)
        {

        }

        private void chbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEfectivo.Checked)
            {
                if(txtEfectivoCordobas.Text == "" && txtEfectivoDolares.Text == "")
                {
                    txtEfectivoCordobas.Text = total.ToString("#,#,00");
                }
            }
        }

        private void chbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTarjeta.Checked)
            {
                if(txtTarjeta.Text == "")
                {
                    txtTarjeta.Text = total.ToString("#,#,00");
                }
            }
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            txtTarjeta.Text = txtTarjeta.Text == "" ? "0" : txtTarjeta.Text;
            txtEfectivoCordobas.Text = txtEfectivoCordobas.Text == "" ? "0" : txtEfectivoCordobas.Text;
            txtEfectivoDolares.Text = txtEfectivoDolares.Text == "" ? "0" : txtEfectivoDolares.Text;

            ClsLogicaFactura factura = new ClsLogicaFactura();
            factura.agregarPagoFactura(idFactura, Convert.ToDouble(txtEfectivoCordobas.Text) + ((Convert.ToDouble(txtEfectivoDolares.Text) * 35)), Convert.ToDouble(txtTarjeta.Text));

            double vuelto = Convert.ToDouble(txtTarjeta.Text) + Convert.ToDouble(txtEfectivoCordobas.Text) + Convert.ToDouble(txtEfectivoDolares.Text) * 35 - total;

            factura.agregarPagoFactura(idFactura, (Convert.ToDouble(txtEfectivoCordobas.Text) + ((Convert.ToDouble(txtEfectivoDolares.Text) * 35))) - vuelto, Convert.ToDouble(txtTarjeta.Text));


            if (vuelto >= 0)
            {
                MessageBox.Show("Vuelto: " + vuelto);
                this.Close();
                fact.cancelarFactura();

            }
            else if (vuelto < 0)
            {
                MessageBox.Show("Faltan: " + (vuelto * (-1)));


            }


        }

        private void txtEfectivoCordobas_TextChanged(object sender, EventArgs e)
        {
            if (txtEfectivoDolares.Text != "" || txtEfectivoCordobas.Text != "")
            {
                chbEfectivo.Checked = true;
            }
            else
            {
                chbEfectivo.Checked = false;
            }
        }

        private void txtEfectivoDolares_TextChanged(object sender, EventArgs e)
        {
            if (txtEfectivoDolares.Text != "" || txtEfectivoCordobas.Text != "")
            {
                chbEfectivo.Checked = true;
            }
            else
            {
                chbEfectivo.Checked = false;
            }
        }

        private void txtTarjeta_TextChanged(object sender, EventArgs e)
        {
            if (txtTarjeta.Text != "")
            {
                chbTarjeta.Checked = true;
            }
            else
            {
                chbTarjeta.Checked = false;
            }
        }
    }
}
