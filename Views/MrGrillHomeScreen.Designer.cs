namespace MrGrill.Views
{
    partial class MrGrillHomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MrGrillHomeScreen));
            this.SideBarButton = new System.Windows.Forms.PictureBox();
            this.SideBarLayaout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCaja = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCombos = new System.Windows.Forms.Button();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SideBarButton)).BeginInit();
            this.SideBarLayaout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarButton
            // 
            this.SideBarButton.Image = ((System.Drawing.Image)(resources.GetObject("SideBarButton.Image")));
            this.SideBarButton.Location = new System.Drawing.Point(6, 6);
            this.SideBarButton.Margin = new System.Windows.Forms.Padding(2);
            this.SideBarButton.Name = "SideBarButton";
            this.SideBarButton.Size = new System.Drawing.Size(43, 46);
            this.SideBarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SideBarButton.TabIndex = 0;
            this.SideBarButton.TabStop = false;
            this.SideBarButton.Click += new System.EventHandler(this.SideBarButton_Click);
            // 
            // SideBarLayaout
            // 
            this.SideBarLayaout.BackColor = System.Drawing.Color.White;
            this.SideBarLayaout.Controls.Add(this.SideBarButton);
            this.SideBarLayaout.Controls.Add(this.panel1);
            this.SideBarLayaout.Controls.Add(this.panel2);
            this.SideBarLayaout.Controls.Add(this.panel3);
            this.SideBarLayaout.Controls.Add(this.panel4);
            this.SideBarLayaout.Controls.Add(this.panel5);
            this.SideBarLayaout.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarLayaout.Location = new System.Drawing.Point(0, 0);
            this.SideBarLayaout.Margin = new System.Windows.Forms.Padding(2);
            this.SideBarLayaout.Name = "SideBarLayaout";
            this.SideBarLayaout.Padding = new System.Windows.Forms.Padding(4);
            this.SideBarLayaout.Size = new System.Drawing.Size(176, 681);
            this.SideBarLayaout.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCaja);
            this.panel1.Location = new System.Drawing.Point(6, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 16, 2, 8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(164, 60);
            this.panel1.TabIndex = 2;
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCaja.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.Location = new System.Drawing.Point(-9, -14);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCaja.Size = new System.Drawing.Size(188, 89);
            this.btnCaja.TabIndex = 3;
            this.btnCaja.Text = "Caja";
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOrdenes);
            this.panel2.Location = new System.Drawing.Point(6, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 16, 2, 8);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(164, 60);
            this.panel2.TabIndex = 4;
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOrdenes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.Location = new System.Drawing.Point(-9, -14);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnOrdenes.Size = new System.Drawing.Size(188, 89);
            this.btnOrdenes.TabIndex = 3;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnProductos);
            this.panel3.Location = new System.Drawing.Point(6, 238);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 16, 2, 8);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(164, 60);
            this.panel3.TabIndex = 5;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(-9, -14);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(188, 89);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnIngredientes);
            this.panel4.Location = new System.Drawing.Point(6, 322);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 16, 2, 8);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(164, 60);
            this.panel4.TabIndex = 6;
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIngredientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredientes.Location = new System.Drawing.Point(-9, -14);
            this.btnIngredientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnIngredientes.Size = new System.Drawing.Size(188, 89);
            this.btnIngredientes.TabIndex = 3;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCombos);
            this.panel5.Location = new System.Drawing.Point(6, 406);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 16, 2, 8);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(164, 60);
            this.panel5.TabIndex = 7;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnCombos
            // 
            this.btnCombos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCombos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombos.Location = new System.Drawing.Point(-9, -14);
            this.btnCombos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCombos.Name = "btnCombos";
            this.btnCombos.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCombos.Size = new System.Drawing.Size(188, 89);
            this.btnCombos.TabIndex = 3;
            this.btnCombos.Text = "Combos";
            this.btnCombos.UseVisualStyleBackColor = false;
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(176, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1088, 681);
            this.panelChildForm.TabIndex = 2;
            // 
            // MrGrillHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.SideBarLayaout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MrGrillHomeScreen";
            this.Text = "MrGrillHomeScreen";
            this.Load += new System.EventHandler(this.MrGrillHomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SideBarButton)).EndInit();
            this.SideBarLayaout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SideBarButton;
        private System.Windows.Forms.FlowLayoutPanel SideBarLayaout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCombos;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Panel panelChildForm;
    }
}