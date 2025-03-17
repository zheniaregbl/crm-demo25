using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm_demo2.Controller
{
    public class TechTypeController
    {
        private readonly DBHelper _dbHelper;

        public TechTypeController()
        {
            _dbHelper = new DBHelper();
        }

        public List<TechType> GetAllTypes()
        {
            var types = new List<TechType>();

            var query = "select * from tech_type";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var type = new TechType(reader.GetInt32(0), reader.GetString(1));
                        types.Add(type);
                    }
                }
            }

            return types;
        }
    }
}
