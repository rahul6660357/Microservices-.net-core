using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Model
{
    public class Employee
    {
        public long id { get; set; }
        public string fullname { get; set; }
        public string lastname { get; set; }
        public string designation { get; set; }

        public string address { get; set; }

        public int active { get; set; }
    
    }
}
