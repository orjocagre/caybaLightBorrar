namespace VillaSofia
{
    partial class FrmAgregarInsumo
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
            this.components = new System.ComponentModel.Container();
            this.pnPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbTamano = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbPesoVacia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbPesoLlena = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPesoVacia = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPesoLlena = new System.Windows.Forms.TextBox();
            this.lblPesollena = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbtMililitro = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtUnidad = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.pnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.btnGuardar);
            this.pnPrincipal.Controls.Add(this.guna2HtmlLabel2);
            this.pnPrincipal.Controls.Add(this.cmbTamano);
            this.pnPrincipal.Controls.Add(this.txtTamano);
            this.pnPrincipal.Controls.Add(this.guna2HtmlLabel4);
            this.pnPrincipal.Controls.Add(this.cmbPesoVacia);
            this.pnPrincipal.Controls.Add(this.cmbPesoLlena);
            this.pnPrincipal.Controls.Add(this.txtPesoVacia);
            this.pnPrincipal.Controls.Add(this.guna2HtmlLabel3);
            this.pnPrincipal.Controls.Add(this.txtPesoLlena);
            this.pnPrincipal.Controls.Add(this.lblPesollena);
            this.pnPrincipal.Controls.Add(this.rbtMililitro);
            this.pnPrincipal.Controls.Add(this.rbtUnidad);
            this.pnPrincipal.Controls.Add(this.txtNombre);
            this.pnPrincipal.Controls.Add(this.guna2HtmlLabel1);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.FillColor = System.Drawing.Color.White;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.ShadowDecoration.Parent = this.pnPrincipal;
            this.pnPrincipal.Size = new System.Drawing.Size(450, 156);
            this.pnPrincipal.TabIndex = 1;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(19, 60);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(34, 23);
            this.guna2HtmlLabel2.TabIndex = 26;
            this.guna2HtmlLabel2.Text = "U.M.";
            // 
            // cmbTamano
            // 
            this.cmbTamano.BackColor = System.Drawing.Color.Transparent;
            this.cmbTamano.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamano.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTamano.FocusedState.Parent = this.cmbTamano;
            this.cmbTamano.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTamano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTamano.FormattingEnabled = true;
            this.cmbTamano.HoverState.Parent = this.cmbTamano;
            this.cmbTamano.ItemHeight = 30;
            this.cmbTamano.Items.AddRange(new object[] {
            "mililitos",
            "litros"});
            this.cmbTamano.ItemsAppearance.Parent = this.cmbTamano;
            this.cmbTamano.Location = new System.Drawing.Point(249, 202);
            this.cmbTamano.Name = "cmbTamano";
            this.cmbTamano.ShadowDecoration.Parent = this.cmbTamano;
            this.cmbTamano.Size = new System.Drawing.Size(96, 36);
            this.cmbTamano.TabIndex = 25;
            // 
            // txtTamano
            // 
            this.txtTamano.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamano.Location = new System.Drawing.Point(99, 202);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(130, 33);
            this.txtTamano.TabIndex = 24;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(19, 208);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(59, 23);
            this.guna2HtmlLabel4.TabIndex = 23;
            this.guna2HtmlLabel4.Text = "Tamaño";
            // 
            // cmbPesoVacia
            // 
            this.cmbPesoVacia.BackColor = System.Drawing.Color.Transparent;
            this.cmbPesoVacia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPesoVacia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesoVacia.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPesoVacia.FocusedState.Parent = this.cmbPesoVacia;
            this.cmbPesoVacia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPesoVacia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPesoVacia.FormattingEnabled = true;
            this.cmbPesoVacia.HoverState.Parent = this.cmbPesoVacia;
            this.cmbPesoVacia.ItemHeight = 30;
            this.cmbPesoVacia.Items.AddRange(new object[] {
            "gramos",
            "kilos",
            "libras"});
            this.cmbPesoVacia.ItemsAppearance.Parent = this.cmbPesoVacia;
            this.cmbPesoVacia.Location = new System.Drawing.Point(249, 157);
            this.cmbPesoVacia.Name = "cmbPesoVacia";
            this.cmbPesoVacia.ShadowDecoration.Parent = this.cmbPesoVacia;
            this.cmbPesoVacia.Size = new System.Drawing.Size(96, 36);
            this.cmbPesoVacia.TabIndex = 22;
            // 
            // cmbPesoLlena
            // 
            this.cmbPesoLlena.BackColor = System.Drawing.Color.Transparent;
            this.cmbPesoLlena.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPesoLlena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesoLlena.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPesoLlena.FocusedState.Parent = this.cmbPesoLlena;
            this.cmbPesoLlena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPesoLlena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPesoLlena.FormattingEnabled = true;
            this.cmbPesoLlena.HoverState.Parent = this.cmbPesoLlena;
            this.cmbPesoLlena.ItemHeight = 30;
            this.cmbPesoLlena.Items.AddRange(new object[] {
            "gramos",
            "kilos",
            "libras"});
            this.cmbPesoLlena.ItemsAppearance.Parent = this.cmbPesoLlena;
            this.cmbPesoLlena.Location = new System.Drawing.Point(249, 110);
            this.cmbPesoLlena.Name = "cmbPesoLlena";
            this.cmbPesoLlena.ShadowDecoration.Parent = this.cmbPesoLlena;
            this.cmbPesoLlena.Size = new System.Drawing.Size(96, 36);
            this.cmbPesoLlena.TabIndex = 21;
            this.cmbPesoLlena.Visible = false;
            // 
            // txtPesoVacia
            // 
            this.txtPesoVacia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoVacia.Location = new System.Drawing.Point(99, 157);
            this.txtPesoVacia.Name = "txtPesoVacia";
            this.txtPesoVacia.Size = new System.Drawing.Size(130, 33);
            this.txtPesoVacia.TabIndex = 20;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(19, 163);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(75, 23);
            this.guna2HtmlLabel3.TabIndex = 19;
            this.guna2HtmlLabel3.Text = "Peso vacia";
            // 
            // txtPesoLlena
            // 
            this.txtPesoLlena.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoLlena.Location = new System.Drawing.Point(99, 110);
            this.txtPesoLlena.Name = "txtPesoLlena";
            this.txtPesoLlena.Size = new System.Drawing.Size(130, 33);
            this.txtPesoLlena.TabIndex = 18;
            this.txtPesoLlena.Visible = false;
            // 
            // lblPesollena
            // 
            this.lblPesollena.BackColor = System.Drawing.Color.Transparent;
            this.lblPesollena.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPesollena.Location = new System.Drawing.Point(19, 116);
            this.lblPesollena.Name = "lblPesollena";
            this.lblPesollena.Size = new System.Drawing.Size(73, 23);
            this.lblPesollena.TabIndex = 17;
            this.lblPesollena.Text = "Peso llena";
            this.lblPesollena.Visible = false;
            // 
            // rbtMililitro
            // 
            this.rbtMililitro.AutoSize = true;
            this.rbtMililitro.BackColor = System.Drawing.Color.White;
            this.rbtMililitro.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtMililitro.CheckedState.BorderThickness = 0;
            this.rbtMililitro.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtMililitro.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtMililitro.CheckedState.InnerOffset = -4;
            this.rbtMililitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMililitro.Location = new System.Drawing.Point(184, 60);
            this.rbtMililitro.Name = "rbtMililitro";
            this.rbtMililitro.Size = new System.Drawing.Size(74, 24);
            this.rbtMililitro.TabIndex = 16;
            this.rbtMililitro.Text = "Mililitro";
            this.rbtMililitro.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtMililitro.UncheckedState.BorderThickness = 2;
            this.rbtMililitro.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtMililitro.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtMililitro.UseVisualStyleBackColor = false;
            this.rbtMililitro.CheckedChanged += new System.EventHandler(this.rbtMililitro_CheckedChanged);
            // 
            // rbtUnidad
            // 
            this.rbtUnidad.AutoSize = true;
            this.rbtUnidad.BackColor = System.Drawing.Color.White;
            this.rbtUnidad.Checked = true;
            this.rbtUnidad.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtUnidad.CheckedState.BorderThickness = 0;
            this.rbtUnidad.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtUnidad.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtUnidad.CheckedState.InnerOffset = -4;
            this.rbtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtUnidad.Location = new System.Drawing.Point(99, 60);
            this.rbtUnidad.Name = "rbtUnidad";
            this.rbtUnidad.Size = new System.Drawing.Size(78, 24);
            this.rbtUnidad.TabIndex = 15;
            this.rbtUnidad.TabStop = true;
            this.rbtUnidad.Text = "Unidad";
            this.rbtUnidad.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtUnidad.UncheckedState.BorderThickness = 2;
            this.rbtUnidad.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtUnidad.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtUnidad.UseVisualStyleBackColor = false;
            this.rbtUnidad.CheckedChanged += new System.EventHandler(this.rbtUnidad_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(335, 105);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(98, 36);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombre.Location = new System.Drawing.Point(99, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(334, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(19, 18);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(61, 23);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Nombre";
            // 
            // tempo
            // 
            this.tempo.Interval = 10;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // FrmAgregarInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 156);
            this.Controls.Add(this.pnPrincipal);
            this.MaximumSize = new System.Drawing.Size(466, 348);
            this.MinimumSize = new System.Drawing.Size(466, 195);
            this.Name = "FrmAgregarInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarInsumo";
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnPrincipal;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTamano;
        private System.Windows.Forms.TextBox txtTamano;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPesoVacia;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPesoLlena;
        private System.Windows.Forms.TextBox txtPesoVacia;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.TextBox txtPesoLlena;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPesollena;
        private Guna.UI2.WinForms.Guna2RadioButton rbtMililitro;
        private Guna.UI2.WinForms.Guna2RadioButton rbtUnidad;
        private System.Windows.Forms.Timer tempo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}