using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm_demo2
{
    public class HomeTech
    {
        public long Id { get; set; }
        public TechType Type { get; set; }
        public string Model { get; set; }

        public HomeTech(long id, TechType type, string model)
        {
            Id = id;
            Type = type;
            Model = model;
        }
    }
}
