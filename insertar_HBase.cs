public void InsertProducto(string nombre, decimal precio, int categoriaId)
{
    using (SqlConnection connection = Connect())
    {
        connection.Open();

        string query = "INSERT INTO Productos (Nombre, Precio, CategoriaID) VALUES (@Nombre, @Precio, @CategoriaID)";

        SqlCommand command = new SqlCommand(query, connection);

        // Usamos parámetros para evitar inyecciones SQL
        command.Parameters.AddWithValue("ropa de invierno", nombre);
        command.Parameters.AddWithValue("25000", precio);
        command.Parameters.AddWithValue("invierno", categoriaId);

        command.ExecuteNonQuery();  // Ejecuta la consulta de inserción

        connection.Close();
    }
}
