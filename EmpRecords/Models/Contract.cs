using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpRecords.Models
{
    public class Contract
    {
        public int ContractID { get; set; }
        public int DepartmentID { get; set; }
        public int? StandardID { get; set; }
        public int? SupervisorID { get; set; }

        public Department Department { get; set; }
        public Standard Standard { get; set; }
        public Supervisor Supervisor { get; set; }
    }
}
