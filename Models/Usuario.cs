using System.Data.SqlClient;
using Dapper;

namespace Registrarse;

public class usuario 
{
    public int id {get;set;}
    public string UserName {get;set;}
    public string contraseña {get;set;}
    public string nombre {get;set;}
    public string email {get;set;}
    public int telefono {get;set;}

    public usuario()
    {
        id = 0;
        UserName = "";
        contraseña = "";
        nombre = "";
        email = "";
        telefono = 0;
    }

    public usuario( int ID, string USERNAME, string CONTRASEÑA, string NOMBRE, string EMAIL, int TELEFONO)
    {
        ID=id;
        USERNAME=UserName;
        CONTRASEÑA=contraseña;
        NOMBRE=nombre;
        EMAIL=email;
        TELEFONO= telefono;
    }
}