using System.Data.SqlClient;

SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["constring"].ToString());
// Crear una conexión a la base de datos

conn.Open();

// Iniciar la transacción
SqlTransaction trans = conn.BeginTransaction();

try
{
    // Crear un comando para la transacción
    SqlCommand cmd = conn.CreateCommand();
    cmd.Transaction = trans;

    // Ejecutar una serie de comandos dentro de la transacción
    cmd.CommandText = "INSERT INTO Products(ProductName, ProductTypeID, DetailsProductTypeID) VALUES ('Guisantes congelados', '0', '1')";
    cmd.ExecuteNonQuery();

    cmd.CommandText = "INSERT INTO Products(ProductName, ProductTypeID, DetailsProductTypeID) VALUES ('Jostin Perez', '1', '2')";
    cmd.ExecuteNonQuery();

    // Confirmar la transacción
    trans.Commit();
    Console.WriteLine("Transaccion exitosa");
    }

        catch (Exception ex)

    {

    // Si algo sale mal, deshacer la transacción
    trans.Rollback();
    Console.WriteLine("Error: " + ex.Message);

    }

        finally

    {
    // Cerrar la conexión
    conn.Close();

}
