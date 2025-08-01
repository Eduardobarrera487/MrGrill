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
    public class CashRegisterController
    {
            public bool OpenCashRegister(CashRegister cashRegister)
            {
                Connection connection = new Connection();
                connection.OpenConnection();

                try
                {
                    string insert = @"INSERT INTO Caja 
                                (Fecha, IdUsuario, HoraApertura, MontoInicial, Observaciones) 
                                VALUES (@date, @idUser, @openingTime, @initialAmount, @observations)";

                    using (MySqlCommand command = new MySqlCommand(insert, connection.GetConnection()))
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
                Connection connection = new Connection();
                connection.OpenConnection();

                try
                {
                    string update = @"UPDATE Caja 
                                  SET HoraCierre = @closingTime, MontoFinal = @finalAmount 
                                  WHERE IdCaja = @id";

                    using (MySqlCommand command = new MySqlCommand(update, connection.GetConnection()))
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
    }
}
