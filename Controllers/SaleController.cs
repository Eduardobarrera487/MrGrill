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
    public class SaleController
    {
        public bool AddSale(Sale sale)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string insert = @"INSERT INTO Ventas 
                                (Fecha, IdUsuario, Total, MetodoPago, Estado) 
                                VALUES (@date, @userId, @total, @paymentMethod, @status)";

                using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@date", sale.date);
                    command.Parameters.AddWithValue("@userId", sale.userId);
                    command.Parameters.AddWithValue("@total", sale.total);
                    command.Parameters.AddWithValue("@paymentMethod", sale.paymentMethod);
                    command.Parameters.AddWithValue("@status", sale.status);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding sale: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<Sale> GetSales()
        {
            List<Sale> sales = new List<Sale>();
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = "SELECT * FROM Ventas ORDER BY Fecha DESC";

                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sales.Add(new Sale
                        {
                            id = reader.GetInt32("IdVenta"),
                            date = reader.GetDateTime("Fecha"),
                            userId = reader.GetInt32("IdUsuario"),
                            total = reader.GetDecimal("Total"),
                            paymentMethod = reader.GetString("MetodoPago"),
                            status = reader.GetString("Estado")
                        });
                    }
                }

                return sales;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving sales: " + ex.Message);
                return sales;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool UpdateSaleStatus(int saleId, string newStatus)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string update = "UPDATE Ventas SET Estado = @status WHERE IdVenta = @id";

                using (MySqlCommand command = new MySqlCommand(update, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@status", newStatus);
                    command.Parameters.AddWithValue("@id", saleId);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating sale status: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
