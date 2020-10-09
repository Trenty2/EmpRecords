using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace EmpRecords.Models
{
    public class Standard
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime StartingDate { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
