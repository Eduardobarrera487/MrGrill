using MrGrill.Data;
using MrGrill.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGrill.Controllers
{
    internal class CashRegisterMovementsController
    {
        public List<Dictionary<string, object>> GetCashRegisterMovements()
        {
            List<Dictionary<string, object>> lista = new List<Dictionary<string, object>>();

            var connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = "SELECT * FROM MovimientosCaja";
                using (var cmd = new MySqlCommand(query, connection.GetConnection()))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var fila = new Dictionary<string, object>
                            {
                                ["IdMovimiento"] = reader["IdMovimiento"],
                                ["IdCaja"] = reader["IdCaja"],
                                ["Fecha"] = reader["Fecha"],
                                ["Tipo"] = reader["Tipo"],
                                ["Monto"] = reader["Monto"],
                                ["Descripcion"] = reader["Descripcion"]
                            };
                            lista.Add(fila);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving cash register movements: " + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            return lista; // fuera del while ✅
        }

        public Dictionary<string, object> GetCashRegisterMovementById(int idMovimiento)
        {
            Dictionary<string, object> fila = null;
            var connection = new Connection();
            connection.OpenConnection();

            try
            {
                string query = "SELECT * FROM MovimientosCaja WHERE IdMovimiento = @IdMovimiento";
                using (var cmd = new MySqlCommand(query, connection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdMovimiento", idMovimiento);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            fila = new Dictionary<string, object>
                            {
                                ["IdMovimiento"] = reader["IdMovimiento"],
                                ["IdCaja"] = reader["IdCaja"],
                                ["Fecha"] = reader["Fecha"],
                                ["Tipo"] = reader["Tipo"],
                                ["Monto"] = reader["Monto"],
                                ["Descripcion"] = reader["Descripcion"]
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving movement by Id: " + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            return fila;
        }

        // Crear un movimiento
        public bool CreateCashRegisterMovement(int idCaja, DateTime fecha, string tipo, decimal monto, string descripcion)
        {
            var connection = new Connection();
            connection.OpenConnection();
            bool result = false;

            try
            {
                string query = @"INSERT INTO MovimientosCaja (IdCaja, Fecha, Tipo, Monto, Descripcion)
                                 VALUES (@IdCaja, @Fecha, @Tipo, @Monto, @Descripcion)";

                using (var cmd = new MySqlCommand(query, connection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdCaja", idCaja);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion ?? (object)DBNull.Value);

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating movement: " + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            return result;
        }

        // Actualizar un movimiento
        public bool UpdateCashRegisterMovement(int idMovimiento, int idCaja, DateTime fecha, string tipo, decimal monto, string descripcion)
        {
            var connection = new Connection();
            connection.OpenConnection();
            bool result = false;

            try
            {
                string query = @"UPDATE MovimientosCaja 
                                 SET IdCaja=@IdCaja, Fecha=@Fecha, Tipo=@Tipo, Monto=@Monto, Descripcion=@Descripcion
                                 WHERE IdMovimiento=@IdMovimiento";

                using (var cmd = new MySqlCommand(query, connection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdMovimiento", idMovimiento);
                    cmd.Parameters.AddWithValue("@IdCaja", idCaja);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion ?? (object)DBNull.Value);

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating movement: " + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            return result;
        }

        // Eliminar un movimiento
        public bool DeleteCashRegisterMovement(int idMovimiento)
        {
            var connection = new Connection();
            connection.OpenConnection();
            bool result = false;

            try
            {
                string query = "DELETE FROM MovimientosCaja WHERE IdMovimiento=@IdMovimiento";
                using (var cmd = new MySqlCommand(query, connection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdMovimiento", idMovimiento);
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting movement: " + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            return result;
        }

    }

}
