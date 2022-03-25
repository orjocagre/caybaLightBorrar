namespace VillaSofia
{
    partial class FrmMovimientosCaja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnSale = new Guna.UI2.WinForms.Guna2Button();
            this.btnEntra = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMonto = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvCaja = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnPrincipal.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.txtDescripcion);
            this.pnPrincipal.Controls.Add(this.guna2Panel2);
            this.pnPrincipal.Controls.Add(this.btnSale);
            this.pnPrincipal.Controls.Add(this.btnEntra);
            this.pnPrincipal.Controls.Add(this.guna2HtmlLabel1);
            this.pnPrincipal.Controls.Add(this.txtMonto);
            this.pnPrincipal.Controls.Add(this.guna2HtmlLabel5);
            this.pnPrincipal.Controls.Add(this.dgvCaja);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.FillColor = System.Drawing.Color.White;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.ShadowDecoration.Parent = this.pnPrincipal;
            this.pnPrincipal.Size = new System.Drawing.Size(597, 649);
            this.pnPrincipal.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.DisabledState.Parent = this.txtDescripcion;
            this.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.FocusedState.Parent = this.txtDescripcion;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.HoverState.Parent = this.txtDescripcion;
            this.txtDescripcion.Location = new System.Drawing.Point(12, 113);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.ShadowDecoration.Parent = this.txtDescripcion;
            this.txtDescripcion.Size = new System.Drawing.Size(417, 37);
            this.txtDescripcion.TabIndex = 30;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.btnImprimir);
            this.guna2Panel2.Controls.Add(this.btnEliminar);
            this.guna2Panel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(542, 181);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(52, 98);
            this.guna2Panel2.TabIndex = 29;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BorderColor = System.Drawing.Color.Transparent;
            this.btnImprimir.CheckedState.Parent = this.btnImprimir;
            this.btnImprimir.CustomImages.Parent = this.btnImprimir;
            this.btnImprimir.FillColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnImprimir.HoverState.Image = global::VillaSofia.Properties.Resources.imprimir2Blanco32;
            this.btnImprimir.HoverState.Parent = this.btnImprimir;
            this.btnImprimir.Image = global::VillaSofia.Properties.Resources.imprimir2Azul32;
            this.btnImprimir.Location = new System.Drawing.Point(10, 51);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ShadowDecoration.Parent = this.btnImprimir;
            this.btnImprimir.Size = new System.Drawing.Size(33, 32);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // btnSale
            // 
            this.btnSale.BorderRadius = 3;
            this.btnSale.CheckedState.Parent = this.btnSale;
            this.btnSale.CustomImages.Parent = this.btnSale;
            this.btnSale.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.HoverState.Parent = this.btnSale;
            this.btnSale.Location = new System.Drawing.Point(477, 89);
            this.btnSale.Name = "btnSale";
            this.btnSale.ShadowDecoration.Parent = this.btnSale;
            this.btnSale.Size = new System.Drawing.Size(108, 67);
            this.btnSale.TabIndex = 27;
            this.btnSale.Text = "SALE";
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnEntra
            // 
            this.btnEntra.BorderRadius = 3;
            this.btnEntra.CheckedState.Parent = this.btnEntra;
            this.btnEntra.CustomImages.Parent = this.btnEntra;
            this.btnEntra.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntra.ForeColor = System.Drawing.Color.White;
            this.btnEntra.HoverState.Parent = this.btnEntra;
            this.btnEntra.Location = new System.Drawing.Point(477, 12);
            this.btnEntra.Name = "btnEntra";
            this.btnEntra.ShadowDecoration.Parent = this.btnEntra;
            this.btnEntra.Size = new System.Drawing.Size(108, 67);
            this.btnEntra.TabIndex = 26;
            this.btnEntra.Text = "ENTRA";
            this.btnEntra.Click += new System.EventHandler(this.btnEntra_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 82);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(91, 26);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Descripción";
            // 
            // txtMonto
            // 
            this.txtMonto.AutoSize = true;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.DefaultText = "";
            this.txtMonto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMonto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.DisabledState.Parent = this.txtMonto;
            this.txtMonto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.FocusedState.Parent = this.txtMonto;
            this.txtMonto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.HoverState.Parent = this.txtMonto;
            this.txtMonto.Location = new System.Drawing.Point(12, 41);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.PlaceholderText = "";
            this.txtMonto.SelectedText = "";
            this.txtMonto.ShadowDecoration.Parent = this.txtMonto;
            this.txtMonto.Size = new System.Drawing.Size(213, 37);
            this.txtMonto.TabIndex = 23;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel5.IsSelectionEnabled = false;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(52, 26);
            this.guna2HtmlLabel5.TabIndex = 17;
            this.guna2HtmlLabel5.Text = "Monto";
            // 
            // dgvCaja
            // 
            this.dgvCaja.AllowUserToAddRows = false;
            this.dgvCaja.AllowUserToDeleteRows = false;
            this.dgvCaja.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvCaja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaja.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCaja.ColumnHeadersHeight = 26;
            this.dgvCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Monto,
            this.descripcion,
            this.hora});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaja.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCaja.EnableHeadersVisualStyles = false;
            this.dgvCaja.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvCaja.Location = new System.Drawing.Point(12, 181);
            this.dgvCaja.MultiSelect = false;
            this.dgvCaja.Name = "dgvCaja";
            this.dgvCaja.ReadOnly = true;
            this.dgvCaja.RowHeadersVisible = false;
            this.dgvCaja.RowTemplate.Height = 28;
            this.dgvCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaja.Size = new System.Drawing.Size(524, 441);
            this.dgvCaja.TabIndex = 16;
            this.dgvCaja.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvCaja.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvCaja.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCaja.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCaja.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCaja.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCaja.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCaja.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvCaja.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvCaja.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCaja.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCaja.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCaja.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCaja.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvCaja.ThemeStyle.ReadOnly = true;
            this.dgvCaja.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCaja.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCaja.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCaja.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCaja.ThemeStyle.RowsStyle.Height = 28;
            this.dgvCaja.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvCaja.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Monto
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle7;
            this.Monto.FillWeight = 1F;
            this.Monto.HeaderText = "MONTO";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.FillWeight = 4F;
            this.descripcion.HeaderText = "DESCRIPCIÓN";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.FillWeight = 1.5F;
            this.hora.HeaderText = "HORA";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // FrmMovimientosCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 649);
            this.Controls.Add(this.pnPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMovimientosCaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos Caja";
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnPrincipal;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCaja;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        public Guna.UI2.WinForms.Guna2TextBox txtMonto;
        private Guna.UI2.WinForms.Guna2Button btnEntra;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSale;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnImprimir;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        public Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
    }
}