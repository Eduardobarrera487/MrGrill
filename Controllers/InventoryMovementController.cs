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
    public class InventoryMovementController
    {
        public bool AddMovement(InventoryMovement movement)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string insert = @"INSERT INTO MovimientosInventario 
                                (Fecha, IdIngrediente, TipoMovimiento, Cantidad, Observaciones, Referencia)
                                VALUES (@date, @ingredientId, @movementType, @quantity, @observations, @reference)";

                using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@date", movement.date);
                    command.Parameters.AddWithValue("@ingredientId", movement.ingredientId);
                    command.Parameters.AddWithValue("@movementType", movement.movementType);
                    command.Parameters.AddWithValue("@quantity", movement.quantity);
                    command.Parameters.AddWithValue("@observations", movement.observations ?? "");
                    command.Parameters.AddWithValue("@reference", movement.reference ?? "");

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording inventory movement: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<InventoryMovement> GetMovementsByIngredient(int ingredientId)
        {
            List<InventoryMovement> list = new List<InventoryMovement>();
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = @"SELECT * FROM MovimientosInventario 
                                 WHERE IdIngrediente = @ingredientId 
                                 ORDER BY Fecha DESC";

                using (MySqlCommand command = new MySqlCommand(query, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@ingredientId", ingredientId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new InventoryMovement
                            {
                                id = reader.GetInt32("IdMovimiento"),
                                date = reader.GetDateTime("Fecha"),
                                ingredientId = reader.GetInt32("IdIngrediente"),
                                movementType = reader.GetString("TipoMovimiento"),
                                quantity = reader.GetDecimal("Cantidad"),
                                observations = reader.GetString("Observaciones"),
                                reference = reader.GetString("Referencia")
                            });
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving inventory movements: " + ex.Message);
                return list;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
