using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm_demo2
{
    public class TechType
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public TechType(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
