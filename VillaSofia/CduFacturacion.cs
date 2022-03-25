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
using Guna.UI2.WinForms;
using PrinterUtility;

namespace VillaSofia
{
    public partial class CduFacturacion : UserControl
    {
        VillaSofia vs;
        List<int> coincidencias;
        int cantTxt;
        String nomTxt;
        DataTable productos;
        int idFactura;
        CduFacturacionVacio vacio;
        int estadoCuenta;
        Boolean facturaEditada;
        Boolean pnOpcionesAbierto;
        CduPanelOpcionesCaja opc;

        //public DateTime fechaInventario;
        int idConjunto;

        public CduFacturacion(VillaSofia vs, int idConjunto)
        {
            this.idConjunto = idConjunto;
            desplegado = false;
            pnOpcionesAbierto = false;
            this.vs = vs;
            facturaEditada = false;
            idFactura = -1;
            this.Dock = DockStyle.Fill;
            cantTxt = 0;
            nomTxt = "";
            coincidencias = new List<int>();
            llenarProductos();
            InitializeComponent();

            ubicarLsbProducto();
            agregarPanelVacio();
            cargarPanelFacturas();
            llenarCmbMesero();
            crearPanelOpciones();
        }

        public void cerrarConjunto()
        {
            ClsLogicaConjunto conjunto = new ClsLogicaConjunto();
            MessageBox.Show(conjunto.cerrarConjunto(idConjunto, DateTime.Now));
        }

        

        

        

        void agregarPanelVacio()
        {
            vacio = new CduFacturacionVacio();
            this.Controls.Add(vacio);
            vacio.Location = new Point(125, 0);
            vacio.Size = new Size(this.Size.Width - 125, this.Size.Height);
            vacio.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            vacio.BringToFront();
        }

        void llenarCmbMesero()
        {
            ClsLogicaRegistroTrabajador trabajador = new ClsLogicaRegistroTrabajador();
            cmbMesero.DataSource = trabajador.llenarCmbMeseros();
            cmbMesero.ValueMember = "ID";
            cmbMesero.DisplayMember = "NOMBRE";
        }

        void imprimirFactura()
        {
            PrinterUtility.EscPosEpsonCommands.EscPosEpson impresora = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();
            var BytesValue = impresora.Separator();
            BytesValue = PrintExtensions.AddBytes(BytesValue, impresora.CharSize.DoubleWidth8());
            BytesValue = PrintExtensions.AddBytes(BytesValue, impresora.FontSelect.FontA());
            BytesValue = PrintExtensions.AddBytes(BytesValue, impresora.Alignment.Center());
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Funciona"));
            //PrintExtensions.Print(BytesValue, )


        }

        //byte[] cortarRecibo()
        //{
        //    List<byte>
        //}

        void cargarPanelFacturas()
        {
            pnBotonesFacturas.Controls.Clear();

            ClsLogicaFactura factura = new ClsLogicaFactura();
            DataTable DT;
            if (chbMostrarTodas.Checked)
            {
                DT = factura.mostrarFacturasparaPanel(idConjunto);
            }
            else
            {
                DT = factura.mostrarFacturasSinCancelarparaPanel(idConjunto);

            }
            int anchoBoton;
            if (DT.Rows.Count * (45 + 6) < pnBotonesFacturas.Size.Height)
            {
                anchoBoton = 94;
            }
            else
            {
                anchoBoton = 79;
            }

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                Guna2Button btn = new Guna2Button();
                btn.Text = "F " + DT.Rows[i].Field<int>("ID");
                btn.Name = "btnF" + DT.Rows[i].Field<int>("ID");

                switch (DT.Rows[i].Field<int>("ESTADO"))
                {
                    case 1:
                        btn.FillColor = Color.PaleGreen;
                        break;

                    case 2:
                        btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                        break;

                    case 3:
                        btn.FillColor = Color.Silver;
                        break;

                    case 4:
                        btn.FillColor = Color.NavajoWhite;
                        break;

                }

                btn.Size = new Size(anchoBoton, 45);
                btn.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.BorderRadius = 3;
                btn.ForeColor = Color.Black;
                pnBotonesFacturas.Controls.Add(btn);
                btn.Click += new EventHandler(evento_Click);
            }



        }


