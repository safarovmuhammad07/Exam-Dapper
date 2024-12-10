using Npgsql;

namespace Infrastructure.DapperConText;

public class DapperContext
{
    public static string connectionString= "Server=localhost;Database=Examination;user id=postgres;password=1234;";

     public NpgsqlConnection GetConnection()
    {
        NpgsqlConnection _connection = new NpgsqlConnection(connectionString);
        return _connection;
    }
}