using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm_demo2.Model
{
    public class ReportRequest
    {
        public long Id { get; set; }
        public string? MasterName { get; set; }
        public string? MasterPhone { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string TechModel { get; set; }
        public string TechType { get; set; }
        public string Problem { get; set; }

        public ReportRequest(long id, string? masterName, string? masterPhone, string clientName, string clientPhone, DateTime startDate, DateTime? completionDate, string techModel, string techType, string problem)
        {
            Id = id;
            MasterName = masterName;
            MasterPhone = masterPhone;
            ClientName = clientName;
            ClientPhone = clientPhone;
            StartDate = startDate;
            CompletionDate = completionDate;
            TechModel = techModel;
            TechType = techType;
            Problem = problem;
        }
    }
}
