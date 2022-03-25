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
    public partial class FrmProformaEvento : Form
    {
        CduCalendario cal;
        int procedencia;
        Boolean deEvento;

        //procedencia es quien llamo al formulario, 1 calendario, 2 registroEvento
        public FrmProformaEvento(int procedencia)
        {
            InitializeComponent();
            this.procedencia = procedencia;
            deEvento = procedencia == 1 ? false : true;
        }
        public FrmProformaEvento(int procedencia, CduCalendario cal)
        {
            this.cal = cal;
            InitializeComponent();
            this.procedencia = procedencia;
            deEvento = procedencia == 1 ? false : true;
        }
        void calcularTotalesProforma()
        {
            try
            {
                double total = 0;
                for (int i = 0; i < dgvProforma.Rows.Count; i++)
                {
                    dgvProforma.Rows[i].Cells[4].Value = Convert.ToDouble(dgvProforma.Rows[i].Cells[1].Value) * Convert.ToDouble(dgvProforma.Rows[i].Cells[3].Value);
                    total += (double)dgvProforma.Rows[i].Cells[4].Value;

                }
                txtTotal.Text = total.ToString("0,0.##");

                lblError.Visible = false;

            }
            catch (FormatException ex)
            {
                lblError.Visible = true;
                txtTotal.Text = "";
            }
        }
        void eliminarRegistrosAnonimos()
        {
            ClsLogicaOrdenEvento evento = new ClsLogicaOrdenEvento();
            evento.eliminarRegistrosAnonimos();
        }
        void llenarTablaProductos()
        {
            ClsLogicaProforma proforma = new ClsLogicaProforma();
            dgvMenu.DataSource = proforma.buscarProductosEventos();
            dgvMenu.ColumnHeadersHeight = 26;
            dgvMenu.Columns[0].Visible = false;
            dgvMenu.Columns[1].Width = (int)((double)dgvMenu.Width * 0.8);

        }

        void llenarTablaProformas()
        {
            ClsLogicaOrdenEvento orden = new ClsLogicaOrdenEvento();
            DataTable DT = orden.tablaOrdenesSinIdEvento();
            
            for(int i=0; i<DT.Rows.Count; i++)
            {
                dgvProforma.Rows.Add();
                dgvProforma.Rows[i].Cells[0].Value = DT.Rows[i].Field<int>(0);
                dgvProforma.Rows[i].Cells[1].Value = DT.Rows[i].Field<double>(1);
                dgvProforma.Rows[i].Cells[2].Value = DT.Rows[i].Field<String>(2);
                dgvProforma.Rows[i].Cells[3].Value = DT.Rows[i].Field<double>(3);


            }

            calcularTotalesProforma();





        }

        private void FrmProformaEvento_Load(object sender, EventArgs e)
        {
            llenarTablaProductos();
            llenarTablaProformas();
        }

      

        private void FrmProformaEvento_Deactivate(object sender, EventArgs e)
        {
            if (!deEvento)
            {
                eliminarRegistrosAnonimos();
            }
            this.Close();

        }

        private void dgvMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProforma.Rows.Add();
            dgvProforma.Rows[dgvProforma.Rows.Count - 1].Cells[0].Value = dgvMenu.Rows[dgvMenu.SelectedRows[0].Index].Cells[0].Value;
            dgvProforma.Rows[dgvProforma.Rows.Count-1].Cells[2].Value = dgvMenu.Rows[dgvMenu.SelectedRows[0].Index].Cells[1].Value;
            dgvProforma.Rows[dgvProforma.Rows.Count - 1].Cells[3].Value = dgvMenu.Rows[dgvMenu.SelectedRows[0].Index].Cells[2].Value;
            dgvProforma.CurrentCell = dgvProforma.Rows[dgvProforma.Rows.Count - 1].Cells[1];
            dgvProforma.BeginEdit(true);

        }

        private void dgvProforma_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            calcularTotalesProforma();
        }

        void guardarProforma()
        {
            ClsLogicaOrdenEvento orden = new ClsLogicaOrdenEvento();
            orden.eliminarRegistrosAnonimos();

            for(int i=0; i<dgvProforma.Rows.Count; i++)
            {
                String msj = orden.agregarOrdenEvento(Convert.ToInt32(dgvProforma.Rows[i].Cells[0].Value), Convert.ToDouble(dgvProforma.Rows[i].Cells[1].Value), Convert.ToDouble(dgvProforma.Rows[i].Cells[3].Value));
                if(msj== "Error en sintaxis Sql")
                {
                    MessageBox.Show(msj);
                }
                
            }
            if(procedencia == 1)
            {
                FrmRegistroEvento reg = new FrmRegistroEvento(cal);
                reg.Visible = true;
                reg.Activate();
            }
            else if(procedencia == 2)
            {
                this.Close();

            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            deEvento = true;
            guardarProforma();
        }
    }
}
