using MrGrill.Controllers;
using MrGrill.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static MrGrill.SupporterFunctions.UIFeatures;
using MrGrill.SupporterFunctions;


namespace MrGrill.Views
{
    public partial class ProductsVIew : Form
    {
        public ProductsVIew()
        {
            InitializeComponent();
        }

        private string photoUrl = "";
        private int? productoEditandoId = null; // null = nuevo producto





        private void btnPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar imagen del producto";
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    photoUrl = openFileDialog.FileName; // Guardamos la ruta
                    pictureBoxPhoto.Image = Image.FromFile(photoUrl); // Mostramos imagen
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product producto = new Product
                {
                    id = productoEditandoId ?? 0, // usar si es edición
                    name = txtProductName.Text.Trim(),
                    description = txtDescription.Text.Trim(),
                    price = nPadPrice.Value,
                    category = cmbCategory.SelectedItem?.ToString() ?? "",
                    isCombo = cmbCombo.SelectedItem?.ToString() == "Sí",
                    isActive = rbuttonActive.Checked,
                    photo = photoUrl
                };

                ProductController controller = new ProductController();
                bool resultado;

                if (productoEditandoId.HasValue)
                {
                    resultado = controller.UpdateProduct(producto);
                }
                else
                {
                    resultado = controller.AddProduct(producto);
                }

                if (resultado)
                {
                    MessageBox.Show(productoEditandoId.HasValue ? "Producto actualizado correctamente." : "Producto guardado correctamente.");
                    LimpiarFormulario();
                    CargarProductosEnGaleria();
                }
                else
                {
                    MessageBox.Show("Error al guardar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ProductsVIew_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.AddRange(new string[] { "Hamburguesas", "Bebidas", "Acompañamientos", "Postres", "Extras", "Chunks", "Nachos", "Quesadillas", "Res", "Salchipapa", "Wraps" });
            cmbCombo.Items.AddRange(new string[] { "Sí", "No" });
            txtSearchProduct.Text = "";
            txtSearchProduct.Width = 200;
            txtSearchProduct.Height = 30;


            CargarProductosEnGaleria();
        }

        private void LimpiarFormulario()
        {
            txtProductName.Text = "";
            txtDescription.Text = "";
            nPadPrice.Value = 0;
            cmbCategory.SelectedIndex = -1;
            cmbCombo.SelectedIndex = -1;
            rbuttonActive.Checked = true;
            pictureBoxPhoto.Image = null;
            photoUrl = "";
            productoEditandoId = null; // volver a modo nuevo

        }

        private void CargarProductosEnGaleria()
        {
            flowLayoutProducts.Controls.Clear();
            ProductController controller = new ProductController();
            List<Product> productos = controller.GetAllProducts();

            foreach (var producto in productos)
            {
                AgregarProductoATarjeta(producto);
            }
        }

        private void CargarProductoEnFormulario(Product producto)
        {
            productoEditandoId = producto.id;
            txtProductName.Text = producto.name;
            txtDescription.Text = producto.description;
            nPadPrice.Value = producto.price;
            cmbCategory.SelectedItem = producto.category;
            cmbCombo.SelectedItem = producto.isCombo ? "Sí" : "No";
            rbuttonActive.Checked = producto.isActive;
            photoUrl = producto.photo;

            if (!string.IsNullOrEmpty(photoUrl) && File.Exists(photoUrl))
            {
                pictureBoxPhoto.Image = Image.FromFile(photoUrl);
                pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBoxPhoto.Image = null;
            }
        }


        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos(txtSearchProduct.Text.Trim());

        }

        private void FiltrarProductos(string texto)
        {
            flowLayoutProducts.Controls.Clear();

            ProductController controller = new ProductController();
            List<Product> productos = controller.GetAllProducts();

            // Filtro por nombre, descripción o categoría
            var filtrados = productos.Where(p =>
                p.name.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                p.description.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                p.category.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            // Renderizar los productos filtrados
            foreach (var producto in filtrados)
            {
                AgregarProductoATarjeta(producto);
            }
        }

        private void AgregarProductoATarjeta(Product producto)
        {
            Panel panel = new Panel();
            panel.Width = 230;
            panel.Height = 290;
            panel.Margin = new Padding(12);
            panel.BorderStyle = BorderStyle.None;
            panel.BackColor = ColorTranslator.FromHtml("#2C2F33"); 
            UIFeatures.RedondearPanel(panel, 20); // Redondear esquinas del panel

            PictureBox pic = new PictureBox();
            pic.Size = new Size(200, 120);
            pic.Location = new Point(15, 10);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.BorderStyle = BorderStyle.FixedSingle;

            try
            {
                if (!string.IsNullOrEmpty(producto.photo) && File.Exists(producto.photo))
                    pic.Image = Image.FromFile(producto.photo);
                else
                    pic.Image = SystemIcons.Question.ToBitmap();
            }
            catch
            {
                pic.Image = SystemIcons.Question.ToBitmap();
            }

            Label lblNombre = new Label
            {
                Text = producto.name,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Width = panel.Width,
                Location = new Point(0, 140),
                ForeColor = ColorTranslator.FromHtml("#F0F0F0")
            };

            Label lblPrecio = new Label
            {
                Text = $"${producto.price:F2}",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(15, 170),
                AutoSize = true,
                ForeColor = ColorTranslator.FromHtml("#1ABC9C")
            };

            Label lblCategoria = new Label
            {
                Text = producto.category,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(15, 190),
                AutoSize = true,
                ForeColor = ColorTranslator.FromHtml("#F0F0F0")
            };

            Label lblEstado = new Label
            {
                Text = producto.isActive ? "Activo" : "Inactivo",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                Location = new Point(15, 210),
                AutoSize = true,
                ForeColor = producto.isActive
                    ? ColorTranslator.FromHtml("#2ECC71")
                    : ColorTranslator.FromHtml("#C0392B")
            };

            Button btnEditar = new Button
            {
                Text = "Editar",
                Width = 180,
                Height = 30,
                Location = new Point(25, 240),
                Tag = producto,
            };
            btnEditar.FlatAppearance.BorderSize = 0;
            UIFeatures.EstilizarBotonPlano(btnEditar, "#D35400");
            RedondearBoton(btnEditar, 15);

            btnEditar.Click += (s, e) =>
            {
                CargarProductoEnFormulario((Product)((Button)s).Tag);
            };

            panel.Controls.Add(pic);
            panel.Controls.Add(lblNombre);
            panel.Controls.Add(lblPrecio);
            panel.Controls.Add(lblCategoria);
            panel.Controls.Add(lblEstado);
            panel.Controls.Add(btnEditar);

            flowLayoutProducts.Controls.Add(panel);
        }

    }
}
