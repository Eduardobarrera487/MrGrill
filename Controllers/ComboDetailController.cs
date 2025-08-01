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
    public class ComboDetailController
    {
        public bool AddComboDetail(ComboDetail detail)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string insert = @"INSERT INTO CombosDetalle (IdCombo, IdProducto, Cantidad) 
                                  VALUES (@comboId, @productId, @quantity)";

                using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@comboId", detail.comboId);
                    command.Parameters.AddWithValue("@productId", detail.productId);
                    command.Parameters.AddWithValue("@quantity", detail.quantity);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding combo detail: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<ComboDetail> GetComboDetails(int comboId)
        {
            List<ComboDetail> details = new List<ComboDetail>();
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = "SELECT * FROM CombosDetalle WHERE IdCombo = @comboId";

                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@comboId", comboId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            details.Add(new ComboDetail
                            {
                                comboId = reader.GetInt32("IdCombo"),
                                productId = reader.GetInt32("IdProducto"),
                                quantity = reader.GetInt32("Cantidad")
                            });
                        }
                    }
                }

                return details;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving combo details: " + ex.Message);
                return details;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool DeleteComboDetail(int comboId, int productId)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string delete = "DELETE FROM CombosDetalle WHERE IdCombo = @comboId AND IdProducto = @productId";

                using (MySqlCommand command = new MySqlCommand(delete, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@comboId", comboId);
                    command.Parameters.AddWithValue("@productId", productId);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting combo detail: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
