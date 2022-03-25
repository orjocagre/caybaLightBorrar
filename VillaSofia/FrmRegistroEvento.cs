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
using System.Media;
using System.Globalization;


namespace VillaSofia
{
    public partial class FrmRegistroEvento : Form
    {
        public CduCalendario cal;
        CduRegistroEvento2 regeve2;
        public double total;
        public int idEvento;




        public FrmRegistroEvento(CduCalendario cal)
        {
            this.idEvento = -1;
            this.cal = cal;
            regeve2 = new CduRegistroEvento2(this);
            this.Controls.Add(regeve2);
            regeve2.Visible = false;
            InitializeComponent();
            dtpFechaEvento.Value = DateTime.Now;
            dtpFechaEvento.MinDate = DateTime.Now;
            llenarCmbTipoEvento();

        }

        //azucar
        public FrmRegistroEvento(CduCalendario cal, int idEvento)
        {
            this.cal = cal;
            regeve2 = new CduRegistroEvento2(this);
            this.Controls.Add(regeve2);
            regeve2.Visible = false;
            InitializeComponent();
            dtpFechaEvento.Value = DateTime.Now;
            dtpFechaEvento.MinDate = DateTime.Now;
            this.idEvento = idEvento;
            llenarCmbTipoEvento();
            llenarCampos();

            ClsLogicaOrdenEvento ordeve = new ClsLogicaOrdenEvento();
            ordeve.eliminarRegistrosAnonimos();
            ordeve.desVincularOrdenEvento(idEvento);
            mostrarTotal();

        }


        void llenarCampos()
        {
            ClsLogicaEvento evento = new ClsLogicaEvento();
            DataTable DT = evento.infoEventosEditar(idEvento);
            cmbTipoEvento.SelectedValue = DT.Rows[0].Field<int>("TIPOEVENTO");
            dtpFechaEvento.Value = DT.Rows[0].Field<DateTime>("FECHA");
            txtComentarios.Text = DT.Rows[0].Field<String>("COMENTARIOS");
            txtNumPersonas.Text = DT.Rows[0].Field<int>("PERSONAS").ToString();
            txtDuracion.Text = (DT.Rows[0].Field<int>("HORAEXTRA") + 5).ToString();
            rbtBuffet.Checked = DT.Rows[0].Field<int>("TIPOSERVICIO") == 1 ? true : false;
            rbtServicioEnMesas.Checked = DT.Rows[0].Field<int>("TIPOSERVICIO") == 2 ? true : false;
            regeve2.txtNombre.Text = DT.Rows[0].Field<String>("NOMBRE");
            regeve2.txtApellido.Text = DT.Rows[0].Field<String>("APELLIDO");
            regeve2.txtCedula.Text = DT.Rows[0].Field<String>("CEDULA");
            regeve2.txtTelefono.Text = DT.Rows[0].Field<int>("TELEFONO").ToString();
            regeve2.chbTotalCancelado.Checked = DT.Rows[0].Field<Int16>("TOTALCANCELADO") == 1 ? true : false;
            regeve2.chbAnticipoCancelado.Checked = DT.Rows[0].Field<Int16>("ANTICIPOCANCELADO") == 1 ? true : false;

            int hora = DT.Rows[0].Field<TimeSpan>("HORA").Hours;
            int min = DT.Rows[0].Field<TimeSpan>("HORA").Minutes;
            DateTime fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hora, min, 0);

            txtHora.Text = fecha.ToString("hh:mm", CultureInfo.CreateSpecificCulture("en-US"));
            btnAmPm.Text = fecha.ToString("tt", CultureInfo.CreateSpecificCulture("en-US"));

            hora = DT.Rows[0].Field<TimeSpan>("HORACOMIDA").Hours;
            min = DT.Rows[0].Field<TimeSpan>("HORACOMIDA").Minutes;
            fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hora, min, 0);

