using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm_demo2
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public User(long id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }
    }
}
