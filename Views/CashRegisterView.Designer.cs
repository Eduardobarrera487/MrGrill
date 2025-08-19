namespace MrGrill.Views
{
    partial class CashRegisterView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCaja = new FontAwesome.Sharp.IconButton();
            this.btnIngresos = new FontAwesome.Sharp.IconButton();
            this.btnEgresos = new FontAwesome.Sharp.IconButton();
            this.btnArqueo = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(470, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAJA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 589);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 92);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCaja, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIngresos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEgresos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnArqueo, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1087, 489);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCaja.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.ForeColor = System.Drawing.Color.White;
            this.btnCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnCaja.IconColor = System.Drawing.Color.White;
            this.btnCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCaja.Location = new System.Drawing.Point(3, 3);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(537, 238);
            this.btnCaja.TabIndex = 0;
            this.btnCaja.Text = "Abrir/Cerrar Caja";
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.MouseEnter += new System.EventHandler(this.btnCaja_MouseEnter);
            this.btnCaja.MouseLeave += new System.EventHandler(this.btnCaja_MouseLeave);
            // 
            // btnIngresos
            // 
            this.btnIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIngresos.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.ForeColor = System.Drawing.Color.White;
            this.btnIngresos.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnIngresos.IconColor = System.Drawing.Color.White;
            this.btnIngresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresos.Location = new System.Drawing.Point(546, 3);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(538, 238);
            this.btnIngresos.TabIndex = 1;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.MouseEnter += new System.EventHandler(this.btnIngresos_MouseEnter);
            this.btnIngresos.MouseLeave += new System.EventHandler(this.btnIngresos_MouseLeave);
            // 
            // btnEgresos
            // 
            this.btnEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnEgresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEgresos.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEgresos.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
            this.btnEgresos.IconColor = System.Drawing.Color.White;
            this.btnEgresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEgresos.Location = new System.Drawing.Point(3, 247);
            this.btnEgresos.Name = "btnEgresos";
            this.btnEgresos.Size = new System.Drawing.Size(537, 239);
            this.btnEgresos.TabIndex = 2;
            this.btnEgresos.Text = "Egresos";
            this.btnEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEgresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEgresos.UseVisualStyleBackColor = false;
            this.btnEgresos.MouseEnter += new System.EventHandler(this.btnEgresos_MouseEnter);
            this.btnEgresos.MouseLeave += new System.EventHandler(this.btnEgresos_MouseLeave);
            // 
            // btnArqueo
            // 
            this.btnArqueo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnArqueo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArqueo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArqueo.ForeColor = System.Drawing.Color.White;
            this.btnArqueo.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnArqueo.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnArqueo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArqueo.Location = new System.Drawing.Point(546, 247);
            this.btnArqueo.Name = "btnArqueo";
            this.btnArqueo.Size = new System.Drawing.Size(538, 239);
            this.btnArqueo.TabIndex = 3;
            this.btnArqueo.Text = "Arqueo";
            this.btnArqueo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArqueo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArqueo.UseVisualStyleBackColor = false;
            this.btnArqueo.MouseEnter += new System.EventHandler(this.btnArqueo_MouseEnter);
            this.btnArqueo.MouseLeave += new System.EventHandler(this.btnArqueo_MouseLeave);
            // 
            // CashRegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CashRegisterView";
            this.Text = "CashRegisterView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnCaja;
        private FontAwesome.Sharp.IconButton btnIngresos;
        private FontAwesome.Sharp.IconButton btnEgresos;
        private FontAwesome.Sharp.IconButton btnArqueo;
    }
}