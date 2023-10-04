using System.Data.SqlClient;
using Dapper;

namespace Registrarse;

public class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=Registrarse;Trusted_Connection=True;";

    public  static void registrarUsuario ( usuario U)
    {
        string SQL = "INSERT INTO Usuario (id, UserName, contraseña, nombre, email, telefono) VALUES (@USERNAME, @CONTRASEÑA, @NOMBRE, @EMAIL, @TELEFONO)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(SQL, new {USERNAME= U.UserName, CONTRASEÑA=U.contraseña, NOMBRE=U.nombre, EMAIL=U.email, TELEFONO=U.telefono });
        }
    }

    public static usuario verificarUsuario (string username, string contrasena)
    {   
        usuario miUsuario = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Usuario where username = @pusername AND contraseña = @pcontrasena";
            miUsuario= db.QueryFirstOrDefault<usuario>(sql, new {pusername = username, pcontrasena=contrasena});
        }
        return miUsuario;
    }

      public static usuario verificarEmail (string email)
    {   
        usuario miUsuario = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Usuario where email = @pemail";
            miUsuario= db.QueryFirstOrDefault<usuario>(sql, new {pemail = email});
        }
        return miUsuario;
    }



    
  

    
}