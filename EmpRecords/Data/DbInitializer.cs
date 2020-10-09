using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpRecords.Models;

namespace EmpRecords.Data
{
    public class DbInitializer
    {
        public static void Initialize(EmpContext context)
        {
            context.Database.EnsureCreated();

            //Look for any Standard employees
            if (context.Standards.Any())
            {
                return; //dont seed
            }

            var standards = new Standard[]
            {
                new Standard {FirstName = "Trent", LastName = "William", StartingDate = DateTime.Parse("2005-09-01")},
                new Standard {FirstName = "David", LastName = "Bennet", StartingDate = DateTime.Parse("2005-09-01")},
                new Standard {FirstName = "Ash", LastName = "Wright", StartingDate = DateTime.Parse("2005-09-01")},
                new Standard
                    {FirstName = "Carole", LastName = "Sargisson", StartingDate = DateTime.Parse("2005-09-01")},
                new Standard {FirstName = "Gary", LastName = "David", StartingDate = DateTime.Parse("2005-09-01")}
            };
            foreach (Standard s in standards)
            {
                context.Standards.Add(s);
            }

            context.SaveChanges();

            var departments = new Department[]
            {
                new Department {DepartmentID = 1000, Title = "Human Resources", Budget = 40000},
                new Department {DepartmentID = 2000, Title = "Customer Support", Budget = 20000}
            };
            foreach (Department d in departments)
            {
                context.Departments.Add(d);
            }

            context.SaveChanges();


            var contracts = new Contract[]
            {
                new Contract {StandardID = 1, DepartmentID = 1000},
                new Contract {StandardID = 2, DepartmentID = 2000},
                new Contract {StandardID = 3, DepartmentID = 2000},
                new Contract {StandardID = 4, DepartmentID = 1000}

            };
            foreach (Contract c in contracts)
            {
                context.Contracts.Add(c);
            }

            context.SaveChanges();

        }

    }
}
