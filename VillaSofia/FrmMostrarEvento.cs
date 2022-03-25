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
using System.Globalization;

namespace VillaSofia
{
    public partial class FrmMostrarEvento : Form
    {
        int idEvento;
        public CduCalendario cal;
        CduMostrarEventoPrecio evepre;

        public FrmMostrarEvento(int idEvento, CduCalendario cal)
        {
            this.cal = cal;
            this.idEvento = idEvento;
            evepre = new CduMostrarEventoPrecio(this, idEvento);
            this.Controls.Add(this.evepre);
            evepre.Visible = false;
            InitializeComponent();
            llenarCampos();
        }

        String formatoHoras(String x)
        {
            x = x.Substring(0, 5);
            String y;
            String h;
            String m;
            String ampm;

            if (Convert.ToInt32(x.Substring(0, 2)) >= 12)
            {
                ampm = "pm";
                h = (Convert.ToInt32(x.Substring(0, 2))-12).ToString().Replace("0","");
                m = x.Substring(3, 2);
            }
            else
            {
                ampm = "am";
                h = x.Substring(0,2).Replace("0", "");
                m = x.Substring(3, 2);
            }
            h = h == "" ? "12" : h;
            y = h + ":" + m + " " + ampm;
            return y;
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


            DateTime fecha = new DateTime(agno, mes, dia, hora, min, 0);
            lblFecha.Text = fecha.ToString("dddd d/M/yyy", CultureInfo.CreateSpecificCulture("es-ES"));
            
            lblHora.Text = "De " + fecha.ToString("h:mm tt", CultureInfo.CreateSpecificCulture("en-US")) + " a " + fecha.AddHours(DT.Rows[0].Field<int>("HORAEXTRA") + 5).ToString("h:mm tt", CultureInfo.CreateSpecificCulture("en-US"));
            DateTime horaComida = new DateTime(fecha.Year, fecha.Month, fecha.Day, DT.Rows[0].Field<TimeSpan>("HORACOMIDA").Hours, DT.Rows[0].Field<TimeSpan>("HORACOMIDA").Minutes, 0);
            String sp = horaComida.Hour == 1 ? "la " : "las ";
            lblHoraComida.Text = "Comida a " + sp + horaComida.ToString("h:mm tt", CultureInfo.CreateSpecificCulture("en-US"));
            lblTipoServicio.Text = DT.Rows[0].Field<String>("TIPOSERVICIO");
            lblNumInvitados.Text = DT.Rows[0].Field<int>("PERSONAS") + " invitados";
            lblArea.Text = evento.areasEvento(idEvento);
            lblComentarios.Text = DT.Rows[0].Field<String>("COMENTARIOS");


            dgvPlatos.DataSource = evento.InfoPlatos(idEvento);
            dgvPlatos.Columns[0].Visible = false;
            dgvPlatos.Columns[3].Visible = false;
            dgvPlatos.Columns[1].FillWeight = 1;
            dgvPlatos.Columns[2].FillWeight = 6;



        }


       
        private void FrmMostrarEvento_Load(object sender, EventArgs e)
        {
            llenarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmRegistroEvento regeve = new FrmRegistroEvento(cal, idEvento);
            regeve.Visible = true;
        }

        private void btnDinero_Click(object sender, EventArgs e)
        {
            pnPrincipal.Visible = false;
            evepre.Visible = true;
        }
    }
}
