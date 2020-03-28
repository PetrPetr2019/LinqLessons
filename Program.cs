using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqTestLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            // вызов LINQ с применение унаследованных коллекций 
            var arrayList = new ArrayList();
            arrayList.Add("Adam");
            arrayList.Add("Jon");
            arrayList.Add("Tom");
            var name = arrayList.OfType<string>().Where(t => t.Length > 3); // Спримением OfType
            foreach (var result in name)
            {
                Console.WriteLine(result);
            }
            //var names = arrayList.Cast<string>().Where(n => n.Length < 4);
            //foreach (var result in names)
            //{
            //    Console.WriteLine(result);
            //}
            //using (appContext db = new appContext())
            //{
            //    Employee employee1 = new Employee { firstName = "Tom", LasName = "Jemson" };
            //    Employee employee2 = new Employee { firstName = "Bil", LasName = "Henks" };

            //    db.employees.AddRange(employee1, employee2);
            //    db.SaveChanges();
            //    Console.WriteLine("Done");

            //}

            //using (appContext db = new appContext())
            //{
               
            //    //var Query = db.employees.Select(t => new 
            //    //{
            //    //    Name = t.LasName,
            //    //    Family = t.firstName,
            //    //    ID = t.id
            //    //});
            //    //foreach (var result in Query)
            //    //{
            //    //    Console.WriteLine($"Имя:{result.Name} - Фамилия:{result.Family} - ID:{result.ID}");
            //    //}
            //}

            Console.ReadLine();
        }
    }

}

