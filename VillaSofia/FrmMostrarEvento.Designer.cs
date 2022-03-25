namespace VillaSofia
{
    partial class FrmMostrarEvento
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
            this.pnPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDinero = new Guna.UI2.WinForms.Guna2Button();
            this.btnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPlatos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lblFecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblComentarios = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNumInvitados = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTipoServicio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHoraComida = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblHora = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTipoEvento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblArea = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.White;
            this.pnPrincipal.Controls.Add(this.lblArea);
            this.pnPrincipal.Controls.Add(this.btnDinero);
            this.pnPrincipal.Controls.Add(this.btnImprimir);
            this.pnPrincipal.Controls.Add(this.btnEditar);
            this.pnPrincipal.Controls.Add(this.dgvPlatos);
            this.pnPrincipal.Controls.Add(this.guna2VSeparator1);
            this.pnPrincipal.Controls.Add(this.lblFecha);
            this.pnPrincipal.Controls.Add(this.lblComentarios);
            this.pnPrincipal.Controls.Add(this.lblNumInvitados);
            this.pnPrincipal.Controls.Add(this.lblTipoServicio);
            this.pnPrincipal.Controls.Add(this.lblHoraComida);
            this.pnPrincipal.Controls.Add(this.lblNombre);
            this.pnPrincipal.Controls.Add(this.guna2Separator1);
            this.pnPrincipal.Controls.Add(this.lblHora);
            this.pnPrincipal.Controls.Add(this.lblTipoEvento);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.ShadowDecoration.Parent = this.pnPrincipal;
            this.pnPrincipal.Size = new System.Drawing.Size(815, 577);
            this.pnPrincipal.TabIndex = 0;
            // 
            // btnDinero
            // 
            this.btnDinero.BackColor = System.Drawing.Color.Transparent;
            this.btnDinero.CheckedState.Parent = this.btnDinero;
            this.btnDinero.CustomImages.Parent = this.btnDinero;
            this.btnDinero.FillColor = System.Drawing.Color.Transparent;
            this.btnDinero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDinero.ForeColor = System.Drawing.Color.White;
            this.btnDinero.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnDinero.HoverState.Image = global::VillaSofia.Properties.Resources.dineroBlanco32;
            this.btnDinero.HoverState.Parent = this.btnDinero;
            this.btnDinero.Image = global::VillaSofia.Properties.Resources.dineroAzul32;
            this.btnDinero.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDinero.Location = new System.Drawing.Point(135, 3);
            this.btnDinero.Name = "btnDinero";
            this.btnDinero.ShadowDecoration.Parent = this.btnDinero;
            this.btnDinero.Size = new System.Drawing.Size(54, 55);
            this.btnDinero.TabIndex = 3;
            this.btnDinero.Click += new System.EventHandler(this.btnDinero_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.CheckedState.Parent = this.btnImprimir;
            this.btnImprimir.CustomImages.Parent = this.btnImprimir;
            this.btnImprimir.FillColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnImprimir.HoverState.Image = global::VillaSofia.Properties.Resources.imprimir2Blanco32;
            this.btnImprimir.HoverState.Parent = this.btnImprimir;
            this.btnImprimir.Image = global::VillaSofia.Properties.Resources.imprimir2Azul32;
            this.btnImprimir.ImageSize = new System.Drawing.Size(30, 30);
            this.btnImprimir.Location = new System.Drawing.Point(75, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ShadowDecoration.Parent = this.btnImprimir;
            this.btnImprimir.Size = new System.Drawing.Size(54, 55);
            this.btnImprimir.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.FillColor = System.Drawing.Color.Transparent;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnEditar.HoverState.Image = global::VillaSofia.Properties.Resources.editarBlanco32;
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Image = global::VillaSofia.Properties.Resources.editarAzul32;
            this.btnEditar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditar.Location = new System.Drawing.Point(15, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(54, 55);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.AllowUserToAddRows = false;
            this.dgvPlatos.AllowUserToDeleteRows = false;
            this.dgvPlatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPlatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlatos.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlatos.EnableHeadersVisualStyles = false;
            this.dgvPlatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlatos.Location = new System.Drawing.Point(254, 147);
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.ReadOnly = true;
            this.dgvPlatos.RowHeadersVisible = false;
            this.dgvPlatos.RowTemplate.Height = 24;
            this.dgvPlatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlatos.Size = new System.Drawing.Size(537, 200);
            this.dgvPlatos.TabIndex = 34;
            this.dgvPlatos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPlatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlatos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPlatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPlatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPlatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPlatos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlatos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlatos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvPlatos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlatos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.dgvPlatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPlatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPlatos.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvPlatos.ThemeStyle.ReadOnly = true;
            this.dgvPlatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlatos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPlatos.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPlatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvPlatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(228, 137);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 429);
            this.guna2VSeparator1.TabIndex = 33;
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Tw Cen MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Silver;
            this.lblFecha.Location = new System.Drawing.Point(26, 76);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(167, 39);
            this.lblFecha.TabIndex = 32;
            this.lblFecha.Text = "Dom. 7/5/21";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = false;
            this.lblComentarios.BackColor = System.Drawing.Color.Transparent;
            this.lblComentarios.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.lblComentarios.ForeColor = System.Drawing.Color.Gray;
            this.lblComentarios.Location = new System.Drawing.Point(254, 363);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(537, 186);
            this.lblComentarios.TabIndex = 31;
            this.lblComentarios.Text = "87 invitados";
            this.lblComentarios.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblNumInvitados
            // 
            this.lblNumInvitados.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInvitados.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInvitados.ForeColor = System.Drawing.Color.Gray;
            this.lblNumInvitados.Location = new System.Drawing.Point(36, 243);
            this.lblNumInvitados.Name = "lblNumInvitados";
            this.lblNumInvitados.Size = new System.Drawing.Size(92, 24);
            this.lblNumInvitados.TabIndex = 31;
            this.lblNumInvitados.Text = "87 invitados";
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoServicio.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.ForeColor = System.Drawing.Color.Gray;
            this.lblTipoServicio.Location = new System.Drawing.Point(36, 213);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(130, 24);
            this.lblTipoServicio.TabIndex = 30;
            this.lblTipoServicio.Text = "Servicio en mesas";
            // 
            // lblHoraComida
            // 
            this.lblHoraComida.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraComida.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraComida.ForeColor = System.Drawing.Color.Gray;
            this.lblHoraComida.Location = new System.Drawing.Point(36, 183);
            this.lblHoraComida.Name = "lblHoraComida";
            this.lblHoraComida.Size = new System.Drawing.Size(153, 24);
            this.lblHoraComida.TabIndex = 29;
            this.lblHoraComida.Text = "Comida a la 1:30 pm";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Tw Cen MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(423, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(380, 39);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Maria Jose Cardenas Gonzales";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(17, 121);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(786, 10);
            this.guna2Separator1.TabIndex = 27;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Gray;
            this.lblHora.Location = new System.Drawing.Point(36, 153);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(172, 24);
            this.lblHora.TabIndex = 26;
            this.lblHora.Text = "De 12:00 pm a 5:00 pm";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoEvento.Font = new System.Drawing.Font("Tw Cen MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.lblTipoEvento.Location = new System.Drawing.Point(641, 12);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(162, 76);
            this.lblTipoEvento.TabIndex = 25;
            this.lblTipoEvento.Text = "BODA";
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.Gray;
            this.lblArea.Location = new System.Drawing.Point(36, 273);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(79, 24);
            this.lblArea.TabIndex = 35;
            this.lblArea.Text = "En salones";
            // 
            // FrmMostrarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 577);
            this.Controls.Add(this.pnPrincipal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(831, 616);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(831, 616);
            this.Name = "FrmMostrarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrarEvento";
            this.Load += new System.EventHandler(this.FrmMostrarEvento_Load);
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHora;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumInvitados;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTipoServicio;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoraComida;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPlatos;
        private Guna.UI2.WinForms.Guna2Button btnImprimir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnDinero;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblComentarios;
        public Guna.UI2.WinForms.Guna2Panel pnPrincipal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTipoEvento;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblArea;
    }
}