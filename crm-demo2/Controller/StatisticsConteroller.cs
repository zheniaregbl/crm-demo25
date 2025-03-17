using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm_demo2
{
    public class StatisticsConteroller
    {
        private readonly DBHelper _dbHelper;

        public StatisticsConteroller()
        {
            _dbHelper = new DBHelper();
        }

        public int GetOpenRequestQuantity()
        {
            int quantity = 0;
            string query = "select count(*) from request where status != 'готова к выдаче'";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                quantity = Convert.ToInt32(command.ExecuteScalar());
            }

            return quantity;
        }

        public int GetCloseRequestQuantity()
        {
            int quantity = 0;
            string query = "select count(*) from request where status = 'готова к выдаче'";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                quantity = Convert.ToInt32(command.ExecuteScalar());
            }

            return quantity;
        }

        public int GetClientQuantity()
        {
            int quantity = 0;
            string query = "select count(*) from users where type = 'заказчик'";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                quantity = Convert.ToInt32(command.ExecuteScalar());
            }

            return quantity;
        }

        public int GetMasterQuantity()
        {
            int quantity = 0;
            string query = "select count(*) from users where type = 'мастер'";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                quantity = Convert.ToInt32(command.ExecuteScalar());
            }

            return quantity;
        }
    }
}
