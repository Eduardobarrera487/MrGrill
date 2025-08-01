using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrGrill.Models;
using MrGrill.Data;
using MySqlConnector;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;
using MrGrill.SupporterFunctions;
using System.Windows.Forms;


namespace MrGrill.Controllers
{
    public class UserController
    {
        // This class will handle user-related operations such as registration, login, and role management.
        // It will interact with the User model and the database connection to perform these operations.
        public void RegisterUser(User user)
        {
            

            Connection connection = new Connection();
            connection.OpenConnection();
            bool state = true; // Assuming new users are active by default

            string hashedPassword = SecurePasswordHasher.Hash(user.password); //This hashing fuction is defined on supporterFunctions/SecurePasswordHasher.cs    


            // Logic to register a new user
            String statement = "INSERT INTO Usuarios (Nombre, Usuario, Contraseña, Rol, Estado) VALUES (@name, @user, @password, @role, @state)";
            using (MySqlCommand command = new MySqlCommand(statement, connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@name", user.name);
                command.Parameters.AddWithValue("@user", user.user);
                command.Parameters.AddWithValue("@password", hashedPassword);
                command.Parameters.AddWithValue("@role", user.role);
                command.Parameters.AddWithValue("@state", user.state);

                command.ExecuteNonQuery();
            }

            connection.CloseConnection();
        }

        public bool LoginUser(User user)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            string statement = "SELECT Contraseña FROM Usuarios WHERE Usuario = @user";
            using (MySqlCommand command = new MySqlCommand(statement, connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@user", user.user);
                var reader = command.ExecuteReader();


                if (reader.Read())
                {
                    string storedHashedPassword = reader.GetString(0);
                    connection.CloseConnection();
                    return SecurePasswordHasher.Verify(user.password, storedHashedPassword);
                }
                else
                {
                    connection.CloseConnection();
                    return false;
                }
            }
        }

        public void ChangeUserRole(int userId, string newRole)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            string update = "UPDATE Usuarios SET Rol = @role WHERE IdUsuario = @id";
            using (MySqlCommand command = new MySqlCommand(update, connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@role", newRole);
                command.Parameters.AddWithValue("@id", userId);
                command.ExecuteNonQuery();
            }

            connection.CloseConnection();
        }

        public bool ChangePassword(int userId, string newPassword)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            try
            {
                string hashedPassword = SecurePasswordHasher.Hash(newPassword);

                string update = "UPDATE Usuarios SET Contraseña = @password WHERE IdUsuario = @id";
                using (MySqlCommand command = new MySqlCommand(update, connection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    command.Parameters.AddWithValue("@id", userId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cambio de contraseña exitoso.", "Se actualizó la contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    return rowsAffected > 0; // Si se actualizó al menos 1 fila, la operación fue exitosa
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar contraseña.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
