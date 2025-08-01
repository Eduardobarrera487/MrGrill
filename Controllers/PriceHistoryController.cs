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
    public class PriceHistoryController
    {
        public bool AddPriceHistory(PriceHistory history)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string insert = @"INSERT INTO HistorialPrecios 
                                (IdProducto, PrecioAnterior, PrecioNuevo, FechaCambio, IdUsuario)
                                VALUES (@productId, @oldPrice, @newPrice, @changeDate, @userId)";

                using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@productId", history.productId);
                    command.Parameters.AddWithValue("@oldPrice", history.oldPrice);
                    command.Parameters.AddWithValue("@newPrice", history.newPrice);
                    command.Parameters.AddWithValue("@changeDate", history.changeDate);
                    command.Parameters.AddWithValue("@userId", history.userId);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding price history: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<PriceHistory> GetPriceHistoryByProduct(int productId)
        {
            List<PriceHistory> list = new List<PriceHistory>();
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = "SELECT * FROM HistorialPrecios WHERE IdProducto = @productId ORDER BY FechaCambio DESC";

                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@productId", productId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new PriceHistory
                            {
                                id = reader.GetInt32("IdHistorial"),
                                productId = reader.GetInt32("IdProducto"),
                                oldPrice = reader.GetDecimal("PrecioAnterior"),
                                newPrice = reader.GetDecimal("PrecioNuevo"),
                                changeDate = reader.GetDateTime("FechaCambio"),
                                userId = reader.GetInt32("IdUsuario")
                            });
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving price history: " + ex.Message);
                return list;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
