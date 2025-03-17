using Npgsql;

namespace crm_demo2
{
    public class DBHelper
    {
        private readonly string _connectionString = "Host=localhost;Port=5432;Database=crm_demo;Username=postgres;Password=123";
        private readonly NpgsqlConnection _connection;

        public DBHelper()
        {
            _connection = new NpgsqlConnection(_connectionString);
            _connection.Open();
        }

        public NpgsqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
