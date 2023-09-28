using System.Data.SqlClient;
using Dapper;

namespace Registrarse;

public class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=PreguntadOrt;Trusted_Connection=True;";

    public  static void registrarUsuario ( usuario U)
    {
        string SQL = "INSERT INTO Usuario (id, UserName, contraseña, nombre, email, telefono) VALUES (@USERNAME, @CONTRASEÑA, @NOMBRE, @EMAIL, @TELEFONO)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(SQL, new {USERNAME= U.UserName, CONTRASEÑA=U.contraseña, NOMBRE=U.nombre, EMAIL=U.email, TELEFONO=U.telefono });
        }
    }
    
}