            txtHoraComida.Text = fecha.ToString("hh:mm", CultureInfo.CreateSpecificCulture("en-US"));
            btnAmPmComida.Text = fecha.ToString("tt", CultureInfo.CreateSpecificCulture("en-US"));

        }

        //azucar
       


        

        void llenarCmbTipoEvento()
        {
            ClsLogicaEvento evento = new ClsLogicaEvento();
            cmbTipoEvento.DataSource = evento.cmbTipoEvento();
            cmbTipoEvento.DisplayMember = "TIPO";
            cmbTipoEvento.ValueMember = "ID";
        }

        Boolean validarInt(String a)
        {
            try
            {
                int b = Convert.ToInt32(a);
                return true;
            }
            catch (FormatException e)

            {
                return false;
            }
        }
        
        private void txtHora_KeyDown(object sender, KeyEventArgs e)
        {
            int tam = txtHora.Text.Length;
            //MessageBox.Show(e.KeyCode.ToString());

            //si ya tiene el tama;o correcto solo se admite la tecla borrar
            if (tam > 4)
            {
                e.SuppressKeyPress = e.KeyCode == Keys.Back ? false : true;
            }
            //si ya se ingreso un 1 en la hora solo admite un 0 1 o 2
            if (txtHora.Text == "1" && tam == 1 && ((e.KeyCode >= Keys.D3 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad3 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back))
            {
                //MessageBox.Show("aqui");

                e.SuppressKeyPress = true;

            }

            

            //verifica si la teclas que se acaba de presionar es un numero
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) ||
                e.KeyCode == Keys.Decimal || e.KeyCode == Keys.Back)
            {

            }
            else
            {
                e.SuppressKeyPress = true;
            }
        }

      
        private void txtHora_KeyUp(object sender, KeyEventArgs e)
        {
            int tam = txtHora.Text.Length;
            if (tam == 2)
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtHora.Text = txtHora.Text.Substring(0, 1);
                }
                else
                {
                    txtHora.Text = txtHora.Text + ":";
                }
                txtHora.SelectionStart = txtHora.Text.Length;


            }

            if (tam == 1 && !(e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0) && txtHora.Text != "0")
            {

                txtHora.Text = "0" + txtHora.Text + ":";
                txtHora.SelectionStart = txtHora.Text.Length;

            }

            if(tam == 4 && ((e.KeyCode >= Keys.D6 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad6 && e.KeyCode <= Keys.NumPad9)))
            {
                txtHora.Text = txtHora.Text.Substring(0, 3) + "0" + txtHora.Text.Substring(3, 1);
                txtHora.SelectionStart = txtHora.Text.Length;
            }



        }

        


        private void btnProforma_Click(object sender, EventArgs e)
        {
            FrmProformaEvento proeve = new FrmProformaEvento(2, cal);
            proeve.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pnPrincipal.Visible = false;
            pnPrincipal.Enabled = false;
            regeve2.Enabled = true;
            regeve2.Visible = true;
        }

        public void mostrarTotal()
        {
            ClsLogicaOrdenEvento orden = new ClsLogicaOrdenEvento();
            try
            {
                total = orden.precioOrdenes() + ((Convert.ToDouble(txtDuracion.Text) - 5) * 800);
                lblTotal.Text = "TOTAL:  C$ " + total.ToString("#,0.00");
            }
            catch(FormatException e)
            {
                total = orden.precioOrdenes();
                lblTotal.Text = "TOTAL:  C$ " + total.ToString("#,0.00");
            }
            
        }

        private void txtHoraComida_KeyUp(object sender, KeyEventArgs e)
        {
            int tam = txtHoraComida.Text.Length;
            if (tam == 2)
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtHoraComida.Text = txtHoraComida.Text.Substring(0, 1);
                }
                else
                {
                    txtHoraComida.Text = txtHoraComida.Text + ":";
                }
                txtHoraComida.SelectionStart = txtHoraComida.Text.Length;


            }

            if (tam == 1 && !(e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0) && txtHora.Text != "0")
            {

                txtHoraComida.Text = "0" + txtHoraComida.Text + ":";
                txtHoraComida.SelectionStart = txtHoraComida.Text.Length;

            }

            if (tam == 4 && ((e.KeyCode >= Keys.D6 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad6 && e.KeyCode <= Keys.NumPad9)))
            {
                txtHoraComida.Text = txtHoraComida.Text.Substring(0, 3) + "0" + txtHoraComida.Text.Substring(3, 1);
                txtHoraComida.SelectionStart = txtHoraComida.Text.Length;
            }
        }

        private void txtHoraComida_KeyDown(object sender, KeyEventArgs e)
        {
            int tam = txtHoraComida.Text.Length;
            //MessageBox.Show(e.KeyCode.ToString());

            //si ya tiene el tama;o correcto solo se admite la tecla borrar
            if (tam > 4)
            {
                e.SuppressKeyPress = e.KeyCode == Keys.Back ? false : true;
            }
            //si ya se ingreso un 1 en la hora solo admite un 0 1 o 2
            if (txtHoraComida.Text == "1" && tam == 1 && ((e.KeyCode >= Keys.D3 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad3 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back))
            {
                //MessageBox.Show("aqui");

                e.SuppressKeyPress = true;

            }



            //verifica si la teclas que se acaba de presionar es un numero
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) ||
                e.KeyCode == Keys.Decimal || e.KeyCode == Keys.Back)
            {

            }
            else
            {
                e.SuppressKeyPress = true;
            }
        }

        
        private void FrmRegistroEvento_Activated(object sender, EventArgs e)
        {
            mostrarTotal();
        }

        private void FrmRegistroEvento_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClsLogicaOrdenEvento orden = new ClsLogicaOrdenEvento();
            orden.eliminarRegistrosAnonimos();
        }

        private void txtHora_Enter(object sender, EventArgs e)
        {
            btnAmPm.FillColor = Color.FromArgb(94, 148, 255);
        }

        private void txtHora_Leave(object sender, EventArgs e)
        {
            btnAmPm.FillColor = Color.FromArgb(213, 218, 223);

        }
        private void txtHoraComida_Enter(object sender, EventArgs e)
        {
            btnAmPmComida.FillColor = Color.FromArgb(94, 148, 255);
        }

        private void txtHoraComida_Leave(object sender, EventArgs e)
        {
            btnAmPmComida.FillColor = Color.FromArgb(213, 218, 223);
        }


        private void btnAmPm_Click(object sender, EventArgs e)
        {
            btnAmPm.Text = btnAmPm.Text == "AM" ? "PM" : "AM";
        }

        private void btnAmPmComida_Click(object sender, EventArgs e)
        {
            btnAmPmComida.Text = btnAmPmComida.Text == "AM" ? "PM" : "AM";
        }


        Boolean validarCedula(String txt)
        {
            
            if(txt.Length == 16)
            {
                for(int i=0; i<16; i++)
                {
                    char c = txt.ToCharArray()[i];
                    if (i==15)
                    {
                        if (!char.IsLetter(c))
                        {
                            return false;
                        }
                    }
                    else if(i==3 || i == 10)
                    {
                        if (c != '-')
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (!char.IsNumber(c))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FrmRegistroEvento_Load(object sender, EventArgs e)
        {
            

        }

        private void txtDuracion_Leave(object sender, EventArgs e)
        {
            mostrarTotal();
        }

        

      

        private void txtDuracion_TextChanged(object sender, EventArgs e)
        {
            mostrarTotal();
        }

        
        
    }
}
