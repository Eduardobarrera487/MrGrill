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
    public class PromotionProductController
    {
        public bool AddPromotionProduct(PromotionProduct pp)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string insert = @"INSERT INTO PromocionProductos (IdPromocion, IdProducto) 
                                  VALUES (@promotionId, @productId)";

                using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@promotionId", pp.promotionId);
                    command.Parameters.AddWithValue("@productId", pp.productId);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product to promotion: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<PromotionProduct> GetProductsByPromotion(int promotionId)
        {
            List<PromotionProduct> list = new List<PromotionProduct>();
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = @"SELECT * FROM PromocionProductos WHERE IdPromocion = @promotionId";

                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@promotionId", promotionId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new PromotionProduct
                            {
                                promotionId = reader.GetInt32("IdPromocion"),
                                productId = reader.GetInt32("IdProducto")
                            });
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving products for promotion: " + ex.Message);
                return list;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool DeletePromotionProduct(int promotionId, int productId)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string delete = @"DELETE FROM PromocionProductos 
                                  WHERE IdPromocion = @promotionId AND IdProducto = @productId";

                using (MySqlCommand command = new MySqlCommand(delete, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@promotionId", promotionId);
                    command.Parameters.AddWithValue("@productId", productId);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting promotion-product relation: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
