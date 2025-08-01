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
    public class PromotionController
    {
        public bool AddPromotion(Promotion promo)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string insert = @"INSERT INTO Promociones 
                                (Nombre, Descripcion, Tipo, PorcentajeDescuento, MontoDescuento, FechaInicio, FechaFin, Activa) 
                                VALUES (@name, @description, @type, @discountPercentage, @discountAmount, @startDate, @endDate, @isActive)";

                using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@name", promo.name);
                    command.Parameters.AddWithValue("@description", promo.description);
                    command.Parameters.AddWithValue("@type", promo.type);
                    command.Parameters.AddWithValue("@discountPercentage", promo.discountPercentage.HasValue ? promo.discountPercentage : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@discountAmount", promo.discountAmount.HasValue ? promo.discountAmount : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@startDate", promo.startDate);
                    command.Parameters.AddWithValue("@endDate", promo.endDate);
                    command.Parameters.AddWithValue("@isActive", promo.isActive);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding promotion: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<Promotion> GetAllPromotions()
        {
            List<Promotion> list = new List<Promotion>();
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = "SELECT * FROM Promociones";
                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Promotion
                        {
                            id = reader.GetInt32("IdPromocion"),
                            name = reader.GetString("Nombre"),
                            description = reader.GetString("Descripcion"),
                            type = reader.GetString("Tipo"),
                            discountPercentage = reader.IsDBNull(reader.GetOrdinal("PorcentajeDescuento")) ? null : reader.GetDecimal("PorcentajeDescuento"),
                            discountAmount = reader.IsDBNull(reader.GetOrdinal("MontoDescuento")) ? null : reader.GetDecimal("MontoDescuento"),
                            startDate = reader.GetDateTime("FechaInicio"),
                            endDate = reader.GetDateTime("FechaFin"),
                            isActive = reader.GetBoolean("Activa")
                        });
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving promotions: " + ex.Message);
                return list;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool UpdatePromotion(Promotion promo)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string update = @"UPDATE Promociones SET 
                                Nombre = @name, Descripcion = @description, Tipo = @type, 
                                PorcentajeDescuento = @discountPercentage, MontoDescuento = @discountAmount, 
                                FechaInicio = @startDate, FechaFin = @endDate, Activa = @isActive
                                WHERE IdPromocion = @id";

                using (MySqlCommand command = new MySqlCommand(update, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@name", promo.name);
                    command.Parameters.AddWithValue("@description", promo.description);
                    command.Parameters.AddWithValue("@type", promo.type);
                    command.Parameters.AddWithValue("@discountPercentage", promo.discountPercentage.HasValue ? promo.discountPercentage : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@discountAmount", promo.discountAmount.HasValue ? promo.discountAmount : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@startDate", promo.startDate);
                    command.Parameters.AddWithValue("@endDate", promo.endDate);
                    command.Parameters.AddWithValue("@isActive", promo.isActive);
                    command.Parameters.AddWithValue("@id", promo.id);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating promotion: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool DeletePromotion(int promoId)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string delete = "DELETE FROM Promociones WHERE IdPromocion = @id";

                using (MySqlCommand command = new MySqlCommand(delete, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id", promoId);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting promotion: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
