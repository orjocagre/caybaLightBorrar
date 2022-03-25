namespace VillaSofia
{
    partial class FrmClasificacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTipoProducto = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtClasificacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAgregarEditar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAbajo = new Guna.UI2.WinForms.Guna2Button();
            this.btnArriba = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProducto)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnCancelar);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnGuardar);
            this.guna2CustomGradientPanel1.Controls.Add(this.dgvTipoProducto);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtClasificacion);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblAgregarEditar);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(437, 372);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(288, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(137, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(288, 41);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(137, 36);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvTipoProducto
            // 
            this.dgvTipoProducto.AllowUserToAddRows = false;
            this.dgvTipoProducto.AllowUserToDeleteRows = false;
            this.dgvTipoProducto.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTipoProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvTipoProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoProducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipoProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipoProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTipoProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvTipoProducto.ColumnHeadersHeight = 26;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoProducto.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvTipoProducto.EnableHeadersVisualStyles = false;
            this.dgvTipoProducto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvTipoProducto.Location = new System.Drawing.Point(12, 93);
            this.dgvTipoProducto.MultiSelect = false;
            this.dgvTipoProducto.Name = "dgvTipoProducto";
            this.dgvTipoProducto.ReadOnly = true;
            this.dgvTipoProducto.RowHeadersVisible = false;
            this.dgvTipoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoProducto.Size = new System.Drawing.Size(355, 266);
            this.dgvTipoProducto.TabIndex = 9;
            this.dgvTipoProducto.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvTipoProducto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvTipoProducto.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTipoProducto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTipoProducto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvTipoProducto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTipoProducto.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTipoProducto.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvTipoProducto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvTipoProducto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTipoProducto.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTipoProducto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTipoProducto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTipoProducto.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvTipoProducto.ThemeStyle.ReadOnly = true;
            this.dgvTipoProducto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTipoProducto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTipoProducto.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTipoProducto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTipoProducto.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTipoProducto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvTipoProducto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTipoProducto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTipoProducto_CellMouseDoubleClick);
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClasificacion.DefaultText = "";
            this.txtClasificacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClasificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClasificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClasificacion.DisabledState.Parent = this.txtClasificacion;
            this.txtClasificacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClasificacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClasificacion.FocusedState.Parent = this.txtClasificacion;
            this.txtClasificacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtClasificacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClasificacion.HoverState.Parent = this.txtClasificacion;
            this.txtClasificacion.Location = new System.Drawing.Point(16, 41);
            this.txtClasificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.PasswordChar = '\0';
            this.txtClasificacion.PlaceholderText = "";
            this.txtClasificacion.SelectedText = "";
            this.txtClasificacion.ShadowDecoration.Parent = this.txtClasificacion;
            this.txtClasificacion.Size = new System.Drawing.Size(252, 36);
            this.txtClasificacion.TabIndex = 1;
            // 
            // lblAgregarEditar
            // 
            this.lblAgregarEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarEditar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAgregarEditar.Location = new System.Drawing.Point(16, 12);
            this.lblAgregarEditar.Name = "lblAgregarEditar";
            this.lblAgregarEditar.Size = new System.Drawing.Size(61, 23);
            this.lblAgregarEditar.TabIndex = 0;
            this.lblAgregarEditar.Text = "Nombre";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.btnAbajo);
            this.guna2Panel1.Controls.Add(this.btnArriba);
            this.guna2Panel1.Controls.Add(this.btnAgregar);
            this.guna2Panel1.Controls.Add(this.btnEliminar);
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(373, 93);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(52, 168);
            this.guna2Panel1.TabIndex = 12;
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
            this.btnAbajo.Location = new System.Drawing.Point(10, 127);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.ShadowDecoration.Parent = this.btnAbajo;
            this.btnAbajo.Size = new System.Drawing.Size(33, 32);
            this.btnAbajo.TabIndex = 10;
            this.btnAbajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
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
            this.btnArriba.Location = new System.Drawing.Point(10, 89);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.ShadowDecoration.Parent = this.btnArriba;
            this.btnArriba.Size = new System.Drawing.Size(33, 32);
            this.btnArriba.TabIndex = 9;
            this.btnArriba.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderColor = System.Drawing.Color.Transparent;
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.CustomImages.Parent = this.btnAgregar;
            this.btnAgregar.FillColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnAgregar.HoverState.Image = global::VillaSofia.Properties.Resources.masBlanco32;
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Image = global::VillaSofia.Properties.Resources.mas94_148_255Azul32;
            this.btnAgregar.Location = new System.Drawing.Point(10, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(33, 32);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // FrmClasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 372);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "FrmClasificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClasificacion";
            this.Load += new System.EventHandler(this.FrmClasificacion_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProducto)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTipoProducto;
        private Guna.UI2.WinForms.Guna2TextBox txtClasificacion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAgregarEditar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAbajo;
        private Guna.UI2.WinForms.Guna2Button btnArriba;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
    }
}