        void mostrarPanelVacio()
        {
            vacio.BringToFront();
        }

        void ocultarPanelVacio()
        {
            pnPrincipal.BringToFront();
        }
        void agregarNuevaFactura()
        {
            facturaEditada = false;
            btnCerrar.Text = "CERRAR CUENTA";
            btnAbierta.Text = "DEJAR ABIERTA";

            txtBusqueda.Enabled = true;
            btnEliminar.Enabled = true;
            cmbMesero.Enabled = true;
            txtNombre.Enabled = true;
            txtRUC.Enabled = true;
            dgvCuenta.ReadOnly = false;

            dgvCuenta.Rows.Clear();
            ClsLogicaFactura fact = new ClsLogicaFactura();
            int msj = fact.agregarFactura(DateTime.Now, 1, "", "", -1, 1);
            if (msj == -3)
            {
                MessageBox.Show("Error en sintaxis Sql");
            }
            else
            {
                ocultarPanelVacio();
                idFactura = msj;
                Guna2Button btn = new Guna2Button();
                btn.Text = "F " + idFactura;
                btn.Name = "btnF" + idFactura;
                btn.FillColor = Color.PaleGreen;
                btn.Size = new Size(94, 45);
                btn.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.BorderRadius = 3;
                btn.ForeColor = Color.Black;
                pnBotonesFacturas.Controls.Add(btn);
                btn.Click += new EventHandler(evento_Click);

                lblFactura.Text = "Factura " + idFactura + ":";
                estadoCuenta = 1;
                txtBusqueda.Focus();
            }
            //System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            //PaleGreen
            //NavajoWhite
            //Silver


        }

        void ubicarLsbProducto()
        {
            lsbProducto.Location = new Point(txtBusqueda.Location.X, txtBusqueda.Location.Y + txtBusqueda.Size.Height);
            redimensionarLsbProducto();
        }


