using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LinqTestLessons
{
    public class Employee
    {
       
        public int id { get; set; }
        public string firstName{ get; set; }
        public string LasName { get; set; }
        public int Age { get; set; }
        public  string Car { get; set; }
        public  Price UserPrice { get; set; }
        
    }

    public class Price
    {
       
        public int id { get; set; }
        public int DataType { get; set; }
        public int Cost { get; set; }
       

    }
    public class appContext:DbContext
    {
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Price>UsePrices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (localdb)\\MSSQLLocalDB; Database = LinqDB; Trusted_Connection = True");
        }
    }
}
