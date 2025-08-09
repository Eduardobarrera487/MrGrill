using MrGrill.Controllers;
using MrGrill.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace MrGrill.Views
{
    public partial class IngredientesView : Form
    {
        private IngredientController ingredientController;
        private List<Ingredient> allIngredients;
        private int currentPage = 1;
        private int pageSize = 15;

        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private IconButton btnAgregar, btnEditar, btnEliminar;
        private Label lblPaginacion;

        public IngredientesView()
        {
            ingredientController = new IngredientController();
            this.Load += IngredientesView_Load;

            Panel topPanel = new Panel { Dock = DockStyle.Top, Height = 50, BackColor = Color.White };
            Panel bottomPanel = new Panel { Dock = DockStyle.Bottom, Height = 40, BackColor = Color.WhiteSmoke };
            Panel mainPanel = new Panel { Dock = DockStyle.Fill };

            txtBuscar = new TextBox
            {
                Text = "Buscar ingrediente...",
                ForeColor = Color.Gray,
                Width = 250,
                Location = new Point(10, 12)
            };
            txtBuscar.GotFocus += (s, e) =>
            {
                if (txtBuscar.Text == "Buscar ingrediente...")
                {
                    txtBuscar.Text = "";
                    txtBuscar.ForeColor = Color.Black;
                }
            };
            txtBuscar.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    txtBuscar.Text = "Buscar ingrediente...";
                    txtBuscar.ForeColor = Color.Gray;
                }
            };
            txtBuscar.TextChanged += (s, e) =>
            {
                if (txtBuscar.ForeColor != Color.Gray)
                {
                    currentPage = 1;
                    CargarIngredientes(txtBuscar.Text);
                }
            };
            topPanel.Controls.Add(txtBuscar);

            Label lblTitulo = new Label
            {
                Text = "Gestión de Ingredientes",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#FF5000"),
                AutoSize = true
            };
            topPanel.Controls.Add(lblTitulo);
            topPanel.Resize += (s, e) =>
            {
                lblTitulo.Location = new Point((topPanel.Width / 2) - (lblTitulo.Width / 2), 12);
            };

            btnAgregar = CrearIconoBoton("Agregar", IconChar.Plus, "#4CAF50");
            btnAgregar.Click += (s, e) =>
            {
                using (var modal = new IngredienteModal())
                {
                    if (modal.ShowDialog() == DialogResult.OK)
                        CargarIngredientes(txtBuscar.Text);
                }
            };

            btnEditar = CrearIconoBoton("Editar", IconChar.Edit, "#2196F3");
            btnEditar.Click += (s, e) => EditarSeleccionado();

            btnEliminar = CrearIconoBoton("Eliminar", IconChar.Trash, "#AA1E1E");
            btnEliminar.Click += (s, e) => EliminarSeleccionado();

            topPanel.Controls.Add(btnAgregar);
            topPanel.Controls.Add(btnEditar);
            topPanel.Controls.Add(btnEliminar);
            topPanel.Resize += (s, e) =>
            {
                int spacing = 5;
                btnEliminar.Location = new Point(topPanel.Width - btnEliminar.Width - 10, 10);
                btnEditar.Location = new Point(btnEliminar.Left - btnEditar.Width - spacing, 10);
                btnAgregar.Location = new Point(btnEditar.Left - btnAgregar.Width - spacing, 10);
            };

            dataGridView1 = new DataGridView { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(dataGridView1);

            Button btnAnterior = new Button { Text = "Anterior", Size = new Size(80, 30), Location = new Point(10, 5) };
            btnAnterior.Click += (s, e) =>
            {
                if (currentPage > 1)
                {
                    currentPage--;
                    CargarIngredientes(txtBuscar.Text);
                }
            };

            Button btnSiguiente = new Button { Text = "Siguiente", Size = new Size(80, 30), Location = new Point(100, 5) };
            btnSiguiente.Click += (s, e) =>
            {
                int totalPages = (int)Math.Ceiling((double)allIngredients.Count / pageSize);
                if (currentPage < totalPages)
                {
                    currentPage++;
                    CargarIngredientes(txtBuscar.Text);
                }
            };

            lblPaginacion = new Label
            {
                AutoSize = true,
                Location = new Point(200, 10),
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            bottomPanel.Controls.Add(btnAnterior);
            bottomPanel.Controls.Add(btnSiguiente);
            bottomPanel.Controls.Add(lblPaginacion);

            this.Controls.Add(mainPanel);
            this.Controls.Add(bottomPanel);
            this.Controls.Add(topPanel);

            dataGridView1.DataBindingComplete += (s, e) =>
            {
                AplicarColoresStock();
            };
        }

        private void IngredientesView_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarIngredientes();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF5000");
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#E69600");
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 239, 213);
        }

        private void CargarIngredientes(string filtro = "")
        {
            allIngredients = ingredientController.GetAllIngredients();

            if (!string.IsNullOrEmpty(filtro) && filtro != "Buscar ingrediente...")
            {
                allIngredients = allIngredients
                    .Where(i => i.name.ToLower().Contains(filtro.ToLower()))
                    .ToList();
            }

            var ingredientesPaginados = allIngredients
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "id", DataPropertyName = "id", Visible = false });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", DataPropertyName = "Nombre", HeaderText = "Nombre" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Unidad", DataPropertyName = "Unidad", HeaderText = "Unidad" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "StockActual", DataPropertyName = "StockActual", HeaderText = "Stock Actual" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "StockMinimo", DataPropertyName = "StockMinimo", HeaderText = "Stock Mínimo" });

            // Nueva columna de estado
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "NivelStock", HeaderText = "Nivel de Stock" });

            dataGridView1.Rows.Clear();

            foreach (var i in ingredientesPaginados)
            {
                int rowIndex = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[rowIndex];

                row.Cells["id"].Value = i.id;
                row.Cells["Nombre"].Value = i.name;
                row.Cells["Unidad"].Value = i.unit;
                row.Cells["StockActual"].Value = i.currentStock;
                row.Cells["StockMinimo"].Value = i.minimumStock;

                // Determinar nivel
                string nivel = (i.currentStock >= i.minimumStock) ? "Aceptable" : "Bajo";
                row.Cells["NivelStock"].Value = nivel;

                // Colorear solo la celda "Nivel de Stock"
                if (nivel == "Aceptable")
                    row.Cells["NivelStock"].Style.BackColor = Color.FromArgb(198, 239, 206); // Verde
                else
                    row.Cells["NivelStock"].Style.BackColor = Color.FromArgb(255, 199, 206); // Rojo
            }

            int totalPages = (int)Math.Ceiling((double)allIngredients.Count / pageSize);
            lblPaginacion.Text = $"Página {currentPage} de {totalPages}";
        }


        private void AplicarColoresStock()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["StockActual"].Value != null && row.Cells["StockMinimo"].Value != null)
                {
                    int stockActual = Convert.ToInt32(row.Cells["StockActual"].Value);
                    int stockMinimo = Convert.ToInt32(row.Cells["StockMinimo"].Value);

                    Color colorFila;
                    if (stockActual > stockMinimo)
                        colorFila = Color.FromArgb(198, 239, 206);
                    else if (stockActual == stockMinimo)
                        colorFila = Color.FromArgb(255, 235, 156);
                    else
                        colorFila = Color.FromArgb(255, 199, 206);

                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = colorFila;
                }
            }
        }

        private IconButton CrearIconoBoton(string texto, IconChar icono, string colorFondoHex)
        {
            return new IconButton
            {
                Text = texto,
                IconChar = icono,
                IconColor = Color.White,
                IconFont = IconFont.Auto,
                IconSize = 18,
                TextAlign = ContentAlignment.MiddleRight,
                ImageAlign = ContentAlignment.MiddleLeft,
                BackColor = ColorTranslator.FromHtml(colorFondoHex),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = new Size(110, 30),
                FlatAppearance = { BorderSize = 0 }
            };
        }

        private void EditarSeleccionado()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                var ingrediente = allIngredients.FirstOrDefault(i => i.id == id);

                if (ingrediente != null)
                {
                    using (var modal = new IngredienteModal(ingrediente))
                    {
                        if (modal.ShowDialog() == DialogResult.OK)
                            CargarIngredientes(txtBuscar.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ingrediente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EliminarSeleccionado()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                var confirm = MessageBox.Show("¿Seguro que deseas eliminar este ingrediente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    ingredientController.DeleteIngredient(id);
                    CargarIngredientes(txtBuscar.Text);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ingrediente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
