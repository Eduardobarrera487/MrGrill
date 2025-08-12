using MrGrill.Data;
using MrGrill.Models;
using MySqlConnector;
using System;
using System.Windows.Forms;

namespace MrGrill.Controllers
{
    public class CashRegisterController
    {
        public bool OpenCashRegister(CashRegister cashRegister)
        {
            var connection = new Connection();
            connection.OpenConnection();

            try
            {
                const string insert = @"INSERT INTO Caja 
                    (Fecha, IdUsuario, HoraApertura, MontoInicial, Observaciones) 
                    VALUES (@date, @idUser, @openingTime, @initialAmount, @observations)";

                using (var command = new MySqlCommand(insert, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@date", cashRegister.date);
                    command.Parameters.AddWithValue("@idUser", cashRegister.idUser);
                    command.Parameters.AddWithValue("@openingTime", cashRegister.OpeningTime);
                    command.Parameters.AddWithValue("@initialAmount", cashRegister.initialAmount);
                    command.Parameters.AddWithValue("@observations", cashRegister.observations ?? "");
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening cash register: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool CloseCashRegister(int idCashRegister, DateTime closingTime, decimal finalAmount)
        {
            var connection = new Connection();
            connection.OpenConnection();

            try
            {
                const string update = @"UPDATE Caja 
                    SET HoraCierre = @closingTime, MontoFinal = @finalAmount 
                    WHERE IdCaja = @id";

                using (var command = new MySqlCommand(update, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@closingTime", closingTime);
                    command.Parameters.AddWithValue("@finalAmount", finalAmount);
                    command.Parameters.AddWithValue("@id", idCashRegister);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing cash register: " + ex.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        // ====== AUXILIARES AÑADIDOS ======

        public CashRegister GetOpenCashRegisterForToday(int idUser)
        {
            var connection = new Connection();
            connection.OpenConnection();
            try
            {
                const string sql = @"SELECT IdCaja, Fecha, IdUsuario, HoraApertura, MontoInicial, 
                                            HoraCierre, MontoFinal, Observaciones
                                     FROM Caja
                                     WHERE IdUsuario = @idUser AND Fecha = CURDATE() AND HoraCierre IS NULL
                                     ORDER BY IdCaja DESC
                                     LIMIT 1";
                using (var cmd = new MySqlCommand(sql, connection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            return new CashRegister
                            {
                                id = rd.GetInt32("IdCaja"),
                                date = rd.GetDateTime("Fecha"),
                                idUser = rd.GetInt32("IdUsuario"),
                                OpeningTime = rd.GetDateTime("HoraApertura"),
                                initialAmount = rd.GetDecimal("MontoInicial"),
                                closingTime = rd.IsDBNull(rd.GetOrdinal("HoraCierre")) ? (DateTime?)null : rd.GetDateTime("HoraCierre"),
                                finalAmount = rd.IsDBNull(rd.GetOrdinal("MontoFinal")) ? (decimal?)null : rd.GetDecimal("MontoFinal"),
                                observations = rd.IsDBNull(rd.GetOrdinal("Observaciones")) ? "" : rd.GetString("Observaciones")
                            };
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cash register: " + ex.Message);
                return null;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public int? GetLastCashRegisterIdForToday(int idUser)
        {
            var connection = new Connection();
            connection.OpenConnection();
            try
            {
                const string sql = @"SELECT IdCaja
                                     FROM Caja
                                     WHERE IdUsuario = @idUser AND Fecha = CURDATE()
                                     ORDER BY IdCaja DESC
                                     LIMIT 1";
                using (var cmd = new MySqlCommand(sql, connection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    var obj = cmd.ExecuteScalar();
                    if (obj != null && obj != DBNull.Value)
                        return Convert.ToInt32(obj);
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting last cash id: " + ex.Message);
                return null;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
