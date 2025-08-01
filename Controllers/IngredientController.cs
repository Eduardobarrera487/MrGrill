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
    public class IngredientController
    {
        public bool AddIngredient(Ingredient ingredient)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string insert = @"INSERT INTO Ingredientes 
                                (Nombre, Unidad, StockActual, StockMinimo) 
                                VALUES (@name, @unit, @currentStock, @minimumStock)";

                using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@name", ingredient.name);
                    command.Parameters.AddWithValue("@unit", ingredient.unit);
                    command.Parameters.AddWithValue("@currentStock", ingredient.currentStock);
                    command.Parameters.AddWithValue("@minimumStock", ingredient.minimumStock);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding ingredient: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<Ingredient> GetAllIngredients()
        {
            List<Ingredient> list = new List<Ingredient>();
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = "SELECT * FROM Ingredientes";

                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Ingredient
                        {
                            id = reader.GetInt32("IdIngrediente"),
                            name = reader.GetString("Nombre"),
                            unit = reader.GetString("Unidad"),
                            currentStock = reader.GetDecimal("StockActual"),
                            minimumStock = reader.GetDecimal("StockMinimo")
                        });
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving ingredients: " + ex.Message);
                return list;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool UpdateIngredientStock(int id, decimal newStock)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string update = "UPDATE Ingredientes SET StockActual = @newStock WHERE IdIngrediente = @id";

                using (MySqlCommand command = new MySqlCommand(update, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@newStock", newStock);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating ingredient stock: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool DeleteIngredient(int id)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string delete = "DELETE FROM Ingredientes WHERE IdIngrediente = @id";

                using (MySqlCommand command = new MySqlCommand(delete, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting ingredient: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
