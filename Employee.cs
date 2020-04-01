using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace LinqTestLessons
{
    public class Employee
    {
        public int id { get; set; }
        public string firstName{ get; set; }
        public string LasName { get; set; }
        public int Age { get; set; }

    }

    public class appContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (localdb)\\MSSQLLocalDB; Database = LinqDB; Trusted_Connection = True");
        }
    }
}
