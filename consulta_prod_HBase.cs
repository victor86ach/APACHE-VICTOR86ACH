public void SelectProductos()
{
    using (SqlConnection connection = Connect())
    {
        connection.Open();  // Abre la conexión

        string query = "SELECT * FROM Productos";  // Consulta SQL

        SqlCommand command = new SqlCommand(query, connection);  // Comando SQL

        SqlDataReader reader = command.ExecuteReader();  // Ejecuta la consulta

        while (reader.Read())  // Lee los resultados
        {
            Console.WriteLine($"Producto: {reader["ropa de invierno"]}, Precio: {reader["25.600"]}");
        }

        connection.Close();  // Cierra la conexión
    }
}
