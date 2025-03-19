using crm_demo2.Model;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crm_demo2
{
    public class RequestController
    {

        private readonly DBHelper _dbHelper;

        public RequestController()
        {
            _dbHelper = new DBHelper();
        }

        public List<string> GetAllRequestStatus()
        {
            var statuses = new List<string>();

            string query = "select unnest(enum_range(null::request_status))";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read()) { statuses.Add(reader.GetString(0)); }
                }
            }

            return statuses;
        }

        public List<Request> GetAllRequests()
        {
            var requests = new List<Request>();

            string query = "select r.id as request_id, r.start_date, r.problem_desc, r.status, r.completion_date, c.id as client_id, c.fio as client_fio, c.phone as client_phone, m.id as master_id, m.fio as master_fio, m.phone as master_phone, ht.id as tech_id, ht.model as tech_model, tt.id as tech_type_id, tt.name as tech_type_name\n" +
                "from request r join users c on r.client = c.id\n" +
                "left join users m on r.master = m.id\n" +
                "join home_tech ht on r.home_tech = ht.id\n" +
                "join tech_type tt on ht.type = tt.id";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User? master = reader.IsDBNull(8) ? null : new User(reader.GetInt32(8), reader.GetString(9), reader.GetString(10));
                        DateTime? completionDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4);

                        Request request = new Request(
                            id: reader.GetInt32(0),
                            master: master,
                            client: new User(reader.GetInt32(5), reader.GetString(6), reader.GetString(7)),
                            startDate: reader.GetDateTime(1),
                            homeTech: new HomeTech(
                                id: reader.GetInt32(11),
                                type: new TechType(reader.GetInt32(13), reader.GetString(14)),
                                model: reader.GetString(12)
                            ),
                            problem: reader.GetString(2),
                            status: reader.GetString(3),
                            completionDate: completionDate
                        );

                        requests.Add(request);
                    }
                }
            }

            return requests;
        }

        public List<ReportRequest> GetReportRequestByDates(DateTime startDate, DateTime endDate)
        {
            var requests = new List<ReportRequest>();

            string query = "select r.id as request_id, r.start_date, r.problem_desc, r.completion_date, c.fio as client_fio, c.phone as client_phone, m.fio as master_fio, m.phone as master_phone, ht.model as tech_model, tt.name as tech_type_name\n" +
                "from request r join users c on r.client = c.id\n" +
                "left join users m on r.master = m.id\n" +
                "join home_tech ht on r.home_tech = ht.id\n" +
                "join tech_type tt on ht.type = tt.id\n" +
                "where start_date > @startDate and start_date < @endDate";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string? masterName = reader.IsDBNull(6) ? null : reader.GetString(6);
                        string? masterPhone = reader.IsDBNull(7) ? null : reader.GetString(7);

                        DateTime? completionDate = reader.IsDBNull(3) ? null : reader.GetDateTime(3);

                        var request = new ReportRequest(
                            reader.GetInt32(0),
                            masterName,
                            masterPhone,
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetDateTime(1),
                            completionDate,
                            reader.GetString(8),
                            reader.GetString(9),
                            reader.GetString(2)
                        );

                        requests.Add(request);
                    }
                }
            }

            return requests;
        }

        public List<Request> GetRequestsByStatus(string status)
        {
            var requests = new List<Request>();

            var query = "select r.id as request_id, r.start_date, r.problem_desc, r.status, r.completion_date, c.id as client_id, c.fio as client_fio, c.phone as client_phone, m.id as master_id, m.fio as master_fio, m.phone as master_phone, ht.id as tech_id, ht.model as tech_model, tt.id as tech_type_id, tt.name as tech_type_name\n" +
                "from request r join users c on r.client = c.id\n" +
                "left join users m on r.master = m.id\n" +
                "join home_tech ht on r.home_tech = ht.id\n" +
                "join tech_type tt on ht.type = tt.id\n" +
                "where r.status = @status::request_status";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                command.Parameters.AddWithValue("@status", status);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User? master = reader.IsDBNull(8) ? null : new User(reader.GetInt32(8), reader.GetString(9), reader.GetString(10));
                        DateTime? completionDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4);

                        Request request = new Request(
                            id: reader.GetInt32(0),
                            master: master,
                            client: new User(reader.GetInt32(5), reader.GetString(6), reader.GetString(7)),
                            startDate: reader.GetDateTime(1),
                            homeTech: new HomeTech(
                                id: reader.GetInt32(11),
                                type: new TechType(reader.GetInt32(13), reader.GetString(14)),
                                model: reader.GetString(12)
                            ),
                            problem: reader.GetString(2),
                            status: reader.GetString(3),
                            completionDate: completionDate
                        );

                        requests.Add(request);
                    }
                }
            }

            return requests;
        }

        public List<Request> GetRequestsById(long id)
        {
            var requests = new List<Request>();

            var query = "select r.id as request_id, r.start_date, r.problem_desc, r.status, r.completion_date, c.id as client_id, c.fio as client_fio, c.phone as client_phone, m.id as master_id, m.fio as master_fio, m.phone as master_phone, ht.id as tech_id, ht.model as tech_model, tt.id as tech_type_id, tt.name as tech_type_name\n" +
                "from request r join users c on r.client = c.id\n" +
                "left join users m on r.master = m.id\n" +
                "join home_tech ht on r.home_tech = ht.id\n" +
                "join tech_type tt on ht.type = tt.id\n" +
                "where r.id = @id";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        User? master = reader.IsDBNull(8) ? null : new User(reader.GetInt32(8), reader.GetString(9), reader.GetString(10));
                        DateTime? completionDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4);

                        Request request = new Request(
                            id: reader.GetInt32(0),
                            master: master,
                            client: new User(reader.GetInt32(5), reader.GetString(6), reader.GetString(7)),
                            startDate: reader.GetDateTime(1),
                            homeTech: new HomeTech(
                                id: reader.GetInt32(11),
                                type: new TechType(reader.GetInt32(13), reader.GetString(14)),
                                model: reader.GetString(12)
                            ),
                            problem: reader.GetString(2),
                            status: reader.GetString(3),
                            completionDate: completionDate
                        );

                        requests.Add(request);
                    }
                }
            }

            return requests;
        }

        public List<Request> GetRequestsByIdAndStatus(long id, string status)
        {
            var requests = new List<Request>();

            var query = "select r.id as request_id, r.start_date, r.problem_desc, r.status, r.completion_date, c.id as client_id, c.fio as client_fio, c.phone as client_phone, m.id as master_id, m.fio as master_fio, m.phone as master_phone, ht.id as tech_id, ht.model as tech_model, tt.id as tech_type_id, tt.name as tech_type_name\n" +
                "from request r join users c on r.client = c.id\n" +
                "left join users m on r.master = m.id\n" +
                "join home_tech ht on r.home_tech = ht.id\n" +
                "join tech_type tt on ht.type = tt.id\n" +
                "where r.id = @id and r.status = @status::request_status";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@status", status);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        User? master = reader.IsDBNull(8) ? null : new User(reader.GetInt32(8), reader.GetString(9), reader.GetString(10));
                        DateTime? completionDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4);

                        Request request = new Request(
                            id: reader.GetInt32(0),
                            master: master,
                            client: new User(reader.GetInt32(5), reader.GetString(6), reader.GetString(7)),
                            startDate: reader.GetDateTime(1),
                            homeTech: new HomeTech(
                                id: reader.GetInt32(11),
                                type: new TechType(reader.GetInt32(13), reader.GetString(14)),
                                model: reader.GetString(12)
                            ),
                            problem: reader.GetString(2),
                            status: reader.GetString(3),
                            completionDate: completionDate
                        );

                        requests.Add(request);
                    }
                }
            }

            return requests;
        }

        public long GetMaxRequestId()
        {
            string query = "select last_value from request_id_seq";

            using (var command = new NpgsqlCommand(query, _dbHelper.GetConnection()))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }

            return 0L;
        }

        public void AddRequestWithHomeTech(long techTypeId, string model, long clientId, string problemDesc, string status, DateTime completionDate)
        {
            string insertHomeTechQuery = @"
            INSERT INTO home_tech (type, model)
            VALUES (@type, @model)
            RETURNING id;";

            string insertRequestQuery = @"
            INSERT INTO request (master, client, start_date, home_tech, problem_desc, status, completion_date)
            VALUES (@master, @client, @startDate, @homeTechId, @problemDesc, @status::request_status, @completionDate);";

            using (var transaction = _dbHelper.GetConnection().BeginTransaction())
            {
                try
                {
                    int homeTechId;
                    using (var homeTechCommand = new NpgsqlCommand(insertHomeTechQuery, _dbHelper.GetConnection(), transaction))
                    {
                        homeTechCommand.Parameters.AddWithValue("@type", techTypeId);
                        homeTechCommand.Parameters.AddWithValue("@model", model);

                        homeTechId = Convert.ToInt32(homeTechCommand.ExecuteScalar());
                    }

                    using (var requestCommand = new NpgsqlCommand(insertRequestQuery, _dbHelper.GetConnection(), transaction))
                    {
                        requestCommand.Parameters.AddWithValue("@master", DBNull.Value);
                        requestCommand.Parameters.AddWithValue("@client", clientId);
                        requestCommand.Parameters.AddWithValue("@startDate", DateTime.Now);
                        requestCommand.Parameters.AddWithValue("@homeTechId", homeTechId);
                        requestCommand.Parameters.AddWithValue("@problemDesc", problemDesc);
                        requestCommand.Parameters.AddWithValue("@status", status);
                        requestCommand.Parameters.AddWithValue("@completionDate", completionDate);

                        requestCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }

        public void UpdateRequestWithHomeTech(long requestId, long homeTechId, long techTypeId, string model, long clientId, string problemDesc, DateTime startDate)
        {
            string updateHomeTechQuery = @"
            UPDATE home_tech
            SET type = @type, model = @model
            WHERE id = @homeTechId;";

            string updateRequestQuery = @"
            UPDATE request
            SET client = @client, start_date = @startDate, problem_desc = @problemDesc
            WHERE id = @requestId;";

            using (var transaction = _dbHelper.GetConnection().BeginTransaction())
            {
                try
                {
                    using (var homeTechCommand = new NpgsqlCommand(updateHomeTechQuery, _dbHelper.GetConnection(), transaction))
                    {
                        homeTechCommand.Parameters.AddWithValue("@type", techTypeId);
                        homeTechCommand.Parameters.AddWithValue("@model", model);
                        homeTechCommand.Parameters.AddWithValue("@homeTechId", homeTechId);

                        homeTechCommand.ExecuteNonQuery();
                    }

                    using (var requestCommand = new NpgsqlCommand(updateRequestQuery, _dbHelper.GetConnection(), transaction))
                    {
                        requestCommand.Parameters.AddWithValue("@client", clientId);
                        requestCommand.Parameters.AddWithValue("@startDate", startDate);
                        requestCommand.Parameters.AddWithValue("@problemDesc", problemDesc);
                        requestCommand.Parameters.AddWithValue("@requestId", requestId);

                        requestCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }

        public void DeleteRequest(long requestId)
        {
            string deleteQuery = "delete from request where id = @requestId;";

            using (var command = new NpgsqlCommand(deleteQuery, _dbHelper.GetConnection()))
            {
                command.Parameters.AddWithValue("@requestId", requestId);
                command.ExecuteNonQuery();
            }
        }
    }
}
