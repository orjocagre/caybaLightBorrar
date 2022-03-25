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
    public partial class CduRegistroEvento2 : UserControl
    {
        FrmRegistroEvento regeve;
        public CduRegistroEvento2(FrmRegistroEvento regeve)
        {
            InitializeComponent();
            this.regeve = regeve;
        }

        String formatoHora(String hora, String ampm)
        {
            String x;
            if(hora.Substring(0,2) == "12")
            {
                if(ampm == "AM")
                {
                    x = 00 + ":" + hora.Substring(3, 2) + ":00";
                }
                else
                {
                    x = hora + ":00";
                }
            }
            else
            {
                if (ampm == "PM")
                {
                    x = (Convert.ToInt32(hora.Substring(0, 2)) + 12) + ":" + hora.Substring(3, 2) + ":00";
                }
                else
                {
                    x = hora + ":00";
                }
            }
            
            return x;

        }
        void editarEvento()
        {
            ClsLogicaEvento evento = new ClsLogicaEvento();

            int antcan = chbAnticipoCancelado.Checked ? 1 : 0;
            int totcan = chbTotalCancelado.Checked ? 1 : 0;

            int idtipser = regeve.rbtBuffet.Checked ? 1 : 2;
            int sololoc = regeve.rbtSoloLocal.Checked ? 1 : 0;

            int[] areas = new int[4];

            areas[0] = regeve.chbSalon.Checked ? 1 : 0;
            areas[1] = regeve.chbTerraza.Checked ? 1 : 0;
            areas[2] = regeve.chbJardin.Checked ? 1 : 0;
            areas[3] = regeve.chbSalones.Checked ? 1 : 0;

            String msj = evento.editarEvento(regeve.idEvento, DateTime.Now, regeve.dtpFechaEvento.Value, Convert.ToInt32(regeve.cmbTipoEvento.SelectedValue), Convert.ToInt32(regeve.txtNumPersonas.Text), formatoHora(regeve.txtHora.Text, regeve.btnAmPm.Text), idtipser, sololoc, formatoHora(regeve.txtHoraComida.Text, regeve.btnAmPmComida.Text), Convert.ToInt32(regeve.txtDuracion.Text) - 5, regeve.txtComentarios.Text, regeve.total, Convert.ToDouble(TxtAnticipo.Text), Convert.ToDouble(txtPendiente.Text), (chbAnticipoCancelado.Checked ? 1 : 0), (chbTotalCancelado.Checked ? 1 : 0), txtNombre.Text, txtApellido.Text, txtCedula.Text, Convert.ToInt32(txtTelefono.Text), areas);
            MessageBox.Show(msj);



        }



        void guardarEvento()
        {
            ClsLogicaEvento evento = new ClsLogicaEvento();

            int antcan = chbAnticipoCancelado.Checked ? 1 : 0;
            int totcan = chbTotalCancelado.Checked ? 1 : 0;

            int idtipser = regeve.rbtBuffet.Checked ? 1 : 2;
            int sololoc = regeve.rbtSoloLocal.Checked ? 1 : 0;

            int[] areas = new int[4];

            areas[0] = regeve.chbSalon.Checked ? 1 : 0;
            areas[1] = regeve.chbTerraza.Checked ? 1 : 0;
            areas[2] = regeve.chbJardin.Checked ? 1 : 0;
            areas[3] = regeve.chbSalones.Checked ? 1 : 0;

            String msj = evento.agregarEvento(DateTime.Now, regeve.dtpFechaEvento.Value, Convert.ToInt32(regeve.cmbTipoEvento.SelectedValue), Convert.ToInt32(regeve.txtNumPersonas.Text), formatoHora(regeve.txtHora.Text,regeve.btnAmPm.Text), idtipser, sololoc, formatoHora(regeve.txtHoraComida.Text, regeve.btnAmPmComida.Text), Convert.ToInt32(regeve.txtDuracion.Text) - 5, regeve.txtComentarios.Text, regeve.total, Convert.ToDouble(TxtAnticipo.Text), Convert.ToDouble(txtPendiente.Text), (chbAnticipoCancelado.Checked ? 1 : 0), (chbTotalCancelado.Checked ? 1 : 0), txtNombre.Text, txtApellido.Text, txtCedula.Text, Convert.ToInt32(txtTelefono.Text), areas);
            MessageBox.Show(msj);

           

        }
        void validarCampos()
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            regeve.pnPrincipal.Enabled = true;
            regeve.pnPrincipal.Visible = true;
        }

        private void CduRegistroEvento2_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                txtTotal.Text = regeve.total.ToString("0,0.##");
                TxtAnticipo.Text = (regeve.total/2).ToString("0,0.##");
                txtPendiente.Text = (regeve.total / 2).ToString("0,0.##");
            }
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (regeve.idEvento == -1)
            {
                guardarEvento();
                regeve.cal.limpiarPanel();
                regeve.cal.cargarCalendario();
                regeve.Close();
            }
            else
            {
                editarEvento();
                regeve.cal.limpiarPanel();
                regeve.cal.cargarCalendario();
                regeve.Close();
            }



        }

        private void TxtAnticipo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPendiente.Text = (Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(TxtAnticipo.Text)).ToString();
                lblPorcentaje.Text = ((Convert.ToDouble(TxtAnticipo.Text) / Convert.ToDouble(txtTotal.Text)) * 100).ToString("00") + "%";


            }
            catch (FormatException ex)
            {
                txtPendiente.Text = Convert.ToDouble(txtTotal.Text).ToString();
                lblPorcentaje.Text = 0 + "%";

            }
        }
    }
}
