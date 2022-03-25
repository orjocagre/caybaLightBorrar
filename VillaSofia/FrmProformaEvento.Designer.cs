namespace VillaSofia
{
    partial class FrmProformaEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAbajo = new Guna.UI2.WinForms.Guna2Button();
            this.btnArriba = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lblError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvProforma = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvMenu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProforma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.guna2VSeparator1);
            this.guna2Panel1.Controls.Add(this.lblError);
            this.guna2Panel1.Controls.Add(this.dgvProforma);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.txtTotal);
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Controls.Add(this.dgvMenu);
            this.guna2Panel1.Controls.Add(this.btnGuardar);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1137, 629);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.btnAbajo);
            this.guna2Panel2.Controls.Add(this.btnArriba);
            this.guna2Panel2.Controls.Add(this.btnEliminar);
            this.guna2Panel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(1075, 102);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(52, 132);
            this.guna2Panel2.TabIndex = 10;
            // 
            // btnAbajo
            // 
            this.btnAbajo.BorderColor = System.Drawing.Color.Transparent;
            this.btnAbajo.CheckedState.Parent = this.btnAbajo;
            this.btnAbajo.CustomImages.Parent = this.btnAbajo;
            this.btnAbajo.FillColor = System.Drawing.Color.Transparent;
            this.btnAbajo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbajo.ForeColor = System.Drawing.Color.White;
            this.btnAbajo.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnAbajo.HoverState.Image = global::VillaSofia.Properties.Resources.abajoBlanco32;
            this.btnAbajo.HoverState.Parent = this.btnAbajo;
            this.btnAbajo.Image = global::VillaSofia.Properties.Resources.abajo94_148_255Azul32;
            this.btnAbajo.Location = new System.Drawing.Point(10, 89);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.ShadowDecoration.Parent = this.btnAbajo;
            this.btnAbajo.Size = new System.Drawing.Size(33, 32);
            this.btnAbajo.TabIndex = 10;
            this.btnAbajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnArriba
            // 
            this.btnArriba.BorderColor = System.Drawing.Color.Transparent;
            this.btnArriba.CheckedState.Parent = this.btnArriba;
            this.btnArriba.CustomImages.Parent = this.btnArriba;
            this.btnArriba.FillColor = System.Drawing.Color.Transparent;
            this.btnArriba.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnArriba.ForeColor = System.Drawing.Color.White;
            this.btnArriba.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnArriba.HoverState.Image = global::VillaSofia.Properties.Resources.arribaBlanco32;
            this.btnArriba.HoverState.Parent = this.btnArriba;
            this.btnArriba.Image = global::VillaSofia.Properties.Resources.arriba94_148_255Azul32;
            this.btnArriba.Location = new System.Drawing.Point(10, 51);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.ShadowDecoration.Parent = this.btnArriba;
            this.btnArriba.Size = new System.Drawing.Size(33, 32);
            this.btnArriba.TabIndex = 9;
            this.btnArriba.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(450, 28);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 580);
            this.guna2VSeparator1.TabIndex = 9;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(501, 581);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(202, 21);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "* La casilla solo admite numeros";
            this.lblError.Visible = false;
            // 
            // dgvProforma
            // 
            this.dgvProforma.AllowUserToAddRows = false;
            this.dgvProforma.AllowUserToDeleteRows = false;
            this.dgvProforma.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvProforma.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProforma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProforma.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProforma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProforma.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProforma.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProforma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProforma.ColumnHeadersHeight = 26;
            this.dgvProforma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvProforma.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProforma.EnableHeadersVisualStyles = false;
            this.dgvProforma.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvProforma.Location = new System.Drawing.Point(501, 102);
            this.dgvProforma.Name = "dgvProforma";
            this.dgvProforma.RowHeadersVisible = false;
            this.dgvProforma.RowTemplate.Height = 28;
            this.dgvProforma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProforma.Size = new System.Drawing.Size(568, 473);
            this.dgvProforma.TabIndex = 7;
            this.dgvProforma.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvProforma.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvProforma.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProforma.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProforma.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProforma.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProforma.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProforma.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvProforma.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvProforma.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProforma.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProforma.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProforma.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProforma.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvProforma.ThemeStyle.ReadOnly = false;
            this.dgvProforma.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProforma.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProforma.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProforma.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProforma.ThemeStyle.RowsStyle.Height = 28;
            this.dgvProforma.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvProforma.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProforma.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProforma_CellValidated);
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
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(898, 587);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(68, 30);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.Text = "TOTAL";
            // 
            // txtTotal
            // 
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
            this.txtTotal.Location = new System.Drawing.Point(972, 581);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(97, 36);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(12, 60);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(397, 36);
            this.guna2TextBox1.TabIndex = 5;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMenu.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMenu.EnableHeadersVisualStyles = false;
            this.dgvMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvMenu.Location = new System.Drawing.Point(12, 102);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.RowTemplate.Height = 28;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(397, 515);
            this.dgvMenu.TabIndex = 3;
            this.dgvMenu.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvMenu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvMenu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMenu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMenu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMenu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMenu.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMenu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvMenu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvMenu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMenu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMenu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMenu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMenu.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvMenu.ThemeStyle.ReadOnly = true;
            this.dgvMenu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMenu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMenu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMenu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMenu.ThemeStyle.RowsStyle.Height = 28;
            this.dgvMenu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvMenu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMenu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellDoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.Font = new System.Drawing.Font("Tw Cen MT", 18F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(968, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(159, 69);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tw Cen MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(501, 28);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(311, 76);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "PROFORMA";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(123, 24);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(135, 30);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Menu Eventos";
            // 
            // FrmProformaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 629);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FrmProformaEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proforma Evento";
            this.Deactivate += new System.EventHandler(this.FrmProformaEvento_Deactivate);
            this.Load += new System.EventHandler(this.FrmProformaEvento_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProforma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMenu;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProforma;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnAbajo;
        private Guna.UI2.WinForms.Guna2Button btnArriba;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
    }
}