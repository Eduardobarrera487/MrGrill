using MrGrill.Data;
using MrGrill.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrGrill.Controllers
{
    public class ProductController
    {
        public bool AddProduct(Product product)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string insert = @"INSERT INTO Productos 
                        (Nombre, Descripcion, Precio, Categoria, EsCombo, Activo, Foto) 
                        VALUES (@name, @description, @price, @category, @isCombo, @isActive, @photo)";

                using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@name", product.name);
                    command.Parameters.AddWithValue("@description", product.description);
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@category", product.category);
                    command.Parameters.AddWithValue("@isCombo", product.isCombo);
                    command.Parameters.AddWithValue("@isActive", product.isActive);
                    command.Parameters.AddWithValue("@photo", product.photo);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = "SELECT * FROM Productos";
                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            id = reader.GetInt32("IdProducto"),
                            name = reader.GetString("Nombre"),
                            description = reader.GetString("Descripcion"),
                            price = reader.GetDecimal("Precio"),
                            category = reader.GetString("Categoria"),
                            isCombo = reader.GetBoolean("EsCombo"),
                            isActive = reader.GetBoolean("Activo"),
                            photo = reader["Foto"] != DBNull.Value ? reader.GetString("Foto") : null 

                        };

                        products.Add(product);
                    }
                }

                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving products: " + ex.Message);
                return products;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool UpdateProduct(Product product)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string update = @"UPDATE Productos 
                        SET Nombre = @name, Descripcion = @description, Precio = @price, 
                            Categoria = @category, EsCombo = @isCombo, Activo = @isActive, Foto = @photo
                        WHERE IdProducto = @id";

                using (MySqlCommand command = new MySqlCommand(update, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@name", product.name);
                    command.Parameters.AddWithValue("@description", product.description);
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@category", product.category);
                    command.Parameters.AddWithValue("@isCombo", product.isCombo);
                    command.Parameters.AddWithValue("@isActive", product.isActive);
                    command.Parameters.AddWithValue("@photo", product.photo); // 👈 NUEVO
                    command.Parameters.AddWithValue("@id", product.id);

                    command.ExecuteNonQuery();
                }


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool DeleteProduct(int productId)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string delete = "DELETE FROM Productos WHERE IdProducto = @id";

                using (MySqlCommand command = new MySqlCommand(delete, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id", productId);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
