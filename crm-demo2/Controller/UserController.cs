using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm_demo2.Controller
{
    public class UserController
    {
        private readonly DBHelper _dbHelper;

        public UserController()
        {
            _dbHelper = new DBHelper();
        }

        public List<User> GetAllClient()
        {
            var clients = new List<User>();

            string query = "select * from users where type = 'заказчик'";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User client = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        clients.Add(client);
                    }
                }
            }

            return clients;
        }
    }
}
