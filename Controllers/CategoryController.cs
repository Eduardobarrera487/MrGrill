using MrGrill.Data;
using MrGrill.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MrGrill.Controllers
{
    public class CategoryController
    {
        public bool addCategory(Category category)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string insert = @"INSERT INTO Categorias (Nombre) VALUES (@name)";

                using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@name", category.Name);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }   


        public int getCategoryID(String categoryName)
        {
            categoryName = categoryName.Trim();
            Connection connection = new Connection();
            connection.OpenConnection();
            try
            {
                string query = "SELECT IdCategoria FROM Categorias WHERE Nombre = @name";
                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@name", categoryName);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // Category not found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving category ID: " + ex.Message);
                return -1;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

      public bool Update(Category category)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string update = @"UPDATE Categorias SET Nombre = @name WHERE IdCategoria = @id";

                using (MySqlCommand command = new MySqlCommand(update, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@name", category.Name);
                    command.Parameters.AddWithValue("@id", category.Id);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool Delete(int categoryId)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string delete = "UPDATE Categorias SET Estado = 'Inactivo' WHERE IdCategoria = @id";

                using (MySqlCommand command = new MySqlCommand(delete, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id", categoryId);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting category: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<Category> GetCategories()
        {
            List <Category > categories = new List<Category>();
            Connection connection = new Connection();
            connection.OpenConnection();


            try
            {
                string query = "SELECT * FROM Categorias Where Estado = 'Activo'";
                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category category = new Category
                        {
                            Id = reader.GetInt32("IdCategoria"),
                            Name = reader.GetString("Nombre"),
                        };

                        categories.Add(category);
                    }
                }

                return categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving categories: " + ex.Message);

                return categories;
            }
            finally
            {
                connection.CloseConnection();
            }
            
          
        }
    }
    
}
