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
using System.Globalization;


namespace VillaSofia
{
    public partial class CduMostrarEventoPrecio : UserControl
    {
        FrmMostrarEvento moseve;
        int idEvento;
        public CduMostrarEventoPrecio(FrmMostrarEvento moseve, int idEvento)
        {
            this.idEvento = idEvento;
            this.moseve = moseve;
            InitializeComponent();
            llenarCampos();
        }

        void llenarCampos()
        {
            ClsLogicaEvento evento = new ClsLogicaEvento();
            DataTable DT = evento.InfoEventos(idEvento);

            // el espacio a la derecha del formulario es de 12
            int anchoPanel = pnPrincipal.Size.Width;

            lblTipoEvento.Text = DT.Rows[0].Field<String>("TIPOEVENTO");
            lblTipoEvento.Location = new Point(anchoPanel - lblTipoEvento.Width - 12, lblTipoEvento.Location.Y);
            lblNombre.Text = DT.Rows[0].Field<String>("NOMBRE");
            lblNombre.Location = new Point(anchoPanel - lblNombre.Width - 12, lblNombre.Location.Y);
            int dia, mes, agno, hora, min;
            dia = DT.Rows[0].Field<DateTime>("FECHA").Day;
            mes = DT.Rows[0].Field<DateTime>("FECHA").Month;
            agno = DT.Rows[0].Field<DateTime>("FECHA").Year;
            hora = DT.Rows[0].Field<TimeSpan>("HORA").Hours;
            min = DT.Rows[0].Field<TimeSpan>("HORA").Minutes;

            int horasExtra = DT.Rows[0].Field<int>("HORAEXTRA");

            DateTime fecha = new DateTime(agno, mes, dia, hora, min, 0);
            lblFecha.Text = fecha.ToString("dddd d/M/yyy", CultureInfo.CreateSpecificCulture("es-ES"));

            lblTotal.Text = DT.Rows[0].Field<double>("TOTAL").ToString();
            lblAnticipo.Text = DT.Rows[0].Field<double>("ANTICIPO").ToString();
            lblPendiente.Text = (DT.Rows[0].Field<double>("TOTAL") - DT.Rows[0].Field<double>("ANTICIPO")).ToString();

            if(DT.Rows[0].Field<Int16>("TOTALCANCELADO") == 1)
            {
                chbTotalCancelado.Checked = true;
                chbAnticipoCancelado.Checked = true;
            }
            else
            {
                chbTotalCancelado.Checked = false;
                chbAnticipoCancelado.Checked = DT.Rows[0].Field<Int16>("ANTICIPOCANCELADO") == 1 ? true : false;
            }

            DT = evento.InfoPlatos(idEvento);
            double total = 0;

            int i;
            for(i=0; i<DT.Rows.Count; i++)
            {
                dgvCuenta.Rows.Add();
                dgvCuenta.Rows[i].Cells[0].Value = DT.Rows[i].Field<double>(1).ToString();
                dgvCuenta.Rows[i].Cells[1].Value = DT.Rows[i].Field<string>(2);
                dgvCuenta.Rows[i].Cells[2].Value =  DT.Rows[i].Field<double>(3).ToString("#,0.00");
                double tot = DT.Rows[i].Field<double>(1) * DT.Rows[i].Field<double>(3);
                total += tot;
                dgvCuenta.Rows[i].Cells[3].Value = tot.ToString("#,0.00");

            }

            if(horasExtra > 0)
            {
                dgvCuenta.Rows.Add();
                dgvCuenta.Rows[i].Cells[0].Value = horasExtra;
                dgvCuenta.Rows[i].Cells[1].Value = "Horas Extra";
                dgvCuenta.Rows[i].Cells[2].Value = "800.00";
                total += (horasExtra * 800);
                dgvCuenta.Rows[i].Cells[3].Value = (horasExtra * 800).ToString("#,0.00");
                i++;

            }

            dgvCuenta.Rows.Add();
            
            dgvCuenta.Rows[i].Cells[0].Value = "Total:";
            dgvCuenta.Rows[i].Cells[3].Value = total.ToString("#,0.00");

        }


        
        private void btnComida_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            moseve.pnPrincipal.Visible = true;

        }

        private void chbTotalCancelado_CheckedChanged(object sender, EventArgs e)
        {
            ClsLogicaEvento eve = new ClsLogicaEvento();
            eve.cambiarEstadoEvento(1, chbTotalCancelado.Checked ? 1 : 0, idEvento);

            if (chbTotalCancelado.Checked)
            {
                chbAnticipoCancelado.Checked = true;
            }
            else
            {
                chbAnticipoCancelado.Checked = false;
            }

        }

        private void chbAnticipoCancelado_CheckedChanged(object sender, EventArgs e)
        {
            ClsLogicaEvento eve = new ClsLogicaEvento();
            eve.cambiarEstadoEvento(2, chbAnticipoCancelado.Checked ? 1 : 0, idEvento);

            if (!chbAnticipoCancelado.Checked && chbTotalCancelado.Checked)
            {
                chbTotalCancelado.Checked = false;

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmRegistroEvento regeve = new FrmRegistroEvento(moseve.cal, idEvento);
            regeve.Visible = true;
        }
    }
}
