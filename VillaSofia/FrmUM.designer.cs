namespace VillaSofia
{
    partial class FrmUM
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
            this.gbxUnidadesM = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.LblUM = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtUM = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvUM = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gbxUnidadesM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUM)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUnidadesM
            // 
            this.gbxUnidadesM.BorderColor = System.Drawing.Color.Black;
            this.gbxUnidadesM.Controls.Add(this.BtnGuardar);
            this.gbxUnidadesM.Controls.Add(this.LblUM);
            this.gbxUnidadesM.Controls.Add(this.txtUM);
            this.gbxUnidadesM.Controls.Add(this.dgvUM);
            this.gbxUnidadesM.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.gbxUnidadesM.FillColor = System.Drawing.Color.Snow;
            this.gbxUnidadesM.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUnidadesM.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbxUnidadesM.Location = new System.Drawing.Point(3, -2);
            this.gbxUnidadesM.Name = "gbxUnidadesM";
            this.gbxUnidadesM.ShadowDecoration.Parent = this.gbxUnidadesM;
            this.gbxUnidadesM.Size = new System.Drawing.Size(513, 301);
            this.gbxUnidadesM.TabIndex = 0;
            this.gbxUnidadesM.Text = "Unidades de Medidas";
            this.gbxUnidadesM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.CheckedState.Parent = this.BtnGuardar;
            this.BtnGuardar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGuardar.CustomImages.Parent = this.BtnGuardar;
            this.BtnGuardar.FillColor = System.Drawing.Color.LightCyan;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardar.HoverState.Parent = this.BtnGuardar;
            this.BtnGuardar.Image = global::VillaSofia.Properties.Resources.save;
            this.BtnGuardar.Location = new System.Drawing.Point(56, 209);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.ShadowDecoration.Parent = this.BtnGuardar;
            this.BtnGuardar.Size = new System.Drawing.Size(118, 41);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblUM
            // 
            this.LblUM.BackColor = System.Drawing.Color.Transparent;
            this.LblUM.Location = new System.Drawing.Point(10, 51);
            this.LblUM.Name = "LblUM";
            this.LblUM.Size = new System.Drawing.Size(23, 15);
            this.LblUM.TabIndex = 2;
            this.LblUM.Text = "UM:";
            // 
            // txtUM
            // 
            this.txtUM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUM.DefaultText = "";
            this.txtUM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUM.DisabledState.Parent = this.txtUM;
            this.txtUM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUM.FocusedState.Parent = this.txtUM;
            this.txtUM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUM.HoverState.Parent = this.txtUM;
            this.txtUM.Location = new System.Drawing.Point(10, 81);
            this.txtUM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUM.Name = "txtUM";
            this.txtUM.PasswordChar = '\0';
            this.txtUM.PlaceholderText = "";
            this.txtUM.SelectedText = "";
            this.txtUM.ShadowDecoration.Parent = this.txtUM;
            this.txtUM.Size = new System.Drawing.Size(246, 40);
            this.txtUM.TabIndex = 1;
            this.txtUM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUM_KeyPress);
            // 
            // dgvUM
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvUM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUM.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvUM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUM.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUM.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUM.EnableHeadersVisualStyles = false;
            this.dgvUM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvUM.Location = new System.Drawing.Point(281, 42);
            this.dgvUM.Name = "dgvUM";
            this.dgvUM.RowHeadersVisible = false;
            this.dgvUM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUM.Size = new System.Drawing.Size(228, 254);
            this.dgvUM.TabIndex = 0;
            this.dgvUM.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.dgvUM.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvUM.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUM.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUM.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUM.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUM.ThemeStyle.BackColor = System.Drawing.Color.Azure;
            this.dgvUM.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvUM.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvUM.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUM.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUM.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUM.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUM.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvUM.ThemeStyle.ReadOnly = false;
            this.dgvUM.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvUM.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUM.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUM.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUM.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUM.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dgvUM.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // FrmUM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(517, 302);
            this.Controls.Add(this.gbxUnidadesM);
            this.Name = "FrmUM";
            this.Text = "FrmUM";
            this.Load += new System.EventHandler(this.FrmUM_Load);
            this.gbxUnidadesM.ResumeLayout(false);
            this.gbxUnidadesM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbxUnidadesM;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUM;
        private Guna.UI2.WinForms.Guna2Button BtnGuardar;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblUM;
        private Guna.UI2.WinForms.Guna2TextBox txtUM;
    }
}