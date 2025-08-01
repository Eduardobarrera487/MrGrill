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
    public class SaleDetailController
    {
        public bool AddSaleDetail(SaleDetail detail)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string insert = @"INSERT INTO VentaDetalle 
                                (IdVenta, IdProducto, Cantidad, PrecioUnitario, DescuentoAplicado, PrecioFinal, Subtotal)
                                VALUES (@saleId, @productId, @quantity, @unitPrice, @appliedDiscount, @finalPrice, @subtotal)";

                using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@saleId", detail.saleId);
                    command.Parameters.AddWithValue("@productId", detail.productId);
                    command.Parameters.AddWithValue("@quantity", detail.quantity);
                    command.Parameters.AddWithValue("@unitPrice", detail.unitPrice);
                    command.Parameters.AddWithValue("@appliedDiscount", detail.appliedDiscount);
                    command.Parameters.AddWithValue("@finalPrice", detail.finalPrice);
                    command.Parameters.AddWithValue("@subtotal", detail.subtotal);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding sale detail: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<SaleDetail> GetSaleDetails(int saleId)
        {
            List<SaleDetail> details = new List<SaleDetail>();
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = @"SELECT * FROM VentaDetalle WHERE IdVenta = @saleId";

                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@saleId", saleId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            details.Add(new SaleDetail
                            {
                                id = reader.GetInt32("IdVentaDetalle"),
                                saleId = reader.GetInt32("IdVenta"),
                                productId = reader.GetInt32("IdProducto"),
                                quantity = reader.GetInt32("Cantidad"),
                                unitPrice = reader.GetDecimal("PrecioUnitario"),
                                appliedDiscount = reader.GetDecimal("DescuentoAplicado"),
                                finalPrice = reader.GetDecimal("PrecioFinal"),
                                subtotal = reader.GetDecimal("Subtotal")
                            });
                        }
                    }
                }

                return details;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving sale details: " + ex.Message);
                return details;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool DeleteSaleDetail(int saleDetailId)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string delete = "DELETE FROM VentaDetalle WHERE IdVentaDetalle = @id";

                using (MySqlCommand command = new MySqlCommand(delete, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id", saleDetailId);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting sale detail: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
