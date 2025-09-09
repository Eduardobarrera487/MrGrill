namespace MrGrill.Views
{
    partial class EgresosModal
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
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.rjTextBox3 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjDatePicker1 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(315, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Egresos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rjButton2);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.rjTextBox3);
            this.panel2.Controls.Add(this.rjTextBox2);
            this.panel2.Controls.Add(this.rjDatePicker1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(648, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 500);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(24, 336);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(312, 40);
            this.rjButton2.TabIndex = 20;
            this.rjButton2.Text = "Modificar Egreso";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.rjButton1.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(24, 280);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(312, 40);
            this.rjButton1.TabIndex = 19;
            this.rjButton1.Text = "Agregar Egreso";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.rjTextBox3.BorderRadius = 0;
            this.rjTextBox3.BorderSize = 1;
            this.rjTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox3.Location = new System.Drawing.Point(112, 168);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "";
            this.rjTextBox3.Size = new System.Drawing.Size(224, 31);
            this.rjTextBox3.TabIndex = 17;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.rjTextBox2.BorderRadius = 0;
            this.rjTextBox2.BorderSize = 1;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(112, 120);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(224, 31);
            this.rjTextBox2.TabIndex = 16;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.Black;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.CalendarForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker1.Location = new System.Drawing.Point(112, 74);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(224, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.rjDatePicker1.TabIndex = 15;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Monto C$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 500);
            this.dataGridView1.TabIndex = 2;
            // 
            // EgresosModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EgresosModal";
            this.Text = "IngresosModal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox3;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox2;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}