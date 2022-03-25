namespace VillaSofia
{
    partial class CduMenuPrincipal
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
            this.btnCaja = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductos = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvConjunto = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConjunto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCaja
            // 
            this.btnCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCaja.Animated = true;
            this.btnCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaja.CheckedState.Parent = this.btnCaja;
            this.btnCaja.CustomImages.Parent = this.btnCaja;
            this.btnCaja.FillColor = System.Drawing.Color.Transparent;
            this.btnCaja.Font = new System.Drawing.Font("Tw Cen MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.ForeColor = System.Drawing.Color.Black;
            this.btnCaja.HoverState.Parent = this.btnCaja;
            this.btnCaja.Image = global::VillaSofia.Properties.Resources.cajaregistradora;
            this.btnCaja.ImageOffset = new System.Drawing.Point(0, -20);
            this.btnCaja.ImageSize = new System.Drawing.Size(250, 250);
            this.btnCaja.Location = new System.Drawing.Point(168, 140);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.ShadowDecoration.Parent = this.btnCaja;
            this.btnCaja.Size = new System.Drawing.Size(352, 453);
            this.btnCaja.TabIndex = 3;
            this.btnCaja.Text = "CAJA";
            this.btnCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCaja.TextOffset = new System.Drawing.Point(80, 160);
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProductos.Animated = true;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.CheckedState.Parent = this.btnProductos;
            this.btnProductos.CustomImages.Parent = this.btnProductos;
            this.btnProductos.FillColor = System.Drawing.Color.Transparent;
            this.btnProductos.Font = new System.Drawing.Font("Tw Cen MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.HoverState.Parent = this.btnProductos;
            this.btnProductos.ImageSize = new System.Drawing.Size(200, 200);
            this.btnProductos.Location = new System.Drawing.Point(546, 65);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.ShadowDecoration.Parent = this.btnProductos;
            this.btnProductos.Size = new System.Drawing.Size(408, 131);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(27, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(241, 112);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cayba";
            // 
            // dgvConjunto
            // 
            this.dgvConjunto.AllowUserToAddRows = false;
            this.dgvConjunto.AllowUserToDeleteRows = false;
            this.dgvConjunto.AllowUserToResizeColumns = false;
            this.dgvConjunto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvConjunto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConjunto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvConjunto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConjunto.BackgroundColor = System.Drawing.Color.White;
            this.dgvConjunto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConjunto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConjunto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConjunto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConjunto.ColumnHeadersHeight = 20;
            this.dgvConjunto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fecha,
            this.estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConjunto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConjunto.EnableHeadersVisualStyles = false;
            this.dgvConjunto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvConjunto.Location = new System.Drawing.Point(546, 302);
            this.dgvConjunto.MultiSelect = false;
            this.dgvConjunto.Name = "dgvConjunto";
            this.dgvConjunto.ReadOnly = true;
            this.dgvConjunto.RowHeadersVisible = false;
            this.dgvConjunto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConjunto.Size = new System.Drawing.Size(497, 274);
            this.dgvConjunto.TabIndex = 7;
            this.dgvConjunto.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvConjunto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvConjunto.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvConjunto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvConjunto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvConjunto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvConjunto.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvConjunto.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvConjunto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvConjunto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConjunto.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvConjunto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvConjunto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvConjunto.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvConjunto.ThemeStyle.ReadOnly = true;
            this.dgvConjunto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvConjunto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConjunto.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvConjunto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvConjunto.ThemeStyle.RowsStyle.Height = 22;
            this.dgvConjunto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvConjunto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvConjunto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConjunto_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "CONJUNTO";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // CduMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::VillaSofia.Properties.Resources.fondogris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvConjunto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnProductos);
            this.DoubleBuffered = true;
            this.Name = "CduMenuPrincipal";
            this.Size = new System.Drawing.Size(1221, 678);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConjunto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnProductos;
        private Guna.UI2.WinForms.Guna2Button btnCaja;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvConjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}
