using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace EmpRecords.Models
{
    //Add code specific to Standard employee's here
    public class Standard:Person
    {
        public ICollection<Contract> Contracts { get; set; }

    }
}
