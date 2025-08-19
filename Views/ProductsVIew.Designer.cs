namespace MrGrill.Views
{
    partial class ProductsVIew
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelForm = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPhoto = new RJCodeAdvance.RJControls.RJButton();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.rButtonInactive = new System.Windows.Forms.RadioButton();
            this.rbuttonActive = new System.Windows.Forms.RadioButton();
            this.cmbCombo = new RJCodeAdvance.RJControls.RJComboBox();
            this.nPadPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnAddProduct = new RJCodeAdvance.RJControls.RJButton();
            this.flowLayoutProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rjDropdownMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPadPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "TUS PRODUCTOS";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.txtDescription);
            this.panelForm.Controls.Add(this.txtProductName);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.btnPhoto);
            this.panelForm.Controls.Add(this.pictureBoxPhoto);
            this.panelForm.Controls.Add(this.rButtonInactive);
            this.panelForm.Controls.Add(this.rbuttonActive);
            this.panelForm.Controls.Add(this.cmbCombo);
            this.panelForm.Controls.Add(this.nPadPrice);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.cmbCategory);
            this.panelForm.Controls.Add(this.btnAddProduct);
            this.panelForm.Location = new System.Drawing.Point(883, 25);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(5);
            this.panelForm.Size = new System.Drawing.Size(538, 718);
            this.panelForm.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(203, 165);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(202, 49);
            this.txtDescription.TabIndex = 42;
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(203, 103);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(202, 27);
            this.txtProductName.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(63, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 40;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(90, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label6.Location = new System.Drawing.Point(107, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 28);
            this.label6.TabIndex = 38;
            this.label6.Text = "Precio";
            // 
            // btnPhoto
            // 
            this.btnPhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPhoto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPhoto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPhoto.BorderRadius = 5;
            this.btnPhoto.BorderSize = 0;
            this.btnPhoto.FlatAppearance.BorderSize = 0;
            this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoto.ForeColor = System.Drawing.Color.White;
            this.btnPhoto.Location = new System.Drawing.Point(182, 580);
            this.btnPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(225, 39);
            this.btnPhoto.TabIndex = 37;
            this.btnPhoto.Text = "Agrega foto";
            this.btnPhoto.TextColor = System.Drawing.Color.White;
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(182, 427);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(239, 146);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 36;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // rButtonInactive
            // 
            this.rButtonInactive.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rButtonInactive.AutoSize = true;
            this.rButtonInactive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonInactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rButtonInactive.Location = new System.Drawing.Point(311, 382);
            this.rButtonInactive.Name = "rButtonInactive";
            this.rButtonInactive.Size = new System.Drawing.Size(84, 24);
            this.rButtonInactive.TabIndex = 35;
            this.rButtonInactive.TabStop = true;
            this.rButtonInactive.Text = "Inactivo";
            this.rButtonInactive.UseVisualStyleBackColor = true;
            // 
            // rbuttonActive
            // 
            this.rbuttonActive.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbuttonActive.AutoSize = true;
            this.rbuttonActive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbuttonActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbuttonActive.Location = new System.Drawing.Point(203, 382);
            this.rbuttonActive.Name = "rbuttonActive";
            this.rbuttonActive.Size = new System.Drawing.Size(73, 24);
            this.rbuttonActive.TabIndex = 34;
            this.rbuttonActive.TabStop = true;
            this.rbuttonActive.Text = "Activo";
            this.rbuttonActive.UseVisualStyleBackColor = true;
            // 
            // cmbCombo
            // 
            this.cmbCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbCombo.BorderSize = 1;
            this.cmbCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCombo.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCombo.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbCombo.Location = new System.Drawing.Point(205, 331);
            this.cmbCombo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbCombo.Name = "cmbCombo";
            this.cmbCombo.Padding = new System.Windows.Forms.Padding(1);
            this.cmbCombo.Size = new System.Drawing.Size(200, 30);
            this.cmbCombo.TabIndex = 33;
            this.cmbCombo.Tag = "";
            this.cmbCombo.Texts = "¿Es combo?";
            // 
            // nPadPrice
            // 
            this.nPadPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nPadPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nPadPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPadPrice.Location = new System.Drawing.Point(203, 231);
            this.nPadPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nPadPrice.Name = "nPadPrice";
            this.nPadPrice.Size = new System.Drawing.Size(202, 26);
            this.nPadPrice.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(80, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "AÑADIR UN NUEVO PRODUCTO";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbCategory.BorderSize = 1;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbCategory.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCategory.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbCategory.Location = new System.Drawing.Point(203, 281);
            this.cmbCategory.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Padding = new System.Windows.Forms.Padding(1);
            this.cmbCategory.Size = new System.Drawing.Size(202, 30);
            this.cmbCategory.TabIndex = 28;
            this.cmbCategory.Tag = "";
            this.cmbCategory.Texts = "Categoría";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddProduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddProduct.BorderRadius = 5;
            this.btnAddProduct.BorderSize = 0;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(182, 640);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(225, 39);
            this.btnAddProduct.TabIndex = 25;
            this.btnAddProduct.Text = "Guardar cambios";
            this.btnAddProduct.TextColor = System.Drawing.Color.White;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // flowLayoutProducts
            // 
            this.flowLayoutProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutProducts.AutoScroll = true;
            this.flowLayoutProducts.Location = new System.Drawing.Point(12, 92);
            this.flowLayoutProducts.Name = "flowLayoutProducts";
            this.flowLayoutProducts.Size = new System.Drawing.Size(865, 651);
            this.flowLayoutProducts.TabIndex = 8;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(557, 37);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(227, 27);
            this.txtSearchProduct.TabIndex = 43;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Buscar";
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // ProductsVIew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1433, 791);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsVIew";
            this.Text = "ProductsVIew";
            this.Load += new System.EventHandler(this.ProductsVIew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPadPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJButton btnAddProduct;
        private RJCodeAdvance.RJControls.RJComboBox cmbCategory;
        private System.Windows.Forms.NumericUpDown nPadPrice;
        private RJCodeAdvance.RJControls.RJComboBox cmbCombo;
        private System.Windows.Forms.RadioButton rButtonInactive;
        private System.Windows.Forms.RadioButton rbuttonActive;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private RJCodeAdvance.RJControls.RJButton btnPhoto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu1;
    }
}