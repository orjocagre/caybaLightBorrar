namespace VillaSofia
{
    partial class CduFacturacion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.lblFactura = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.lsbProducto = new System.Windows.Forms.ListBox();
            this.btnNuevaCuenta = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnAbierta = new Guna.UI2.WinForms.Guna2Button();
            this.pnPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.chbMostrarTodas = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pnBotonesFacturas = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvCuenta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMesero = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnNombreRuc = new Guna.UI2.WinForms.Guna2Panel();
            this.txtRUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbMesero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnOpciones = new Guna.UI2.WinForms.Guna2Button();
            this.btnAtras = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnDesplegarNombre = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            this.pnPrincipal.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.pnNombreRuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.btnEliminar);
            this.guna2Panel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(693, 65);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(52, 59);
            this.guna2Panel2.TabIndex = 13;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.CheckedState.Parent = this.btnCerrar;
            this.btnCerrar.CustomImages.Parent = this.btnCerrar;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.HoverState.Parent = this.btnCerrar;
            this.btnCerrar.Location = new System.Drawing.Point(570, 635);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(166, 45);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "CERRAR CUENTA";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblFactura
            // 
            this.lblFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(13, 32);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(76, 27);
            this.lblFactura.TabIndex = 11;
            this.lblFactura.Text = "Factura ";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.DefaultText = "";
            this.txtBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.DisabledState.Parent = this.txtBusqueda;
            this.txtBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.FocusedState.Parent = this.txtBusqueda;
            this.txtBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.HoverState.Parent = this.txtBusqueda;
            this.txtBusqueda.Location = new System.Drawing.Point(3, 115);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.PlaceholderText = "";
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.ShadowDecoration.Parent = this.txtBusqueda;
            this.txtBusqueda.Size = new System.Drawing.Size(311, 38);
            this.txtBusqueda.TabIndex = 10;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // lsbProducto
            // 
            this.lsbProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbProducto.FormattingEnabled = true;
            this.lsbProducto.ItemHeight = 25;
            this.lsbProducto.Location = new System.Drawing.Point(56, 462);
            this.lsbProducto.Name = "lsbProducto";
            this.lsbProducto.Size = new System.Drawing.Size(192, 204);
            this.lsbProducto.TabIndex = 9;
            this.lsbProducto.Visible = false;
            // 
            // btnNuevaCuenta
            // 
            this.btnNuevaCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevaCuenta.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevaCuenta.BorderThickness = 2;
            this.btnNuevaCuenta.CheckedState.Parent = this.btnNuevaCuenta;
            this.btnNuevaCuenta.CustomImages.Parent = this.btnNuevaCuenta;
            this.btnNuevaCuenta.FillColor = System.Drawing.Color.White;
            this.btnNuevaCuenta.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCuenta.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaCuenta.HoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevaCuenta.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.btnNuevaCuenta.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCuenta.HoverState.Parent = this.btnNuevaCuenta;
            this.btnNuevaCuenta.Location = new System.Drawing.Point(-3, 597);
            this.btnNuevaCuenta.Name = "btnNuevaCuenta";
            this.btnNuevaCuenta.ShadowDecoration.Parent = this.btnNuevaCuenta;
            this.btnNuevaCuenta.Size = new System.Drawing.Size(115, 97);
            this.btnNuevaCuenta.TabIndex = 8;
            this.btnNuevaCuenta.Text = "NUEVA FACTURA";
            this.btnNuevaCuenta.Click += new System.EventHandler(this.btnNuevaCuenta_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2VSeparator1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(106, 32);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 586);
            this.guna2VSeparator1.TabIndex = 7;
            // 
            // btnAbierta
            // 
            this.btnAbierta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbierta.CheckedState.Parent = this.btnAbierta;
            this.btnAbierta.CustomImages.Parent = this.btnAbierta;
            this.btnAbierta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbierta.ForeColor = System.Drawing.Color.White;
            this.btnAbierta.HoverState.Parent = this.btnAbierta;
            this.btnAbierta.Location = new System.Drawing.Point(384, 635);
            this.btnAbierta.Name = "btnAbierta";
            this.btnAbierta.ShadowDecoration.Parent = this.btnAbierta;
            this.btnAbierta.Size = new System.Drawing.Size(166, 45);
            this.btnAbierta.TabIndex = 14;
            this.btnAbierta.Text = "DEJAR ABIERTA";
            this.btnAbierta.Click += new System.EventHandler(this.btnAbierta_Click);
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.White;
            this.pnPrincipal.ColumnCount = 3;
            this.pnPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.pnPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnPrincipal.Controls.Add(this.guna2Panel5, 0, 0);
            this.pnPrincipal.Controls.Add(this.guna2Panel4, 2, 0);
            this.pnPrincipal.Controls.Add(this.guna2Panel3, 1, 0);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.RowCount = 1;
            this.pnPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnPrincipal.Size = new System.Drawing.Size(1202, 697);
            this.pnPrincipal.TabIndex = 15;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.btnOpciones);
            this.guna2Panel5.Controls.Add(this.btnAtras);
            this.guna2Panel5.Controls.Add(this.chbMostrarTodas);
            this.guna2Panel5.Controls.Add(this.pnBotonesFacturas);
            this.guna2Panel5.Controls.Add(this.btnNuevaCuenta);
            this.guna2Panel5.Controls.Add(this.guna2VSeparator1);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(119, 691);
            this.guna2Panel5.TabIndex = 2;
            // 
            // chbMostrarTodas
            // 
            this.chbMostrarTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbMostrarTodas.AutoSize = true;
            this.chbMostrarTodas.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbMostrarTodas.CheckedState.BorderRadius = 2;
            this.chbMostrarTodas.CheckedState.BorderThickness = 0;
            this.chbMostrarTodas.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbMostrarTodas.Location = new System.Drawing.Point(6, 574);
            this.chbMostrarTodas.Name = "chbMostrarTodas";
            this.chbMostrarTodas.Size = new System.Drawing.Size(90, 17);
            this.chbMostrarTodas.TabIndex = 11;
            this.chbMostrarTodas.Text = "Mostrar todas";
            this.chbMostrarTodas.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbMostrarTodas.UncheckedState.BorderRadius = 2;
            this.chbMostrarTodas.UncheckedState.BorderThickness = 0;
            this.chbMostrarTodas.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbMostrarTodas.UseVisualStyleBackColor = true;
            this.chbMostrarTodas.CheckedChanged += new System.EventHandler(this.chbMostrarTodas_CheckedChanged);
            // 
            // pnBotonesFacturas
            // 
            this.pnBotonesFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBotonesFacturas.AutoScroll = true;
            this.pnBotonesFacturas.Location = new System.Drawing.Point(3, 78);
            this.pnBotonesFacturas.Name = "pnBotonesFacturas";
            this.pnBotonesFacturas.Size = new System.Drawing.Size(102, 490);
            this.pnBotonesFacturas.TabIndex = 11;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel4.Controls.Add(this.txtTotal);
            this.guna2Panel4.Controls.Add(this.lblError);
            this.guna2Panel4.Controls.Add(this.dgvCuenta);
            this.guna2Panel4.Controls.Add(this.lblFactura);
            this.guna2Panel4.Controls.Add(this.guna2Panel2);
            this.guna2Panel4.Controls.Add(this.btnAbierta);
            this.guna2Panel4.Controls.Add(this.btnCerrar);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(451, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(748, 691);
            this.guna2Panel4.TabIndex = 1;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(519, 582);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(68, 30);
            this.guna2HtmlLabel3.TabIndex = 18;
            this.guna2HtmlLabel3.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(590, 579);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(97, 36);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(13, 579);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(202, 21);
            this.lblError.TabIndex = 16;
            this.lblError.Text = "* La casilla solo admite numeros";
            this.lblError.Visible = false;
            // 
            // dgvCuenta
            // 
            this.dgvCuenta.AllowUserToAddRows = false;
            this.dgvCuenta.AllowUserToDeleteRows = false;
            this.dgvCuenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvCuenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuenta.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCuenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuenta.ColumnHeadersHeight = 26;
            this.dgvCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cantidad,
            this.Nombre,
            this.Precio,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCuenta.EnableHeadersVisualStyles = false;
            this.dgvCuenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvCuenta.Location = new System.Drawing.Point(13, 65);
            this.dgvCuenta.Name = "dgvCuenta";
            this.dgvCuenta.RowHeadersVisible = false;
            this.dgvCuenta.RowTemplate.Height = 28;
            this.dgvCuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCuenta.Size = new System.Drawing.Size(674, 508);
            this.dgvCuenta.TabIndex = 15;
            this.dgvCuenta.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvCuenta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvCuenta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCuenta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCuenta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCuenta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCuenta.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCuenta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvCuenta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvCuenta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCuenta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCuenta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCuenta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCuenta.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvCuenta.ThemeStyle.ReadOnly = false;
            this.dgvCuenta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCuenta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCuenta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCuenta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCuenta.ThemeStyle.RowsStyle.Height = 28;
            this.dgvCuenta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvCuenta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCuenta.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuenta_CellValidated);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 1F;
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.Name = "Cantidad";
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 4F;
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 1F;
            this.Precio.HeaderText = "PRECIO";
            this.Precio.Name = "Precio";
            // 
            // Total
            // 
            this.Total.FillWeight = 1F;
            this.Total.HeaderText = "TOTAL";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.Controls.Add(this.lblMesero);
            this.guna2Panel3.Controls.Add(this.btnDesplegarNombre);
            this.guna2Panel3.Controls.Add(this.pnNombreRuc);
            this.guna2Panel3.Controls.Add(this.cmbMesero);
            this.guna2Panel3.Controls.Add(this.txtBusqueda);
            this.guna2Panel3.Controls.Add(this.lsbProducto);
            this.guna2Panel3.Location = new System.Drawing.Point(128, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(317, 691);
            this.guna2Panel3.TabIndex = 0;
            // 
            // lblMesero
            // 
            this.lblMesero.AutoSize = false;
            this.lblMesero.BackColor = System.Drawing.Color.Transparent;
            this.lblMesero.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesero.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMesero.Location = new System.Drawing.Point(3, 73);
            this.lblMesero.Name = "lblMesero";
            this.lblMesero.Size = new System.Drawing.Size(100, 35);
            this.lblMesero.TabIndex = 19;
            this.lblMesero.Text = "MESERO";
            this.lblMesero.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnNombreRuc
            // 
            this.pnNombreRuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNombreRuc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnNombreRuc.Controls.Add(this.txtRUC);
            this.pnNombreRuc.Controls.Add(this.guna2HtmlLabel11);
            this.pnNombreRuc.Controls.Add(this.txtNombre);
            this.pnNombreRuc.Controls.Add(this.guna2HtmlLabel5);
            this.pnNombreRuc.Location = new System.Drawing.Point(3, 32);
            this.pnNombreRuc.Name = "pnNombreRuc";
            this.pnNombreRuc.ShadowDecoration.Parent = this.pnNombreRuc;
            this.pnNombreRuc.Size = new System.Drawing.Size(311, 10);
            this.pnNombreRuc.TabIndex = 12;
            // 
            // txtRUC
            // 
            this.txtRUC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRUC.DefaultText = "";
            this.txtRUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRUC.DisabledState.Parent = this.txtRUC;
            this.txtRUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRUC.FocusedState.Parent = this.txtRUC;
            this.txtRUC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRUC.HoverState.Parent = this.txtRUC;
            this.txtRUC.Location = new System.Drawing.Point(17, 119);
            this.txtRUC.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.PasswordChar = '\0';
            this.txtRUC.PlaceholderText = "";
            this.txtRUC.SelectedText = "";
            this.txtRUC.ShadowDecoration.Parent = this.txtRUC;
            this.txtRUC.Size = new System.Drawing.Size(277, 36);
            this.txtRUC.TabIndex = 30;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel11.IsSelectionEnabled = false;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(17, 97);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(27, 22);
            this.guna2HtmlLabel11.TabIndex = 29;
            this.guna2HtmlLabel11.Text = "RUC";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(17, 49);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(277, 36);
            this.txtNombre.TabIndex = 28;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel5.IsSelectionEnabled = false;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(17, 27);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(52, 22);
            this.guna2HtmlLabel5.TabIndex = 27;
            this.guna2HtmlLabel5.Text = "Nombre";
            // 
            // cmbMesero
            // 
            this.cmbMesero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMesero.BackColor = System.Drawing.Color.Transparent;
            this.cmbMesero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMesero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesero.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMesero.FocusedState.Parent = this.cmbMesero;
            this.cmbMesero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMesero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMesero.FormattingEnabled = true;
            this.cmbMesero.HoverState.Parent = this.cmbMesero;
            this.cmbMesero.ItemHeight = 30;
            this.cmbMesero.ItemsAppearance.Parent = this.cmbMesero;
            this.cmbMesero.Location = new System.Drawing.Point(109, 73);
            this.cmbMesero.Name = "cmbMesero";
            this.cmbMesero.ShadowDecoration.Parent = this.cmbMesero;
            this.cmbMesero.Size = new System.Drawing.Size(205, 36);
            this.cmbMesero.TabIndex = 11;
            // 
            // btnOpciones
            // 
            this.btnOpciones.BorderRadius = 7;
            this.btnOpciones.CheckedState.Parent = this.btnOpciones;
            this.btnOpciones.CustomImages.Parent = this.btnOpciones;
            this.btnOpciones.FillColor = System.Drawing.Color.Transparent;
            this.btnOpciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpciones.ForeColor = System.Drawing.Color.White;
            this.btnOpciones.HoverState.Image = global::VillaSofia.Properties.Resources.trespuntosNegro;
            this.btnOpciones.HoverState.Parent = this.btnOpciones;
            this.btnOpciones.Image = global::VillaSofia.Properties.Resources.trespuntosGris1;
            this.btnOpciones.ImageSize = new System.Drawing.Size(32, 32);
            this.btnOpciones.Location = new System.Drawing.Point(61, 27);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.ShadowDecoration.Parent = this.btnOpciones;
            this.btnOpciones.Size = new System.Drawing.Size(44, 38);
            this.btnOpciones.TabIndex = 12;
            this.btnOpciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BorderRadius = 3;
            this.btnAtras.CheckedState.Parent = this.btnAtras;
            this.btnAtras.CustomImages.Parent = this.btnAtras;
            this.btnAtras.FillColor = System.Drawing.Color.Silver;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.HoverState.Parent = this.btnAtras;
            this.btnAtras.Image = global::VillaSofia.Properties.Resources.flechaIzquierdaBlanca32;
            this.btnAtras.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAtras.Location = new System.Drawing.Point(3, 27);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.ShadowDecoration.Parent = this.btnAtras;
            this.btnAtras.Size = new System.Drawing.Size(55, 38);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderColor = System.Drawing.Color.Transparent;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnEliminar.HoverState.Image = global::VillaSofia.Properties.Resources.equisBlanca32;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Image = global::VillaSofia.Properties.Resources.equis94_148_255Azul32;
            this.btnEliminar.Location = new System.Drawing.Point(10, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(33, 32);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDesplegarNombre
            // 
            this.btnDesplegarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesplegarNombre.CheckedState.Parent = this.btnDesplegarNombre;
            this.btnDesplegarNombre.CustomImages.Parent = this.btnDesplegarNombre;
            this.btnDesplegarNombre.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDesplegarNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDesplegarNombre.ForeColor = System.Drawing.Color.White;
            this.btnDesplegarNombre.HoverState.Parent = this.btnDesplegarNombre;
            this.btnDesplegarNombre.Image = global::VillaSofia.Properties.Resources.abajoWhiteSmoke32;
            this.btnDesplegarNombre.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDesplegarNombre.Location = new System.Drawing.Point(3, 32);
            this.btnDesplegarNombre.Name = "btnDesplegarNombre";
            this.btnDesplegarNombre.ShadowDecoration.Parent = this.btnDesplegarNombre;
            this.btnDesplegarNombre.Size = new System.Drawing.Size(311, 25);
            this.btnDesplegarNombre.TabIndex = 13;
            this.btnDesplegarNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDesplegarNombre.Click += new System.EventHandler(this.btnDesplegarNombre_Click);
            // 
            // CduFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnPrincipal);
            this.Name = "CduFacturacion";
            this.Size = new System.Drawing.Size(1202, 697);
            this.guna2Panel2.ResumeLayout(false);
            this.pnPrincipal.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.pnNombreRuc.ResumeLayout(false);
            this.pnNombreRuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFactura;
        private Guna.UI2.WinForms.Guna2TextBox txtBusqueda;
        private System.Windows.Forms.ListBox lsbProducto;
        private Guna.UI2.WinForms.Guna2Button btnNuevaCuenta;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnAbierta;
        private System.Windows.Forms.TableLayoutPanel pnPrincipal;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblError;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.FlowLayoutPanel pnBotonesFacturas;
        private Guna.UI2.WinForms.Guna2CheckBox chbMostrarTodas;
        private Guna.UI2.WinForms.Guna2Button btnOpciones;
        private Guna.UI2.WinForms.Guna2Button btnAtras;
        private Guna.UI2.WinForms.Guna2Panel pnNombreRuc;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMesero;
        private Guna.UI2.WinForms.Guna2TextBox txtRUC;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btnDesplegarNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMesero;
    }
}
