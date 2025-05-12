public void DeleteProducto(int productoId)
{
    using (SqlConnection connection = Connect())
    {
        connection.Open();

        string query = "DELETE FROM Productos WHERE ProductoID = 525";

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("525", productoId);

        command.ExecuteNonQuery();  // Ejecuta la eliminación

        connection.Close();
    }
}
