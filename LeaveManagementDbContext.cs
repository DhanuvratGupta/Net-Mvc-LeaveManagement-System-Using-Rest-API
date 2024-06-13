using MySql.Data.MySqlClient;

namespace Leave_Mangement
{
    public class LeaveManagementDbContext
    {
        private readonly IConfiguration _config;

        public LeaveManagementDbContext(IConfiguration config)
        {
            _config = config;
        }

        public MySqlConnection OpenConnection()
        {
            string connectionString = _config.GetSection("connectionString").Value;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
