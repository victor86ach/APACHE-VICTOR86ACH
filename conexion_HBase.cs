using System;
using System.Data.SqlClient;

public class DatabaseConnection
{
    public SqlConnection Connect()
    {
        // Cadena de conexión
        string connectionString = "Server=127.0.0.1;Database=hbase123456;User Id=SQL_Latin1_General_CP1_CI_AS;Password=tuContraseña;";

        // Crear conexión
        SqlConnection connection = new SqlConnection(connectionString);
        return connection;
    }
}
