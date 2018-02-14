using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeesListApp.Models
{
    public class Employe
    {
        public int ID { get; set; }
        public string Name { get; set; }     
        public string Position { get; set; }
        public decimal Salary { get; set; }
    }

    public class EmployeDBContext : DbContext
    {
        public DbSet<Employe> Employes { get; set; }
    }
}