        void llenarProductos()
        {
            ClsLogicaProducto registro = new ClsLogicaProducto();
            productos = registro.listarProductos(1);
            DataColumn DC = new DataColumn("cod", System.Type.GetType("System.Int32"));
            productos.Columns.Add(DC);
            DC.SetOrdinal(0);

            for (int i = 0; i < productos.Rows.Count; i++)
            {
                productos.Rows[i]["cod"] = i;
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


        void crearPanelOpciones()
        {
            opc = new CduPanelOpcionesCaja(this);
            this.Controls.Add(opc);
            opc.Location = new Point(61, 70);
            opc.SendToBack();
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

        void calcularTotalesFactura()
        {
            try
            {
                double total = 0;
                for (int i = 0; i < dgvCuenta.Rows.Count; i++)
                {
                    dgvCuenta.Rows[i].Cells[4].Value = Convert.ToDouble(dgvCuenta.Rows[i].Cells[1].Value) * Convert.ToDouble(dgvCuenta.Rows[i].Cells[3].Value);
                    total += (double)dgvCuenta.Rows[i].Cells[4].Value;

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

        void insertarRegistroComanda(int orden)
        {
            facturaEditada = true;
            if (cantTxt != -1)
            {

                ClsLogicaProducto prod = new ClsLogicaProducto();
                dgvCuenta.Rows.Add();
                dgvCuenta.Rows[dgvCuenta.Rows.Count - 1].Cells[0].Value = productos.Rows[coincidencias.ElementAt(lsbProducto.SelectedIndex)]["id"];
                dgvCuenta.Rows[dgvCuenta.Rows.Count - 1].Cells[1].Value = cantTxt;
                dgvCuenta.Rows[dgvCuenta.Rows.Count - 1].Cells[2].Value = productos.Rows[coincidencias.ElementAt(lsbProducto.SelectedIndex)]["nom"];
                dgvCuenta.Rows[dgvCuenta.Rows.Count - 1].Cells[3].Value = prod.buscarProducto(productos.Rows[coincidencias.ElementAt(lsbProducto.SelectedIndex)]["id"].ToString()).Rows[0].Field<double>("Precio");
                calcularTotalesFactura();
                txtBusqueda.Text = "";

                //ClsLogicaRegistroComanda registro = new ClsLogicaRegistroComanda();
                //MessageBox.Show(lsbProducto.SelectedIndex + " "+ coincidencias.ElementAt(lsbProducto.SelectedIndex) + " " + productos.Rows[coincidencias.ElementAt(lsbProducto.SelectedIndex)]["id"]);
                //registro.insertarRegistroComanda(cantTxt, Convert.ToInt32(productos.Rows[coincidencias.ElementAt(lsbProducto.SelectedIndex)]["id"]), idProcedencia, idConjunto, Convert.ToInt32(cmbMesero.SelectedValue), orden);
                //llenarTabla();
                //txtBusqueda.Text = "";

            }
            else
            {
                ClsLogicaProducto prod = new ClsLogicaProducto();
                dgvCuenta.Rows.Add();
                dgvCuenta.Rows[dgvCuenta.Rows.Count - 1].Cells[0].Value = productos.Rows[coincidencias.ElementAt(lsbProducto.SelectedIndex)]["id"];
                dgvCuenta.Rows[dgvCuenta.Rows.Count - 1].Cells[2].Value = productos.Rows[coincidencias.ElementAt(lsbProducto.SelectedIndex)]["nom"];
                dgvCuenta.Rows[dgvCuenta.Rows.Count - 1].Cells[3].Value = prod.buscarProducto(productos.Rows[coincidencias.ElementAt(lsbProducto.SelectedIndex)]["id"].ToString()).Rows[0].Field<double>("Precio");
                dgvCuenta.CurrentCell = dgvCuenta.Rows[dgvCuenta.Rows.Count - 1].Cells[1];
                dgvCuenta.BeginEdit(true);
                txtBusqueda.Text = "";

            }



        }

        void guardarFactura()
        {
            ClsLogicaOrden orden = new ClsLogicaOrden();
            ClsLogicaFactura factura = new ClsLogicaFactura();

            for (int i = 0; i < dgvCuenta.RowCount; i++)
            {
                orden.agregarOrden(Convert.ToInt32(dgvCuenta.Rows[i].Cells[0].Value), idFactura, Convert.ToDouble(dgvCuenta.Rows[i].Cells[1].Value), Convert.ToDouble(dgvCuenta.Rows[i].Cells[3].Value));
            }
            factura.guardarTotalFactura(idFactura, Convert.ToDouble(txtTotal.Text));
            factura.agregarDatosFactura(idFactura, txtNombre.Text, txtRUC.Text, Convert.ToInt32(cmbMesero.SelectedValue));

        }

        void cerrarFactura()
        {
            ClsLogicaOrden orden = new ClsLogicaOrden();
            orden.vaciarFactura(idFactura);
            guardarFactura();

            Guna2Button btn = (Guna2Button)pnBotonesFacturas.Controls["btnF" + idFactura];
            btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));

            ClsLogicaFactura fact = new ClsLogicaFactura();
            fact.cambiarEstadoFactura(idFactura, 2);
            estadoCuenta = 2;

            btnCerrar.Text = "CANCELADA";
            btnAbierta.Text = "EDITAR";

            //MessageBox.Show("Imprimiendo factura");

            txtBusqueda.Enabled = false;
            btnEliminar.Enabled = false;
            cmbMesero.Enabled = false;
            txtNombre.Enabled = false;
            txtRUC.Enabled = false;
            dgvCuenta.ReadOnly = true;
            facturaEditada = false;

        }
        void mostrarFormularioDePago()
        {
            FrmCancelarFactura canf = new FrmCancelarFactura(Convert.ToDouble(txtTotal.Text), this, idFactura);
            canf.Visible = true;
            canf.txtEfectivoCordobas.Focus();
        }
        public void cancelarFactura()
        {
            
            Guna2Button btn = (Guna2Button)pnBotonesFacturas.Controls["btnF" + idFactura];

            if (chbMostrarTodas.Checked)
            {
                btn.FillColor = Color.Silver;
            }
            else
            {
                pnBotonesFacturas.Controls.Remove(btn);
            }

            ClsLogicaFactura fact = new ClsLogicaFactura();
            fact.cambiarEstadoFactura(idFactura, 3);

            dgvCuenta.Rows.Clear();
            mostrarPanelVacio();



        }

        void eliminarRegistro()
        {
            dgvCuenta.Rows.Remove(dgvCuenta.Rows[dgvCuenta.CurrentCell.RowIndex]);


        }

        void mostrarFactura()
        {

            ocultarPanelVacio();
            dgvCuenta.Rows.Clear();
            ClsLogicaOrden orden = new ClsLogicaOrden();
            ClsLogicaFactura factura = new ClsLogicaFactura();
            DataTable DT = factura.infoFactura(idFactura);
            cmbMesero.SelectedValue = DT.Rows[0][5];
            txtNombre.Text = DT.Rows[0].Field<String>(3);
            txtRUC.Text = DT.Rows[0].Field<String>(4);


            DT = orden.listarOrdenes(idFactura);
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                dgvCuenta.Rows.Add();
                //MessageBox.Show(DT.Rows[i].Field<int>("ID")+" "+ DT.Rows[i].Field<double>("CANTIDAD")+" "+ DT.Rows[i].Field<int>("NOMBRE")+" "+ DT.Rows[i].Field<int>("PRECIO"));

                dgvCuenta.Rows[i].Cells[0].Value = DT.Rows[i].Field<int>("ID");
                dgvCuenta.Rows[i].Cells[1].Value = DT.Rows[i].Field<int>("CANTIDAD");
                dgvCuenta.Rows[i].Cells[2].Value = DT.Rows[i].Field<String>("NOMBRE");
                dgvCuenta.Rows[i].Cells[3].Value = DT.Rows[i].Field<double>("PRECIO");
            }

            calcularTotalesFactura();

            lblFactura.Text = "Factura " + idFactura + ":";

            if (estadoCuenta == 1)
            {
                txtBusqueda.Enabled = true;
                btnEliminar.Enabled = true;
                cmbMesero.Enabled = true;
                txtNombre.Enabled = true;
                txtRUC.Enabled = true;
                dgvCuenta.ReadOnly = false;
                btnCerrar.Text = "CERRAR CUENTA";
                btnAbierta.Text = "DEJAR ABIERTA";
            }
            else if (estadoCuenta == 2)
            {
                txtBusqueda.Enabled = false;
                btnEliminar.Enabled = false;
                cmbMesero.Enabled = false;
                txtNombre.Enabled = false;
                txtRUC.Enabled = false;
                dgvCuenta.ReadOnly = true;
                btnCerrar.Text = "CANCELADA";
                btnAbierta.Text = "EDITAR";
            }
            else if (estadoCuenta == 3)
            {
                txtBusqueda.Enabled = false;
                btnEliminar.Enabled = false;
                cmbMesero.Enabled = false;
                txtNombre.Enabled = false;
                txtRUC.Enabled = false;
                dgvCuenta.ReadOnly = true;
                btnCerrar.Text = "EDITAR";
                btnAbierta.Text = "ELIMINAR";
            }



        }
        void editarFacturaCerrada()
        {
            DialogResult result = MessageBox.Show("Esta factura ya esta cerrada y ya se imprimió el recibo del Cliente\nDesea editarla e imprimir un nuevo recibo?", "Advertencia", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                ClsLogicaFactura factura = new ClsLogicaFactura();
                factura.cambiarEstadoFactura(idFactura, 1);
                estadoCuenta = 1;
                btnCerrar.Text = "CERRAR CUENTA";
                btnAbierta.Text = "DEJAR ABIERTA";

                txtBusqueda.Enabled = true;
                dgvCuenta.ReadOnly = false;
                btnEliminar.Enabled = true;
                cmbMesero.Enabled = true;
                txtNombre.Enabled = true;
                txtRUC.Enabled = true;

                Guna2Button btn = (Guna2Button)pnBotonesFacturas.Controls["btnF" + idFactura];
                btn.FillColor = Color.PaleGreen;

            }
            else if (result == DialogResult.No)
            {

            }

        }

        void dejarAbiertaFactura()
        {
            facturaEditada = false;
            ClsLogicaOrden orden = new ClsLogicaOrden();
            orden.vaciarFactura(idFactura);
            guardarFactura();
            mostrarPanelVacio();
        }

        Boolean validarFacturasCanceladas()
        {
            ClsLogicaFactura factura = new ClsLogicaFactura();
            return factura.validarFacturasCanceladas(idConjunto);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            mostrarOpciones();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lsbProducto.Visible && (int)e.KeyChar == (int)Keys.Enter)
            {
                insertarRegistroComanda(-1);
                e.Handled = true;
            }
            else if ((int)e.KeyChar == 10)
            {
                cerrarFactura();
                agregarNuevaFactura();
            }
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvCuenta_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuenta.Focused)
            {
                facturaEditada = true;
            }
            calcularTotalesFactura();
            txtBusqueda.Focus();
        }

        private void btnNuevaCuenta_Click(object sender, EventArgs e)
        {
            if (facturaEditada)
            {
                MessageBox.Show("Desea cerrar la cuenta o dejarla abierta?");

            }
            else
            {
                agregarNuevaFactura();

            }


        }

        void evento_Click(Object sender, EventArgs e)
        {

            if (facturaEditada)
            {
                MessageBox.Show("Desea cerrar la cuenta o dejarla abierta?");
            }
            else
            {
                Guna2Button clickedButton = (Guna2Button)sender;
                idFactura = Convert.ToInt32(clickedButton.Name.Substring(4));
                ClsLogicaFactura factura = new ClsLogicaFactura();
                estadoCuenta = factura.mostrarEstadoFactura(idFactura).Rows[0].Field<int>(0);

                mostrarFactura();
            }



        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (estadoCuenta == 1)
            {
                cerrarFactura();
            }
            else if (estadoCuenta == 2)
            {
                mostrarFormularioDePago();
            }
            else if (estadoCuenta == 3)
            {
                agregarNuevaFactura();
            }
        }

        private void btnAbierta_Click(object sender, EventArgs e)
        {
            if (estadoCuenta == 1)
            {
                dejarAbiertaFactura();
            }
            else if (estadoCuenta == 2)
            {
                editarFacturaCerrada();
            }
            else if (estadoCuenta == 3)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            facturaEditada = true;
            eliminarRegistro();
        }
        //161
        private void btnAtras_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                this.Dispose();
                vs.Controls.Add(new CduMenuPrincipal(vs));

            }
            else if (result == DialogResult.No)
            {

            }
        }
        Boolean desplegado;
        private void btnDesplegarNombre_Click(object sender, EventArgs e)
        {
            if (desplegado)
            {
                pnNombreRuc.Size = new Size(pnNombreRuc.Size.Width, 10);
                cmbMesero.Location = new Point(cmbMesero.Location.X, cmbMesero.Location.Y - 158);
                lblMesero.Location = new Point(lblMesero.Location.X, lblMesero.Location.Y - 158);
                txtBusqueda.Location = new Point(txtBusqueda.Location.X, txtBusqueda.Location.Y - 158);
                lsbProducto.Location = new Point(lsbProducto.Location.X, lsbProducto.Location.Y - 158);
                btnDesplegarNombre.Image = Properties.Resources.abajoWhiteSmoke32;
                desplegado = false;
            }
            else
            {
                pnNombreRuc.Size = new Size(pnNombreRuc.Size.Width, 180);
                lblMesero.Location = new Point(lblMesero.Location.X, lblMesero.Location.Y + 158);
                cmbMesero.Location = new Point(cmbMesero.Location.X, cmbMesero.Location.Y + 158);
                txtBusqueda.Location = new Point(txtBusqueda.Location.X, txtBusqueda.Location.Y + 158);
                lsbProducto.Location = new Point(lsbProducto.Location.X, lsbProducto.Location.Y + 158);
                btnDesplegarNombre.Image = Properties.Resources.arribaWhiteSmoke32;
                desplegado = true;

            }


        }

        private void chbMostrarTodas_CheckedChanged(object sender, EventArgs e)
        {
            cargarPanelFacturas();
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            //if (validarFacturasCanceladas())
            //{
            //    FrmCierreCaja cierre = new FrmCierreCaja();
            //    cierre.Visible = true;
            //}
            //else
            //{
            //    MessageBox.Show("Todavia hay facturas sin cancelar");
            //}

            //btnOpciones.FillColor = Color.FromArgb(64, 64, 64);
            if(pnOpcionesAbierto)
            {
                btnOpciones.Image = Properties.Resources.trespuntosGris1;
                opc.SendToBack();
                pnOpcionesAbierto = false;
            }
            else
            {
                btnOpciones.Image = Properties.Resources.trespuntosNegro;
                opc.BringToFront();
                pnOpcionesAbierto = true;
            }
                
            

            
            
        }

       
    }
}
