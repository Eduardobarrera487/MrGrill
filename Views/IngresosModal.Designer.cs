namespace MrGrill.Views
{
    partial class IngresosModal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboTipo = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtDescripcion = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtMonto = new RJCodeAdvance.RJControls.RJTextBox();
            this.dtpFechaIngreso = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarIngreso = new RJCodeAdvance.RJControls.RJButton();
            this.btnModificarIngreso = new RJCodeAdvance.RJControls.RJButton();
            this.dgvIngresos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Ingresos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnModificarIngreso);
            this.panel2.Controls.Add(this.btnAgregarIngreso);
            this.panel2.Controls.Add(this.comboTipo);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.txtMonto);
            this.panel2.Controls.Add(this.dtpFechaIngreso);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(652, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 500);
            this.panel2.TabIndex = 1;
            // 
            // comboTipo
            // 
            this.comboTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Venta",
            "Ingreso"});
            this.comboTipo.BackColor = System.Drawing.Color.White;
            this.comboTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.comboTipo.BorderSize = 1;
            this.comboTipo.DisplayMember = "Ingrese el tipo de ingreso";
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboTipo.ForeColor = System.Drawing.Color.DimGray;
            this.comboTipo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.comboTipo.Items.AddRange(new object[] {
            "Venta",
            "Ingreso"});
            this.comboTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboTipo.ListTextColor = System.Drawing.Color.DimGray;
            this.comboTipo.Location = new System.Drawing.Point(112, 96);
            this.comboTipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Padding = new System.Windows.Forms.Padding(1);
            this.comboTipo.Size = new System.Drawing.Size(224, 30);
            this.comboTipo.TabIndex = 8;
            this.comboTipo.Texts = "";
            this.comboTipo.ValueMember = "Ingrese el tipo de ingreso";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.txtDescripcion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.txtDescripcion.BorderRadius = 0;
            this.txtDescripcion.BorderSize = 1;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.Location = new System.Drawing.Point(112, 192);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(224, 31);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Texts = "";
            this.txtDescripcion.UnderlinedStyle = false;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.SystemColors.Window;
            this.txtMonto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.txtMonto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.txtMonto.BorderRadius = 0;
            this.txtMonto.BorderSize = 1;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMonto.Location = new System.Drawing.Point(112, 144);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Multiline = false;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMonto.PasswordChar = false;
            this.txtMonto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMonto.PlaceholderText = "";
            this.txtMonto.Size = new System.Drawing.Size(224, 31);
            this.txtMonto.TabIndex = 6;
            this.txtMonto.Texts = "";
            this.txtMonto.UnderlinedStyle = false;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.BorderColor = System.Drawing.Color.Black;
            this.dtpFechaIngreso.BorderSize = 0;
            this.dtpFechaIngreso.CalendarForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(112, 48);
            this.dtpFechaIngreso.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(224, 35);
            this.dtpFechaIngreso.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.dtpFechaIngreso.TabIndex = 4;
            this.dtpFechaIngreso.TextColor = System.Drawing.Color.White;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.rjDatePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Monto C$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarIngreso.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarIngreso.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarIngreso.BorderRadius = 0;
            this.btnAgregarIngreso.BorderSize = 0;
            this.btnAgregarIngreso.FlatAppearance.BorderSize = 0;
            this.btnAgregarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIngreso.ForeColor = System.Drawing.Color.White;
            this.btnAgregarIngreso.Location = new System.Drawing.Point(24, 304);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(312, 40);
            this.btnAgregarIngreso.TabIndex = 9;
            this.btnAgregarIngreso.Text = "Agregar Ingreso";
            this.btnAgregarIngreso.TextColor = System.Drawing.Color.White;
            this.btnAgregarIngreso.UseVisualStyleBackColor = false;
            this.btnAgregarIngreso.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnModificarIngreso
            // 
            this.btnModificarIngreso.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarIngreso.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarIngreso.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificarIngreso.BorderRadius = 0;
            this.btnModificarIngreso.BorderSize = 0;
            this.btnModificarIngreso.FlatAppearance.BorderSize = 0;
            this.btnModificarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarIngreso.ForeColor = System.Drawing.Color.White;
            this.btnModificarIngreso.Location = new System.Drawing.Point(24, 360);
            this.btnModificarIngreso.Name = "btnModificarIngreso";
            this.btnModificarIngreso.Size = new System.Drawing.Size(312, 40);
            this.btnModificarIngreso.TabIndex = 10;
            this.btnModificarIngreso.Text = "Modificar Ingreso";
            this.btnModificarIngreso.TextColor = System.Drawing.Color.White;
            this.btnModificarIngreso.UseVisualStyleBackColor = false;
            this.btnModificarIngreso.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngresos.Location = new System.Drawing.Point(0, 100);
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.Size = new System.Drawing.Size(652, 500);
            this.dgvIngresos.TabIndex = 2;
            // 
            // IngresosModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgvIngresos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresosModal";
            this.Text = "IngresosModal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJDatePicker dtpFechaIngreso;
        private RJCodeAdvance.RJControls.RJTextBox txtMonto;
        private RJCodeAdvance.RJControls.RJComboBox comboTipo;
        private RJCodeAdvance.RJControls.RJTextBox txtDescripcion;
        private RJCodeAdvance.RJControls.RJButton btnModificarIngreso;
        private RJCodeAdvance.RJControls.RJButton btnAgregarIngreso;
        private System.Windows.Forms.DataGridView dgvIngresos;
    }
}