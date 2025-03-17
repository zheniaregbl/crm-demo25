using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm_demo2
{
    public class Request
    {
        public long Id { get; set; }
        public User? Master { get; set; }
        public User Client { get; set; }
        public DateTime StartDate { get; set; }
        public HomeTech HomeTech { get; set; }
        public string Problem { get; set; }
        public string Status { get; set; }
        public DateTime? CompletionDate { get; set; }

        public Request(long id, User? master, User client, DateTime startDate, HomeTech homeTech, string problem, string status, DateTime? completionDate)
        {
            Id = id;
            Master = master;
            Client = client;
            StartDate = startDate;
            HomeTech = homeTech;
            Problem = problem;
            Status = status;
            CompletionDate = completionDate;
        }
    }
}
