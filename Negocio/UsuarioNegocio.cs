using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BCrypt.Net;
using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        
        public Usuario Login(string email, string password)
        {
            Usuario usuarioLogin = new Usuario();
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader lector;

            //tenemos que crear el acceso a la base de datos 
            // el comando de consulta sql para hacer la peticion a la base de datos
            //Ver como se implementa la encriptacion de datos 
            //dar la respuesta al login de si esta o si lo tiene que crear 
            try
            {
                Conexion.ConnectionString = "server=.\\MSSQLLocalDB; database=TALLERAUTOMOTOR; integrated security=true;";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "SELECT Nombre, Password, Rol, Activo from Usuario WHERE Email = @Email And Activo = 1";
                Comando.Parameters.AddWithValue("@Email", email);
                Comando.Connection = Conexion;

                Conexion.Open();
                lector = Comando.ExecuteReader();

                if (lector.Read()) {

                    usuarioLogin.Nombre = (string)lector["Nombre"];
                    usuarioLogin.Password = (string)lector["Password"];
                    usuarioLogin.Roll = (string)lector["Rol"];
                    if (BCrypt.Net.BCrypt.Verify(password, usuarioLogin.Password))
                    {
                        return usuarioLogin;
                    }
                    else 
                    {
                        return null;
                    }

                
            }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexion.Close();
            }

    }

        public void Registrar(Usuario usuario) { 
        
        }
}
}
