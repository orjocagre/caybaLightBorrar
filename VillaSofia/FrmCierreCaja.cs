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
    public partial class FrmCierreCaja : Form
    {
        int idConjunto;
        public FrmCierreCaja(int idConjunto)
        {
            this.idConjunto = idConjunto;
            InitializeComponent();
            llenarDgvFacturas();
            llenarDgvMovimientos();
            llenarDgvInventarios();
        }

        void llenarDgvFacturas()
        {
            ClsLogicaFactura factura = new ClsLogicaFactura();
            DataTable DT = factura.listarFacturas(idConjunto);

            MessageBox.Show(DT.Rows.Count + "");
           

            double tot = 0;
            double efe = 0;
            double tar = 0;

            for(int i=0; i<DT.Rows.Count; i++)
            {
                dgvFacturas.Rows.Add();
                dgvFacturas.Rows[i].Cells[0].Value = DT.Rows[i][0];
                dgvFacturas.Rows[i].Cells[1].Value = DT.Rows[i].Field<double>(1).ToString("#,#.00");

                tot += DT.Rows[i].Field<double>("TOTAL");
                efe += DT.Rows[i].Field<double>("EFECTIVO");
                tar += DT.Rows[i].Field<double>("TARJETA");

            }

            txtFacturado.Text = "C$   " + tot.ToString("#,#.00");
            txtEfectivo.Text = "C$   " + efe.ToString("#,#.00");
            txtTarjeta.Text = "C$   " + tar.ToString("#,#.00");
            txtNumMesas.Text = DT.Rows.Count.ToString();

        }


        void llenarDgvMovimientos()
        {
            ClsLogicaMovimiento movimiento = new ClsLogicaMovimiento();
            DataTable DT = movimiento.listarMovimientos(idConjunto);
            double total = 0;
            dgvCaja.Rows.Clear();

            dgvCaja.Rows.Add();
            dgvCaja.Rows[dgvCaja.RowCount - 1].DefaultCellStyle.BackColor = Color.LightGray;
            dgvCaja.Rows[dgvCaja.RowCount - 1].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvCaja.Rows[dgvCaja.RowCount - 1].DefaultCellStyle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            dgvCaja.Rows[dgvCaja.RowCount - 1].Cells[1].Value = "ENTRADAS";

            for (int i = 0; i < DT.Rows.Count; i++)
            {

                if (DT.Rows[i].Field<int>("ENTRADA") == 1)
                {
                    dgvCaja.Rows.Add();

                    dgvCaja.Rows[dgvCaja.RowCount-1].Cells[0].Value = DT.Rows[i].Field<int>("ID");

                    double monto = DT.Rows[i].Field<double>("MONTO");
                    total += monto;
                    dgvCaja.Rows[dgvCaja.RowCount - 1].Cells[3].Value = monto.ToString("#,#.00");

                    dgvCaja.Rows[dgvCaja.RowCount - 1].Cells[2].Value = DT.Rows[i].Field<String>("DESCRIPCIÓN");

                    String hora = DT.Rows[i].Field<DateTime>("HORA").ToString("hh:mm tt");
                    dgvCaja.Rows[dgvCaja.RowCount - 1].Cells[1].Value = hora;
                }

                
            }

            dgvCaja.Rows.Add();
            dgvCaja.Rows[dgvCaja.RowCount - 1].DefaultCellStyle.BackColor = Color.LightGray;
            dgvCaja.Rows[dgvCaja.RowCount - 1].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvCaja.Rows[dgvCaja.RowCount - 1].DefaultCellStyle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            dgvCaja.Rows[dgvCaja.RowCount - 1].Cells[1].Value = "SALIDAS";


            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (DT.Rows[i].Field<int>("ENTRADA") == 0)
                {
                    dgvCaja.Rows.Add();

                    dgvCaja.Rows[dgvCaja.RowCount - 1].Cells[0].Value = DT.Rows[i].Field<int>("ID");

                    double monto = DT.Rows[i].Field<double>("MONTO");
                    monto = (monto * -1);
                    total += monto;
                    dgvCaja.Rows[dgvCaja.RowCount - 1].Cells[3].Value = monto.ToString("#,#.00");

                    dgvCaja.Rows[dgvCaja.RowCount - 1].Cells[2].Value = DT.Rows[i].Field<String>("DESCRIPCIÓN");

                    String hora = DT.Rows[i].Field<DateTime>("HORA").ToString("hh:mm tt");
                    dgvCaja.Rows[dgvCaja.RowCount - 1].Cells[1].Value = hora;
                }
            }

            dgvCaja.Rows.Add();
            dgvCaja.Rows[dgvCaja.RowCount - 1].DefaultCellStyle.BackColor = Color.LightGray;
            dgvCaja.Rows[dgvCaja.RowCount - 1].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvCaja.Rows[dgvCaja.RowCount - 1].DefaultCellStyle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            dgvCaja.Rows[dgvCaja.RowCount - 1].Cells[1].Value = "TOTAL";
            dgvCaja.Rows[dgvCaja.RowCount - 1].Cells[3].Value = total.ToString("#,#.00");


        }
        
        void llenarDgvInventarios()
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            DataTable ini = inventario.listarInventarioCierre(idConjunto, 1);
            DataTable fin = inventario.listarInventarioCierre(idConjunto, 0);
            DataTable ven = inventario.listarVentasBarraCierre(idConjunto);
            int contadorOrdenVenta = 0;

            for(int i=0; i<ini.Rows.Count; i++)
            {
                dgvInventarios.Rows.Add();
                dgvInventarios.Rows[i].Cells[0].Value = ini.Rows[i].Field<int>("ORDEN");
                dgvInventarios.Rows[i].Cells[1].Value = ini.Rows[i].Field<int>("ID");
                dgvInventarios.Rows[i].Cells[2].Value = ini.Rows[i].Field<String>("NOMBRE");
                dgvInventarios.Rows[i].Cells[3].Value = ini.Rows[i].Field<double>("CANTIDAD");
                dgvInventarios.Rows[i].Cells[4].Value = fin.Rows[i].Field<double>("CANTIDAD");
                double salida = ini.Rows[i].Field<double>("CANTIDAD") - fin.Rows[i].Field<double>("CANTIDAD");
                dgvInventarios.Rows[i].Cells[5].Style.ForeColor = salida < 0 ? Color.Red : Color.Black;
                dgvInventarios.Rows[i].Cells[5].Value = salida;
                
                if(contadorOrdenVenta < ven.Rows.Count)
                {
                    if (ini.Rows[i].Field<int>("ORDEN") == ven.Rows[contadorOrdenVenta].Field<int>("ORDEN"))
                    {
                        dgvInventarios.Rows[i].Cells[6].Value = ven.Rows[contadorOrdenVenta].Field<decimal>("VENTA");
                        contadorOrdenVenta++;
                    }
                    else
                    {
                        dgvInventarios.Rows[i].Cells[6].Value = 0;
                    }
                }
                else
                {
                    dgvInventarios.Rows[i].Cells[6].Value = 0;
                }



                double faltante = Convert.ToDouble(dgvInventarios.Rows[i].Cells[5].Value) - Convert.ToDouble(dgvInventarios.Rows[i].Cells[6].Value);
                if (faltante > 0)
                {
                    dgvInventarios.Rows[i].Cells[7].Value = "Faltan " + faltante;
                }
                else if(faltante < 0)
                {
                    dgvInventarios.Rows[i].Cells[7].Value = (faltante * -1) + " de más";
                }
                else
                {
                    dgvInventarios.Rows[i].Cells[7].Value = "";
                }
            }

            redimensionarVentana();
        }

        void redimensionarVentana()
        {
            dgvInventarios.FirstDisplayedScrollingRowIndex = dgvInventarios.RowCount - 1;
            int i = dgvInventarios.VerticalScrollingOffset;
            dgvInventarios.Size = new Size(dgvInventarios.Size.Width, i + dgvInventarios.Size.Height);

            sep2.Location = new Point(sep2.Location.X, sep2.Location.Y + i);
        }

        private void FrmCierreCaja_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //btn.Location = new Point(btn.Location.X, btn.Location.Y + guna2DataGridView1.RowTemplate.Height);
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(guna2DataGridView1.VerticalScrollingOffset.ToString());
            //guna2DataGridView1


            //guna2DataGridView1.CurrentCell = guna2DataGridView1.Rows[guna2DataGridView1.Rows.Count - 1].Cells[0];
            //guna2DataGridView1.BeginEdit(true);
            
            
            /*
            guna2DataGridView1.FirstDisplayedScrollingRowIndex = guna2DataGridView1.RowCount - 1;
            int i = guna2DataGridView1.VerticalScrollingOffset;
            guna2DataGridView1.Size = new Size(guna2DataGridView1.Size.Width, i + guna2DataGridView1.Size.Height);

            sep.Location = new Point(sep.Location.X, sep.Location.Y + i);
            */

        }

        
    }
}
