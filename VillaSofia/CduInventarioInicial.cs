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
    public partial class CduInventarioInicial : UserControl
    {
        VillaSofia vs;
        int idConjunto;
        DataTable productos;  //aqui se guarda: sinomino formateado, sinonimo, nombre del producto, id del producto
        DataTable productosA;
        List<int> coincidencias; //aqui se guarda un lista de las posiciones de los productos mas semejantes a la busqueda (se guardan indices de la tabla productos)
        List<int> coincidenciasA;
        int cantTxt;
        String nomTxt;
        int cantTxtA;
        String nomTxtA;
        int inicial;
        int idInventario;
        Boolean inventarioGuardado;

        public CduInventarioInicial(VillaSofia vs, int idConjunto, int inicial, int idInventario, Boolean inventarioGuardado)
        {
            this.Dock = DockStyle.Fill;
            this.vs = vs;
            this.idConjunto = idConjunto;
            this.idInventario = idInventario;
            this.inventarioGuardado = inventarioGuardado;
            cantTxt = 0;
            nomTxt = "";
            cantTxtA = 0;
            nomTxtA = "";
            this.inicial = inicial;
            coincidencias = new List<int>();
            coincidenciasA = new List<int>();
            llenarProductos();
            llenarProductosA();
            InitializeComponent();
            ubicarLsbProducto();
            ubicarLsbProductoA();
            llenarDgvInventario();
            llenarDgvInventarioA();
            lblInventario.Text = inicial == 1 ? "Inventario Inicial" : "Inventario Final";

            if (idInventario != -1)
            {
                cargarInventarioPreguardado();
            }
        }
        void cargarInventarioPreguardado()
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            DataTable DT;
            DT = inventario.listarInventarioPreguardado(idInventario);

            for (int i = 0; i < dgvInventario.RowCount; i++)
            {
                double x = DT.Rows[i].Field<double>(0);
                dgvInventario.Rows[i].Cells[1].Value = (x % 1) == 0 ? x : Math.Truncate(x);
            }

            DT = inventario.listarInventarioPreguardadoA(idInventario);


            for (int i = 0; i < dgvInventarioA.RowCount; i++)
            {
                double x = DT.Rows[i].Field<double>(0);
                double pesoLiquido = DT.Rows[i].Field<double>(3);
                double pesoVacia = DT.Rows[i].Field<double>(4);
                double peso = (x % 1) * pesoLiquido;
                dgvInventarioA.Rows[i].Cells[1].Value = (peso == 0 ? 0 : peso + pesoVacia);
            }
        }

        void llenarDgvInventario()
        {
            ClsLogicaInsumo insumo = new ClsLogicaInsumo();
            DataTable DT = insumo.listarInsumosInventario();

            dgvInventario.Rows.Clear();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                dgvInventario.Rows.Add();
                dgvInventario.Rows[i].Cells[0].Value = DT.Rows[i].Field<int>("ID");
                dgvInventario.Rows[i].Cells[2].Value = DT.Rows[i].Field<String>("NOMBRE");

            }
        }

        void llenarDgvInventarioA()
        {
            ClsLogicaInsumo insumo = new ClsLogicaInsumo();
            DataTable DT = insumo.listarInsumosInventarioA();

            dgvInventarioA.Rows.Clear();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                dgvInventarioA.Rows.Add();
                dgvInventarioA.Rows[i].Cells[0].Value = DT.Rows[i].Field<int>("ID");
                dgvInventarioA.Rows[i].Cells[2].Value = "gr";
                dgvInventarioA.Rows[i].Cells[3].Value = DT.Rows[i].Field<String>("NOMBRE");

            }

        }

        void ubicarLsbProducto()
        {
            lsbProducto.Location = new Point(txtBusqueda.Location.X, txtBusqueda.Location.Y + txtBusqueda.Size.Height);
            redimensionarLsbProducto();
        }

        void ubicarLsbProductoA()
        {
            lsbProductoA.Location = new Point(txtBusquedaA.Location.X, txtBusquedaA.Location.Y + txtBusquedaA.Size.Height);
            redimensionarLsbProductoA();
        }

        void llenarProductos()
        {
            ClsLogicaInsumo insumo = new ClsLogicaInsumo();
            productos = insumo.listarInsumosBarra();
            DataColumn DC = new DataColumn("cod", System.Type.GetType("System.Int32"));
            productos.Columns.Add(DC);
            DC.SetOrdinal(0);

            for (int i = 0; i < productos.Rows.Count; i++)
            {
                productos.Rows[i]["cod"] = i;
            }
        }

        void llenarProductosA()
        {
            ClsLogicaInsumo insumo = new ClsLogicaInsumo();
            productosA = insumo.listarInsumosBarraA();
            DataColumn DC = new DataColumn("cod", System.Type.GetType("System.Int32"));
            productosA.Columns.Add(DC);
            DC.SetOrdinal(0);

            for (int i = 0; i < productosA.Rows.Count; i++)
            {
                productosA.Rows[i]["cod"] = i;
            }
        }

        void redimensionarLsbProducto()
        {
            if (lsbProducto.Items.Count > 0)
            {
                lsbProducto.Visible = true;
                lsbProducto.Enabled = true;
                lsbProducto.Size = new Size(txtBusqueda.Size.Width, (lsbProducto.Items.Count + 1) * lsbProducto.ItemHeight);
            }
            else
            {
                lsbProducto.Enabled = false;
                lsbProducto.Visible = false;
            }

        }

        void redimensionarLsbProductoA()
        {
            if (lsbProductoA.Items.Count > 0)
            {
                lsbProductoA.Visible = true;
                lsbProductoA.Enabled = true;
                lsbProductoA.Size = new Size(txtBusquedaA.Size.Width, (lsbProductoA.Items.Count + 1) * lsbProductoA.ItemHeight);
            }
            else
            {
                lsbProductoA.Enabled = false;
                lsbProductoA.Visible = false;
            }
        }


        String formatear(String x)
        {
            String txt = x.Trim().Replace(" ", "").ToLower();
            txt.Replace("á", "a");
            txt.Replace("é", "e");
            txt.Replace("í", "i");
            txt.Replace("ó", "o");
            txt.Replace("ú", "u");

            return txt;


        }

        Boolean validarEntero(String t)
        {
            try
            {
                int n = Convert.ToInt32(t);
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }
        }

        Boolean validarTxtBusqueda()
        {
            String txt = txtBusqueda.Text;
            if (txt != "")
            {
                if (validarEntero(txt.Substring(0, 1)))
                {
                    for (int i = 0; i < txt.Length; i++)
                    {
                        if (!validarEntero(txt.Substring(i, 1)))
                        {
                            cantTxt = Convert.ToInt32(txt.Substring(0, i));
                            nomTxt = txt.Substring(i);
                            return true;
                        }
                    }
                    lsbProducto.Enabled = false;
                    lsbProducto.Visible = false;
                    return false;
                }
                else
                {
                    cantTxt = -1;
                    nomTxt = txt;
                    return true;


                    //lsbProducto.Enabled = false;
                    //lsbProducto.Visible = false;
                    //return false;
                }
            }
            else
            {
                lsbProducto.Enabled = false;
                lsbProducto.Visible = false;
                return false;
            }
        }

        Boolean validarTxtBusquedaA()
        {
            String txt = txtBusquedaA.Text;
            if (txt != "")
            {
                if (validarEntero(txt.Substring(0, 1)))
                {
                    for (int i = 0; i < txt.Length; i++)
                    {
                        if (!validarEntero(txt.Substring(i, 1)))
                        {
                            cantTxtA = Convert.ToInt32(txt.Substring(0, i));
                            nomTxtA = txt.Substring(i);
                            return true;
                        }
                    }
                    lsbProductoA.Enabled = false;
                    lsbProductoA.Visible = false;
                    return false;
                }
                else
                {
                    cantTxtA = -1;
                    nomTxtA = txt;
                    return true;


                    //lsbProducto.Enabled = false;
                    //lsbProducto.Visible = false;
                    //return false;
                }
            }
            else
            {
                lsbProductoA.Enabled = false;
                lsbProductoA.Visible = false;
                return false;
            }
        }

        void mostrarOpciones()
        {
            this.coincidencias.Clear();
            if (validarTxtBusqueda())
            {

                ClsLogicaBuscador buscador = new ClsLogicaBuscador();
                int[] coincidencias;
                String[] sinF = new String[productos.Rows.Count];

                for (int i = 0; i < sinF.Length; i++)
                {
                    sinF[i] = productos.Rows[i]["sinF"].ToString();
                }

                coincidencias = buscador.ordenarElementos(sinF, formatear(nomTxt));

                if (coincidencias.Length > 0)
                {
                    lsbProducto.Items.Clear();

                    for (int i = 0; i < coincidencias.Length; i++)
                    {
                        lsbProducto.Items.Add(productos.Rows[coincidencias[i]]["sin"]);
                        this.coincidencias.Add(coincidencias.ElementAt(i));
                    }

                    redimensionarLsbProducto();
                    lsbProducto.SelectedIndex = 0;
                }
                else
                {
                    lsbProducto.Items.Clear();
                    redimensionarLsbProducto();
                }
            }
        }


        void mostrarOpcionesA()
        {
            this.coincidenciasA.Clear();
            if (validarTxtBusquedaA())
            {

                ClsLogicaBuscador buscador = new ClsLogicaBuscador();
                int[] coincidencias;
                String[] sinF = new String[productosA.Rows.Count];

                for (int i = 0; i < sinF.Length; i++)
                {
                    sinF[i] = productosA.Rows[i]["sinF"].ToString();
                }

                coincidencias = buscador.ordenarElementos(sinF, formatear(nomTxtA));

                if (coincidencias.Length > 0)
                {
                    lsbProductoA.Items.Clear();

                    for (int i = 0; i < coincidencias.Length; i++)
                    {
                        lsbProductoA.Items.Add(productosA.Rows[coincidencias[i]]["sin"]);
                        this.coincidenciasA.Add(coincidencias.ElementAt(i));
                    }

                    redimensionarLsbProductoA();
                    lsbProductoA.SelectedIndex = 0;
                }
                else
                {
                    lsbProductoA.Items.Clear();
                    redimensionarLsbProductoA();
                }
            }
        }


        void agregarAlDgvInventario()
        {


            if (cantTxt == -1)
            {
                dgvInventario.CurrentCell = dgvInventario.Rows[coincidencias.ElementAt<int>(0)].Cells[1];
                dgvInventario.BeginEdit(true);
            }
            else
            {
                if (rbtAsignar.Checked)
                {
                    dgvInventario.Rows[coincidencias.ElementAt<int>(0)].Cells[1].Value = cantTxt;

                }
                else
                {
                    dgvInventario.Rows[coincidencias.ElementAt<int>(0)].Cells[1].Value = Convert.ToInt32(dgvInventario.Rows[coincidencias.ElementAt<int>(0)].Cells[1].Value) + Convert.ToInt32(cantTxt);
                }
            }
            txtBusqueda.Text = "";

        }

        void agregarAlDgvInventarioA()
        {


            if (cantTxtA == -1)
            {
                dgvInventarioA.CurrentCell = dgvInventarioA.Rows[coincidenciasA.ElementAt<int>(0)].Cells[1];
                dgvInventarioA.BeginEdit(true);
            }
            else
            {
                if (rbtAsignar.Checked)
                {
                    dgvInventarioA.Rows[coincidenciasA.ElementAt<int>(0)].Cells[1].Value = cantTxtA;

                }
                else
                {
                    dgvInventarioA.Rows[coincidenciasA.ElementAt<int>(0)].Cells[1].Value = Convert.ToInt32(dgvInventarioA.Rows[coincidenciasA.ElementAt<int>(0)].Cells[1].Value) + Convert.ToInt32(cantTxtA);
                }
            }
            txtBusquedaA.Text = "";

        }

        void guardarInventario()
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            DateTime DT = DateTime.Now;
            int idInventario = inventario.agregarInventario(DT, inicial);
            for (int i = 0; i < dgvInventario.RowCount; i++)
            {
                dgvInventario.Rows[i].Cells[1].Value = dgvInventario.Rows[i].Cells[1].Value == null ? 0 : dgvInventario.Rows[i].Cells[1].Value;
                inventario.agregarInventarioInsumo(idInventario, Convert.ToInt32(dgvInventario.Rows[i].Cells[0].Value), Convert.ToDouble(dgvInventario.Rows[i].Cells[1].Value), 0);
            }
            for (int i = 0; i < dgvInventarioA.RowCount; i++)
            {
                dgvInventarioA.Rows[i].Cells[1].Value = dgvInventarioA.Rows[i].Cells[1].Value == null ? 0 : dgvInventarioA.Rows[i].Cells[1].Value;
                double gr = Convert.ToDouble(dgvInventarioA.Rows[i].Cells[1].Value);
                String um = dgvInventarioA.Rows[i].Cells[2].Value.ToString();
                gr = um == "gr" ? gr : (um == "kg" ? gr * 1000 : gr * 453.592);

                inventario.agregarInventarioInsumo(idInventario, Convert.ToInt32(dgvInventarioA.Rows[i].Cells[0].Value), gr, 1);
            }
            MessageBox.Show("Inventario Guardado");

            inventarioGuardado = true;
            this.idInventario = idInventario;

            this.Dispose();
            vs.Controls.Add(new CduMenuConjunto(vs, idConjunto));
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            mostrarOpciones();

        }

        private void txtBusquedaA_TextChanged(object sender, EventArgs e)
        {
            mostrarOpcionesA();

        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lsbProducto.Visible && (int)e.KeyChar == (int)Keys.Enter)
            {
                agregarAlDgvInventario();
                e.Handled = true;
            }
        }

        private void txtBusquedaA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lsbProductoA.Visible && (int)e.KeyChar == (int)Keys.Enter)
            {
                agregarAlDgvInventarioA();
                e.Handled = true;
            }
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Up" || e.KeyCode.ToString() == "Down")
            {
                e.Handled = true;
            }
        }

        private void txtBusquedaA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Up" || e.KeyCode.ToString() == "Down")
            {
                e.Handled = true;
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (lsbProducto.Visible)
            {
                if (e.KeyCode.ToString() == "Up")
                {
                    if (lsbProducto.SelectedIndex != 0)
                    {
                        lsbProducto.SelectedIndex -= 1;
                    }
                }
                if (e.KeyCode.ToString() == "Down")
                {
                    if (lsbProducto.SelectedIndex < lsbProducto.Items.Count - 1)
                    {
                        lsbProducto.SelectedIndex += 1;
                    }
                }
            }
        }

        private void txtBusquedaA_KeyUp(object sender, KeyEventArgs e)
        {
            if (lsbProductoA.Visible)
            {
                if (e.KeyCode.ToString() == "Up")
                {
                    if (lsbProductoA.SelectedIndex != 0)
                    {
                        lsbProductoA.SelectedIndex -= 1;
                    }
                }
                if (e.KeyCode.ToString() == "Down")
                {
                    if (lsbProductoA.SelectedIndex < lsbProductoA.Items.Count - 1)
                    {
                        lsbProductoA.SelectedIndex += 1;
                    }
                }
            }
        }

        private void btbGuardar_Click(object sender, EventArgs e)
        {
            guardarInventario();

        }

        private void dgvInventarioA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInventarioA.BeginEdit(true);

        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInventario.BeginEdit(true);

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
            vs.Controls.Add(new CduMenuConjunto(vs, idConjunto));
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            vs.Controls.Add(new CduMenuConjunto(vs, idConjunto));
        }
    }
}
