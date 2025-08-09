using MrGrill.Controllers;
using MrGrill.Models;
using MrGrill.SupporterFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MrGrill.SupporterFunctions.UIFeatures;

namespace MrGrill.Views
{
    public partial class CategoryView : Form
    {
        private int? categoryEditing = null;  
        public CategoryView()
        {
            InitializeComponent();
        }

        private void CategoryView_Load(object sender, EventArgs e)
        {
            CargarProductosEnGaleria();
        }

        private void CargarProductosEnGaleria()
        {
            flowLayoutCategories.Controls.Clear();
            ProductController controller = new ProductController();
            List <Category> categories = new CategoryController().GetCategories();

            foreach (var category in categories)
            {
                
                    AddCategoryToCard(category);
                
            }
        }

        private void AddCategoryToCard(Category category)
        {
            Panel panel = new Panel
            {
                Width = 250,
                Height = 150,
                Margin = new Padding(10),
                BackColor = ColorTranslator.FromHtml("#1F2327"), // fondo oscuro moderno
                BorderStyle = BorderStyle.FixedSingle,
            };
            UIFeatures.RedondearPanel(panel, 15);

            // Sombra sutil
            panel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
                    Color.FromArgb(50, 0, 0, 0), 3, ButtonBorderStyle.Solid,
                    Color.FromArgb(50, 0, 0, 0), 3, ButtonBorderStyle.Solid,
                    Color.FromArgb(50, 0, 0, 0), 3, ButtonBorderStyle.Solid,
                    Color.FromArgb(50, 0, 0, 0), 3, ButtonBorderStyle.Solid);
            };

            Label lblNombre = new Label
            {
                Text = category.Name,
                Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 50,
                Padding = new Padding(5),
            };

            // Panel para botones
            Panel panelBotones = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                Padding = new Padding(10),
                BackColor = Color.Transparent,
            };

            Button btnEditar = new Button
            {
                Text = "Editar",
                Width = 100,
                Height = 30,
                BackColor = ColorTranslator.FromHtml("#F39C12"), // naranja
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Cursor = Cursors.Hand,
                Tag = category
            };
            btnEditar.FlatAppearance.BorderSize = 0;
            RedondearBoton(btnEditar, 10);
            btnEditar.Click += (s, e) =>
            {
                LoadCategoryToForm((Category)((Button)s).Tag);
            };

            Button btnEliminar = new Button
            {
                Text = "Eliminar",
                Width = 100,
                Height = 30,
                BackColor = ColorTranslator.FromHtml("#E74C3C"), // rojo
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Cursor = Cursors.Hand,
                Tag = category
            };
            btnEliminar.FlatAppearance.BorderSize = 0;
            RedondearBoton(btnEliminar, 10);
            btnEliminar.Click += (s, e) =>
            {
                // Aquí puedes llamar al método para eliminar directamente, o abrir confirmación
                categoryEditing = ((Category)((Button)s).Tag).Id;
                rjButton1_Click(s, e);  // Reusa tu función eliminar
            };

            // Añadir botones al panel de botones
            panelBotones.Controls.Add(btnEditar);
            panelBotones.Controls.Add(btnEliminar);

            // Ajustar ubicación botones lado a lado
            btnEditar.Location = new Point(10, 10);
            btnEliminar.Location = new Point(130, 10);

            // Añadir controles al panel principal
            panel.Controls.Add(lblNombre);
            panel.Controls.Add(panelBotones);

            flowLayoutCategories.Controls.Add(panel);
        }

        private void LoadCategoryToForm(Category category)
        {
            categoryEditing = category.Id;
            txtCategoryName.Text = category.Name;
          
        }

        private void FilterCategory(string texto)
        {
            flowLayoutCategories.Controls.Clear();

           
            List<MrGrill.Models.Category> categories = new CategoryController().GetCategories();

            // Filtro por nombre de  categoría
            var filtrados = string.IsNullOrWhiteSpace(texto)
                ? categories // texto vacío, devolver todo
                : categories.Where(c => c.Name.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            // Renderizar las categorías  filtrados
            foreach (var categoria in filtrados)
            {
                AddCategoryToCard(categoria);
            }
        }

        private void txtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            FilterCategory(txtSearchCategory.Text.Trim());
        }


        private void LimpiarFormulario()
        {
            txtCategoryName.Text = "";
          
            categoryEditing = null; // volver a modo nuevo

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category
                {
                    Id = categoryEditing ?? 0, // usar si es edición
                    Name = txtCategoryName.Text.Trim(),
                    Estado = "Activo" // Asignar estado por defecto
                    
                };

                CategoryController controller = new CategoryController();
                bool resultado;

                if (categoryEditing.HasValue)
                {
                    resultado = controller.Update(category);
                }
                else
                {
                    resultado = controller.addCategory(category);
                }

                if (resultado)
                {
                    MessageBox.Show(categoryEditing.HasValue ? "Categoría actualizada correctamente." : "Categoría guardada correctamente.");
                    LimpiarFormulario();
                    CargarProductosEnGaleria();
                }
                else
                {
                    MessageBox.Show("Error al guardar la Categoría.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (!categoryEditing.HasValue)
            {
                MessageBox.Show("Selecciona una categoría para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar esta categoría?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    CategoryController controller = new CategoryController();
                    bool eliminado = controller.Delete(categoryEditing.Value);

                    if (eliminado)
                    {
                        MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarProductosEnGaleria();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
