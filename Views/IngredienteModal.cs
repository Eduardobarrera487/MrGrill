using MrGrill.Controllers;
using MrGrill.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MrGrill.Views
{
    public class IngredienteModal : Form
    {
        private IngredientController ingredientController;
        private Ingredient ingredienteEditando;

        private TextBox txtNombre;
        private TextBox txtUnidad;
        private NumericUpDown numStockActual;
        private NumericUpDown numStockMinimo;

        public IngredienteModal()
        {
            InitializeUI();
            ingredientController = new IngredientController();
        }

        public IngredienteModal(Ingredient ingrediente) : this()
        {
            ingredienteEditando = ingrediente;
            txtNombre.Text = ingrediente.name;
            txtUnidad.Text = ingrediente.unit;
            numStockActual.Value = ingrediente.currentStock;
            numStockMinimo.Value = ingrediente.minimumStock;
            this.Text = "Editar Ingrediente";
        }

        private void InitializeUI()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;
            this.Size = new Size(400, 350);
            this.Padding = new Padding(2);

            // 🔹 Fade-in
            this.Opacity = 0;
            Timer fadeTimer = new Timer { Interval = 15 };
            fadeTimer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fadeTimer.Stop();
            };
            this.Shown += (s, e) => fadeTimer.Start();

            // 🟧 Bordes redondeados
            this.Load += (s, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radio = 15;
                    path.AddArc(0, 0, radio, radio, 180, 90);
                    path.AddArc(this.Width - radio, 0, radio, radio, 270, 90);
                    path.AddArc(this.Width - radio, this.Height - radio, radio, radio, 0, 90);
                    path.AddArc(0, this.Height - radio, radio, radio, 90, 90);
                    path.CloseAllFigures();
                    this.Region = new Region(path);
                }
                ;
            };

            // 🖤 Sombra
            this.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.FromArgb(50, 0, 0, 0), 4))
                {
                    e.Graphics.DrawRectangle(pen, 2, 2, this.Width - 4, this.Height - 4);
                }
            };

            // 🟧 Encabezado
            Panel header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = ColorTranslator.FromHtml("#FF5000")
            };
            Label lblTitulo = new Label
            {
                Text = "Gestión de Ingrediente",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            header.Controls.Add(lblTitulo);
            this.Controls.Add(header);

            // 📌 Panel de contenido centrado
            Panel contentWrapper = new Panel
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(contentWrapper);

            Panel content = new Panel
            {
                Size = new Size(350, 200),
                Anchor = AnchorStyles.None
            };
            contentWrapper.Controls.Add(content);

            // Centrar respetando header y footer
            contentWrapper.Resize += (s, e) =>
            {
                int headerHeight = 50;
                int footerHeight = 60;
                int usableHeight = contentWrapper.Height - footerHeight;

                content.Left = (contentWrapper.Width - content.Width) / 2;
                content.Top = (usableHeight - content.Height) / 2;
                if (content.Top < headerHeight + 10)
                    content.Top = headerHeight + 10;
            };

            int y = 0;
            int spacing = 50;

            // Nombre
            Label lblNombre = CrearLabel("Nombre:");
            lblNombre.Location = new Point(0, y);
            txtNombre = CrearTextBox();
            txtNombre.Location = new Point(120, y);
            content.Controls.Add(lblNombre);
            content.Controls.Add(txtNombre);

            y += spacing;

            // Unidad
            Label lblUnidad = CrearLabel("Unidad:");
            lblUnidad.Location = new Point(0, y);
            txtUnidad = CrearTextBox();
            txtUnidad.Location = new Point(120, y);
            content.Controls.Add(lblUnidad);
            content.Controls.Add(txtUnidad);

            y += spacing;

            // Stock actual
            Label lblStockActual = CrearLabel("Stock actual:");
            lblStockActual.Location = new Point(0, y);
            numStockActual = CrearNumericUpDown();
            numStockActual.Location = new Point(120, y);
            content.Controls.Add(lblStockActual);
            content.Controls.Add(numStockActual);

            y += spacing;

            // Stock mínimo
            Label lblStockMinimo = CrearLabel("Stock mínimo:");
            lblStockMinimo.Location = new Point(0, y);
            numStockMinimo = CrearNumericUpDown();
            numStockMinimo.Location = new Point(120, y);
            content.Controls.Add(lblStockMinimo);
            content.Controls.Add(numStockMinimo);

            // 📌 Panel de botones
            Panel footer = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = Color.White
            };
            this.Controls.Add(footer);

            Button btnGuardar = CrearBoton("Guardar", "#4CAF50", Color.White);
            btnGuardar.Location = new Point(100, 15);
            btnGuardar.Click += BtnGuardar_Click;

            Button btnCancelar = CrearBoton("Cancelar", "#AA1E1E", Color.White);
            btnCancelar.Location = new Point(210, 15);
            btnCancelar.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            footer.Controls.Add(btnGuardar);
            footer.Controls.Add(btnCancelar);
        }

        // Métodos auxiliares
        private Label CrearLabel(string texto)
        {
            return new Label
            {
                Text = texto,
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Black
            };
        }

        private TextBox CrearTextBox()
        {
            return new TextBox
            {
                Width = 200,
                Font = new Font("Segoe UI", 10),
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        private NumericUpDown CrearNumericUpDown()
        {
            return new NumericUpDown
            {
                Width = 200,
                Font = new Font("Segoe UI", 10),
                DecimalPlaces = 2,
                Maximum = 1000000
            };
        }

        private Button CrearBoton(string texto, string colorFondoHex, Color colorTexto)
        {
            return new Button
            {
                Text = texto,
                BackColor = ColorTranslator.FromHtml(colorFondoHex),
                ForeColor = colorTexto,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = new Size(100, 30),
                FlatAppearance = { BorderSize = 0 }
            };
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtUnidad.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ingredienteEditando == null)
            {
                Ingredient nuevo = new Ingredient
                {
                    name = txtNombre.Text,
                    unit = txtUnidad.Text,
                    currentStock = numStockActual.Value,
                    minimumStock = numStockMinimo.Value
                };

                if (ingredientController.AddIngredient(nuevo))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                ingredienteEditando.name = txtNombre.Text;
                ingredienteEditando.unit = txtUnidad.Text;
                ingredienteEditando.currentStock = numStockActual.Value;
                ingredienteEditando.minimumStock = numStockMinimo.Value;

                if (ingredientController.UpdateIngredient(ingredienteEditando))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
