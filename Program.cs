using System;
using System.Linq;

namespace LinqTestLessons
{
    class Program
    {
        static void Main(string[] args)
        {

            using (appContext db = new appContext())
            {
                Employee employee1 = new Employee { firstName = "Tom", LasName = "Jemson" };
                Employee employee2 = new Employee { firstName = "Bil", LasName = "Henks" };

                db.employees.AddRange(employee1, employee2);
                db.SaveChanges();
                Console.WriteLine("Done");

            }

            using (appContext db = new appContext())
            {
                var Query = db.employees.Select(t => new 
                {
                    Name = t.LasName,
                    Family = t.firstName,
                    ID = t.id
                });
                foreach (var result in Query)
                {
                    Console.WriteLine($"Имя:{result.Name} - Фамилия:{result.Family} - ID:{result.ID}");
                }
            }

            Console.ReadLine();
        }
    }

}

