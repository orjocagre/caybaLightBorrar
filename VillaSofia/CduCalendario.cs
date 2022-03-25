using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Logica;

namespace VillaSofia
{
    public partial class CduCalendario : UserControl
    {
        VillaSofia vs;
        Boolean cmbLlenos;
        DataTable DT;
        public CduCalendario(VillaSofia vs)
        {
            this.vs = vs;
            cmbLlenos = false;
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            llenarCombobox();
            cargarCalendario();
           
        }

        public void llenarCombobox()
        {
            cmbMes.Items.Add("Enero");
            cmbMes.Items.Add("Febrero");
            cmbMes.Items.Add("Marzo");
            cmbMes.Items.Add("Abril");
            cmbMes.Items.Add("Mayo");
            cmbMes.Items.Add("Junio");
            cmbMes.Items.Add("Julio");
            cmbMes.Items.Add("Agosto");
            cmbMes.Items.Add("Septiembre");
            cmbMes.Items.Add("Octubre");
            cmbMes.Items.Add("Noviembre");
            cmbMes.Items.Add("Diciembre");

            cmbAgno.Items.Add("2020");
            cmbAgno.Items.Add("2021");
            cmbAgno.Items.Add("2022");

            cmbAgno.SelectedIndex = 1;
            cmbMes.SelectedIndex = DateTime.Now.Month - 1;

            cmbLlenos = true;




        }

        public void cargarCalendario()
        {
            DateTime hoy = DateTime.Now;
            int agnoSelec = Convert.ToInt32(cmbAgno.SelectedItem);
            int mesSelec = cmbMes.SelectedIndex + 1;

            //se verifica si el mes seleccionado corresponde al actual
            Boolean mesActual = false;
            if (agnoSelec == hoy.Year && mesSelec == hoy.Month)
            {
                mesActual = true;
            }

            //se guarda el num de dias del mes anterior
            int diasMesAnterior;
            if(mesSelec == 1)
            {
                diasMesAnterior = DateTime.DaysInMonth(agnoSelec-1, 12);
            }
            else
            {
                diasMesAnterior = DateTime.DaysInMonth(agnoSelec, mesSelec - 1);
            }

            //se guarda en que dia de la semana cayo el primero del mes seleccionado. Y se calcula la fecha del primer dia del calendario restandole al primero del mes el numero correspondiente al dayoftheweek en que cae y 1
            DateTime primeroMes = new DateTime(agnoSelec, mesSelec , 1);
            int dayofweek = (int)primeroMes.DayOfWeek;
            if (dayofweek == 0)
            {
                dayofweek = 7;
            }
            DateTime primeroCal = primeroMes.AddDays(-(dayofweek-1));
            DateTime ultimoCal = primeroCal.AddDays(41);

            DateTime diaIterado = primeroCal;

            ClsLogicaEvento evento = new ClsLogicaEvento();
            DT = evento.buscarEventosCalendario(primeroCal, ultimoCal);

            int tipoFecha;

            for (int i = 1; i < pnTabla.RowCount; i++)
            {
                for (int j = 0; j < pnTabla.ColumnCount; j++)
                {
                    if (diaIterado.Month == mesSelec)
                    {
                        tipoFecha = 2;

                        if(mesActual && diaIterado.Day == hoy.Day)
                        {
                            tipoFecha = 1;
                        }
                    }
                    else
                    {
                        tipoFecha = 3;
                    }

                    pnTabla.Controls.Add(crearPanelDia(diaIterado.Day, diaIterado.Month, tipoFecha), j, i);
                    diaIterado = diaIterado.AddDays(1);
                }
            }
        }

        //hay 3 tipos de fecha: 1-La de hoy, 2-Una fecha perteneciente al mes selec, 3-Una fecha de otro mes
        public Guna2Panel crearPanelDia(int fecha, int mes, int tipoFecha)
        {
            Guna2Panel panel = new Guna2Panel();
            panel.Dock = DockStyle.Fill;
            panel.AutoScroll = true;

            if (tipoFecha == 2)
            {
                panel.FillColor = Color.White;
                //panel.FillColor = Color.FromArgb(162, 185, 238);
            }
            else if(tipoFecha == 3)
            {
                panel.FillColor = Color.LightGray;
                //panel.FillColor = Color.FromArgb(154, 156, 234);
            }
            else
            {
                panel.FillColor = Color.FromArgb(153,180,209);
                //panel.FillColor = Color.FromArgb(162, 220, 238);
            }
            Guna2HtmlLabel lblfecha = new Guna2HtmlLabel();
            lblfecha.Text = Convert.ToString(fecha);
            lblfecha.Font = new Font("Tw Cen MT", 12, FontStyle.Regular);
            lblfecha.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);

            panel.Controls.Add(lblfecha);
            lblfecha.Location = new Point((int)(panel.Size.Width - (lblfecha.Size.Width)), (int)(panel.Size.Height - (lblfecha.Size.Height)));

            int cont = 0;
            for(int i=0; i<DT.Rows.Count; i++)
            {
                if(DT.Rows[i].Field<DateTime>("fecha_evento").Day == fecha && DT.Rows[i].Field<DateTime>("fecha_evento").Month == mes)
                {
                    Guna2Button btnEve = new Guna2Button();
                    btnEve.Text = DT.Rows[i].Field<String>("descripcion") + " \n" + DT.Rows[i].Field<String>("nombres") + " " + DT.Rows[i].Field<String>("apellidos").Substring(0, 1) + ".";
                    btnEve.Font = new Font("Ink Free", 14, FontStyle.Regular);
                    btnEve.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    btnEve.FillColor = Color.Transparent;
                    btnEve.BackColor = Color.Transparent;
                    btnEve.ForeColor = Color.DarkBlue;
                    btnEve.TextAlign = HorizontalAlignment.Left;
                    btnEve.Size = new Size(panel.Width, 50);
                    panel.Controls.Add(btnEve);
                    btnEve.Location = new Point(0, cont * btnEve.Height);
                    btnEve.Name = "btn" + DT.Rows[i].Field<int>("id_evento");
                    btnEve.Click += new EventHandler(evento_Click);
                    cont++;
                }
            }
            return panel;

        }
        public void limpiarPanel()
        {
            for (int i = 0; i < pnTabla.Controls.Count; i++)
            {
                if (pnTabla.Controls[i].Name == "")
                {
                    pnTabla.Controls.Remove(pnTabla.Controls[i]);
                    i--;
                }
            }
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void evento_Click(Object sender, EventArgs e)
        {
            // When the button is clicked,
            // change the button text, and disable it.

            Guna2Button clickedButton = (Guna2Button)sender;
            FrmMostrarEvento eve = new FrmMostrarEvento(Convert.ToInt32(clickedButton.Name.Substring(3)), this);
            eve.Visible = true;

            // Display the greeting label text.
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            vs.Controls.Remove(this);
            vs.Controls.Add(new CduMenuPrincipal(vs));
            this.Dispose();

        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLlenos)
            {
                limpiarPanel();
                cargarCalendario();
            }
            

        }

        private void cmbAgno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLlenos)
            {
                limpiarPanel();
                cargarCalendario();
            }
            
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            FrmRegistroEvento evento = new FrmRegistroEvento(this);
            evento.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmProformaEvento proforma = new FrmProformaEvento(1, this);
            proforma.Visible = true;


        }
    }
}
