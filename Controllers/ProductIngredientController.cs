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
    public class ProductIngredientController
    {
        public bool AddProductIngredient(ProductIngredient item)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string insert = @"INSERT INTO ProductoIngredientes 
                                (IdProducto, IdIngrediente, Cantidad) 
                                VALUES (@productId, @ingredientId, @quantity)";

                using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@productId", item.productId);
                    command.Parameters.AddWithValue("@ingredientId", item.ingredientId);
                    command.Parameters.AddWithValue("@quantity", item.quantity);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product ingredient: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<ProductIngredient> GetIngredientsByProduct(int productId)
        {
            List<ProductIngredient> list = new List<ProductIngredient>();
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = @"SELECT * FROM ProductoIngredientes WHERE IdProducto = @productId";

                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@productId", productId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ProductIngredient
                            {
                                productId = reader.GetInt32("IdProducto"),
                                ingredientId = reader.GetInt32("IdIngrediente"),
                                quantity = reader.GetDecimal("Cantidad")
                            });
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving ingredients for product: " + ex.Message);
                return list;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool DeleteProductIngredient(int productId, int ingredientId)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string delete = @"DELETE FROM ProductoIngredientes 
                                  WHERE IdProducto = @productId AND IdIngrediente = @ingredientId";

                using (MySqlCommand command = new MySqlCommand(delete, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    command.Parameters.AddWithValue("@ingredientId", ingredientId);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product ingredient: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
