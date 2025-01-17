using System;
using System.Data;
using System.Data.SQLite;

/// <summary>
/// Clase <c>Database</c>: Proporciona los métodos para crear e interactuar con la base de datos SQLite local que utiliza el proyecto..
/// </summary>
public class Database
{
    private readonly string connectionString = "Data Source=database.db;Version=3;";

    /// <summary>
    /// Constructor de la clase <c>Database</c>: Inicializa la conexión y crea las tablas si no existen.
    /// </summary>
    public Database()
    {
        CreateDatabase();
    }

    /// <summary>
    /// Método <c>CreateDatabase</c>: Crea las tablas necesarias en la base de datos si no existen.
    /// </summary>
    private void CreateDatabase()
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string createTablesQuery = @"
                CREATE TABLE IF NOT EXISTS Productos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    CodigoProducto TEXT NOT NULL UNIQUE,
                    Categoria INTEGER NOT NULL,
                    Precio REAL NOT NULL,
                    Existencia INTEGER NOT NULL,
                    Proveedor INTEGER NOT NULL,
                    FOREIGN KEY(Categoria) REFERENCES Categorias(Id),
                    FOREIGN KEY(Proveedor) REFERENCES Proveedores(Id)
                );
                CREATE TABLE IF NOT EXISTS Categorias (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL UNIQUE,
                    Descripcion TEXT
                );
                CREATE TABLE IF NOT EXISTS Proveedores (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NombreEmpresa TEXT NOT NULL UNIQUE,
                    Contacto TEXT,
                    Direccion TEXT,
                    Telefono TEXT
                );
            ";
            using (var command = new SQLiteCommand(createTablesQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    /// <summary>
    /// Método <c>ExecuteQuery</c>: Ejecuta una consulta SELECT en la base de datos.
    /// </summary>
    /// <param name="query">La consulta SQL que se ejecutará.</param>
    /// <returns>Un objeto <c>DataTable</c> que contiene los resultados de la consulta.</returns>
    public DataTable ExecuteQuery(string query, SQLiteParameter[] parameters = null)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (var command = new SQLiteCommand(query, connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                using (var adapter = new SQLiteDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    /// <summary>
    /// Método <c>ExecuteNonQuery</c>: Ejecuta una consulta SQL que no devuelve datos, como INSERT, UPDATE o DELETE.
    /// </summary>
    /// <param name="query">La consulta SQL que se ejecutará.</param>
    public void ExecuteNonQuery(string query, SQLiteParameter[] parameters = null)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (var command = new SQLiteCommand(query, connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se insertó ningún registro.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al ejecutar la consulta: {ex.Message}");
                }
            }
        }
    }
}