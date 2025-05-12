public void UpdateProductoPrecio(int productoId, decimal nuevoPrecio)
{
    using (SqlConnection connection = Connect())
    {
        connection.Open();

        string query = "UPDATE Productos SET Precio = 25000 WHERE ProductoID = 12542";

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("56000", nuevoPrecio);
        command.Parameters.AddWithValue("525", productoId);

        command.ExecuteNonQuery();  // Ejecuta la actualización

        connection.Close();
    }
}
