namespace VillaSofia
{
    partial class FrmAgregarProducto
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
            this.txtSinonimos = new System.Windows.Forms.TextBox();
            this.chbVincular = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnMasOpciones = new Guna.UI2.WinForms.Guna2Button();
            this.btnVincularDirecto = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnClasificacion = new Guna.UI2.WinForms.Guna2Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbTipoProducto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblClasificacion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.tempoSinonimos = new System.Windows.Forms.Timer(this.components);
            this.btnSinonimos = new Guna.UI2.WinForms.Guna2Button();
            this.pnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.btnSinonimos);
            this.pnPrincipal.Controls.Add(this.txtSinonimos);
            this.pnPrincipal.Controls.Add(this.chbVincular);
            this.pnPrincipal.Controls.Add(this.btnMasOpciones);
            this.pnPrincipal.Controls.Add(this.btnVincularDirecto);
            this.pnPrincipal.Controls.Add(this.btnCancelar);
            this.pnPrincipal.Controls.Add(this.btnGuardar);
            this.pnPrincipal.Controls.Add(this.btnClasificacion);
            this.pnPrincipal.Controls.Add(this.txtNombre);
            this.pnPrincipal.Controls.Add(this.cmbTipoProducto);
            this.pnPrincipal.Controls.Add(this.guna2HtmlLabel1);
            this.pnPrincipal.Controls.Add(this.txtPrecio);
            this.pnPrincipal.Controls.Add(this.lblPrecio);
            this.pnPrincipal.Controls.Add(this.lblClasificacion);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.FillColor = System.Drawing.Color.White;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.ShadowDecoration.Parent = this.pnPrincipal;
            this.pnPrincipal.Size = new System.Drawing.Size(465, 226);
            this.pnPrincipal.TabIndex = 0;
            // 
            // txtSinonimos
            // 
            this.txtSinonimos.AcceptsReturn = true;
            this.txtSinonimos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSinonimos.Location = new System.Drawing.Point(19, 83);
            this.txtSinonimos.Multiline = true;
            this.txtSinonimos.Name = "txtSinonimos";
            this.txtSinonimos.Size = new System.Drawing.Size(430, 0);
            this.txtSinonimos.TabIndex = 15;
            // 
            // chbVincular
            // 
            this.chbVincular.AutoSize = true;
            this.chbVincular.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbVincular.CheckedState.BorderRadius = 2;
            this.chbVincular.CheckedState.BorderThickness = 0;
            this.chbVincular.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbVincular.Enabled = false;
            this.chbVincular.Location = new System.Drawing.Point(19, 198);
            this.chbVincular.Name = "chbVincular";
            this.chbVincular.Size = new System.Drawing.Size(134, 17);
            this.chbVincular.TabIndex = 14;
            this.chbVincular.Text = "Vincular con Inv. Barra";
            this.chbVincular.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbVincular.UncheckedState.BorderRadius = 2;
            this.chbVincular.UncheckedState.BorderThickness = 0;
            this.chbVincular.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbVincular.UseVisualStyleBackColor = true;
            this.chbVincular.CheckedChanged += new System.EventHandler(this.chbVincular_CheckedChanged);
            // 
            // btnMasOpciones
            // 
            this.btnMasOpciones.CheckedState.Parent = this.btnMasOpciones;
            this.btnMasOpciones.CustomImages.Parent = this.btnMasOpciones;
            this.btnMasOpciones.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMasOpciones.ForeColor = System.Drawing.Color.White;
            this.btnMasOpciones.HoverState.Parent = this.btnMasOpciones;
            this.btnMasOpciones.Location = new System.Drawing.Point(19, 274);
            this.btnMasOpciones.Name = "btnMasOpciones";
            this.btnMasOpciones.ShadowDecoration.Parent = this.btnMasOpciones;
            this.btnMasOpciones.Size = new System.Drawing.Size(430, 36);
            this.btnMasOpciones.TabIndex = 13;
            this.btnMasOpciones.Text = "Mas opciones";
            this.btnMasOpciones.Click += new System.EventHandler(this.btnMasOpciones_Click);
            // 
            // btnVincularDirecto
            // 
            this.btnVincularDirecto.CheckedState.Parent = this.btnVincularDirecto;
            this.btnVincularDirecto.CustomImages.Parent = this.btnVincularDirecto;
            this.btnVincularDirecto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVincularDirecto.ForeColor = System.Drawing.Color.White;
            this.btnVincularDirecto.HoverState.Parent = this.btnVincularDirecto;
            this.btnVincularDirecto.Location = new System.Drawing.Point(18, 232);
            this.btnVincularDirecto.Name = "btnVincularDirecto";
            this.btnVincularDirecto.ShadowDecoration.Parent = this.btnVincularDirecto;
            this.btnVincularDirecto.Size = new System.Drawing.Size(430, 36);
            this.btnVincularDirecto.TabIndex = 12;
            this.btnVincularDirecto.Text = "Agregar y vincular como \'Coca cola\'";
            this.btnVincularDirecto.Click += new System.EventHandler(this.btnVincularDirecto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(246, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(98, 36);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(350, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(98, 36);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnClasificacion
            // 
            this.btnClasificacion.CheckedState.Parent = this.btnClasificacion;
            this.btnClasificacion.CustomImages.Parent = this.btnClasificacion;
            this.btnClasificacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasificacion.ForeColor = System.Drawing.Color.White;
            this.btnClasificacion.HoverState.Parent = this.btnClasificacion;
            this.btnClasificacion.Location = new System.Drawing.Point(260, 125);
            this.btnClasificacion.Name = "btnClasificacion";
            this.btnClasificacion.ShadowDecoration.Parent = this.btnClasificacion;
            this.btnClasificacion.Size = new System.Drawing.Size(37, 36);
            this.btnClasificacion.TabIndex = 8;
            this.btnClasificacion.Text = "+";
            this.btnClasificacion.Click += new System.EventHandler(this.btnClasificacion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombre.Location = new System.Drawing.Point(114, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(334, 29);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProducto.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipoProducto.FocusedState.Parent = this.cmbTipoProducto;
            this.cmbTipoProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.HoverState.Parent = this.cmbTipoProducto;
            this.cmbTipoProducto.ItemHeight = 30;
            this.cmbTipoProducto.ItemsAppearance.Parent = this.cmbTipoProducto;
            this.cmbTipoProducto.Location = new System.Drawing.Point(114, 125);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.ShadowDecoration.Parent = this.cmbTipoProducto;
            this.cmbTipoProducto.Size = new System.Drawing.Size(140, 36);
            this.cmbTipoProducto.TabIndex = 5;
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
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPrecio.Location = new System.Drawing.Point(114, 90);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 29);
            this.txtPrecio.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPrecio.Location = new System.Drawing.Point(19, 96);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 23);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblClasificacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblClasificacion.Location = new System.Drawing.Point(19, 138);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(89, 23);
            this.lblClasificacion.TabIndex = 2;
            this.lblClasificacion.Text = "Clasificación";
            // 
            // tempo
            // 
            this.tempo.Interval = 10;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // tempoSinonimos
            // 
            this.tempoSinonimos.Interval = 10;
            this.tempoSinonimos.Tick += new System.EventHandler(this.tempoSinonimos_Tick);
            // 
            // btnSinonimos
            // 
            this.btnSinonimos.BackColor = System.Drawing.Color.Transparent;
            this.btnSinonimos.CheckedState.Parent = this.btnSinonimos;
            this.btnSinonimos.CustomImages.Parent = this.btnSinonimos;
            this.btnSinonimos.FillColor = System.Drawing.Color.Transparent;
            this.btnSinonimos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSinonimos.ForeColor = System.Drawing.Color.Black;
            this.btnSinonimos.HoverState.Parent = this.btnSinonimos;
            this.btnSinonimos.Image = global::VillaSofia.Properties.Resources.abajo94_148_255Azul32;
            this.btnSinonimos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSinonimos.Location = new System.Drawing.Point(18, 56);
            this.btnSinonimos.Name = "btnSinonimos";
            this.btnSinonimos.ShadowDecoration.Parent = this.btnSinonimos;
            this.btnSinonimos.Size = new System.Drawing.Size(430, 21);
            this.btnSinonimos.TabIndex = 16;
            this.btnSinonimos.Text = "Sinonimos para busqueda";
            this.btnSinonimos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSinonimos.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnSinonimos.Click += new System.EventHandler(this.btnSinonimos_Click_1);
            // 
            // FrmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 226);
            this.Controls.Add(this.pnPrincipal);
            this.MinimumSize = new System.Drawing.Size(481, 265);
            this.Name = "FrmAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarProducto";
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnPrincipal;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Timer tempoSinonimos;
        private Guna.UI2.WinForms.Guna2Button btnMasOpciones;
        private Guna.UI2.WinForms.Guna2Button btnVincularDirecto;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnClasificacion;
        private System.Windows.Forms.TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoProducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.TextBox txtPrecio;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrecio;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblClasificacion;
        private Guna.UI2.WinForms.Guna2CheckBox chbVincular;
        private Guna.UI2.WinForms.Guna2Button btnSinonimos;
        private System.Windows.Forms.TextBox txtSinonimos;
    }
}