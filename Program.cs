using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTestLessons
{
    class Program
    {
        static void Main(string[] args)
        {

            // TestShowLinq();
            ShowCollection();
            // вызов LINQ с применение унаследованных коллекций 
            //var arrayList = new ArrayList();
            //arrayList.Add("Adam");
            //arrayList.Add("Jon");
            //arrayList.Add("Tom");
            //var name = arrayList.OfType<string>().Where(t => t.Length > 3); // Спримением OfType
            //foreach (var result in name)
            //{
            //    Console.WriteLine(result);
            //}
            //var names = arrayList.Cast<string>().Where(n => n.Length < 4);
            //foreach (var result in names)
            //{
            //    Console.WriteLine(result);
            //}
            //using (appContext db = new appContext())
            //{
            //    Employee employee1 = new Employee { firstName = "Bill", LasName = "Artis", Age = 60, Car = "BMW", UserPrice = new Price() };
            //    Employee employee2 = new Employee { firstName = "Jonatan", LasName = "Henst", Age = 36, Car = "Audi-80", UserPrice = new Price() };
            //    db.Employees.AddRange(employee1, employee2);
            //    db.SaveChanges();

            //    Price price1 = new Price { DataType = DateTime.Today.Day, Cost = 25000 };
            //    Price price2 = new Price { DataType = DateTime.Today.Year, Cost = 50000 };
            //    db.UsePrices.AddRange(price1, price2);
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

        //public static void TestShowLinq()
        //{
        //    string[] name = new[] {"one", "two",  "three"};
        //    Console.WriteLine("Before where() is called.");
        //    IEnumerable<string> Iestring = name.Where(t => t.Length == 3);
        //    foreach (var result in Iestring)
        //    {
        //        Console.WriteLine("proseccing: " + result);
        // }
        public static void ShowCollection()
        {



            using (appContext db = new appContext())
            {
                var Query = db.Employees.Join(db.UsePrices, employee => employee.id, price => price.id,
                    (employee, price) => new
                    {
                        Age = employee.Age,
                        Name = employee.LasName,
                        Cars = employee.Car,
                        Prices = price.Cost,
                        Data = price.DataType
                    });
                foreach (var result in Query)
                {
                    Console.WriteLine($"\nВозраст:{result.Age}-\nИмя:{result.Name}-\nМарка машины:{result.Cars}-\nЦена машины:{result.Prices}-\nГод выпуска авто:{result.Data}");
                }
            }

            //using (appContext db = new appContext())
            //{
            //    var Query = db.Employees.Join(db.UsePrices, employee => employee.id, price => price.id,
            //        (employee, price) => new
            //        {
            //            Name = employee.LasName,
            //            Prices = price.Cost,
            //            Car  = employee.Car
            //        });
            //    foreach (var result in Query)
            //    {
            //        Console.WriteLine($"\nИмя:{result.Name} - \nЦена:{result.Prices} -\n Машина{result.Car}");
            //    }
            //}
            //string[] AvtoCar = { "Volvo", "Nissan", "Toyta" };
            //IEnumerable<string> result = AvtoCar.OrderBy(t => t.Length).ThenBy(t=>t);
            //foreach (var t in result)
            //{
            //    Console.WriteLine(t);
            //}


            //using (appContext db = new appContext())
            //{


            //    //var Query = db.employees.OrderBy(p => p.Age).ThenBy(p => p.LasName);
            //    //foreach (var result in Query)
            //    //{
            //    //    Console.WriteLine($"\nВозраст{result.Age}:\nИмя{result.firstName}");
            //    //}
            //}



            //string s = "Hello World";
            //var str = s.ToCharArray().Reverse().ToArray();
            //Console.WriteLine(new string('.', 10));
            //Console.WriteLine($"До: {s}");
            //Console.WriteLine(new string('.', 10));
            //Console.WriteLine("После:");
            //Console.WriteLine(str);



            //string[] AvtoCar = {"Volvo", "Nissan", "BMW", "Mersedes"};
            //IEnumerable<string> avto = AvtoCar.Take(2);
            //foreach (var result in avto)
            //{
            //    Console.WriteLine(result);
            //}

        }
    }
}


//int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        //IEnumerable<int> mas = array.Where(t => t % 2== 1).Reverse().ToList();
        //foreach (var result in mas)
        //{
        //    Console.WriteLine(result); 
        //}




        ////////////////////////////////////////////////////
        //// Создаем массив целых чисел
        //int[]arrayMas = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        //IEnumerable<int> mas = arrayMas.Select(t => t);
        //// Отобразить результпт
        //foreach (var result in mas)
        //{
        //    Console.WriteLine(result);
        //}
        //// Перевернуть массив
        //Array.Reverse(arrayMas);
        //Console.WriteLine(new string('.', 10));
        //foreach (var rez in mas)
        //{
        //    Console.WriteLine(rez);
        //}

        //////////////////////////////////////////////////////
        //// Массив чисел
        //int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        //IEnumerable<int> mas = array.Select(p => p);
        //// Отображаем елементы
        //foreach (var rezult in mas)
        //{
        //    Console.WriteLine(rezult);
        //}

        //Array.Reverse(array); // Переворачиваем массив
        //Console.WriteLine(new string('.', 10));
        //    // Снова отображаем результат
        //foreach (var rez in mas)
        //{
        //    Console.WriteLine(rez);
        //}
        ////////////////////////////////////////////////////////
    
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //string[] avtoCar = {"Volvo", "Nissan", "BMW", "Audi", "Kavasaki", "Lada", "Pobeda", "Volga", "Astra", "Aka"};
    //IEnumerable<string> items = avtoCar.Where(p => p.StartsWith("A"));
    //foreach (var rezult in items)
    //{
    //    Console.WriteLine(rezult);
    //}

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //string[] names = {"Tomas", "Jon", "Bill", "Ret", "Max", "Indigo"};
    //IEnumerable<string>Query = names.Where(t => t.Length < 4).Select(t => t);
    //foreach (var result in Query)
    //{
    //    Console.WriteLine($"Именя:{result}");
    //}
    ///////////////////////////////////////////////////////////////////////////////////////////////////
    //Dictionary<string , int>Avto = new Dictionary<string, int>();
    //Avto.Add("Volvo", 2020);
    //Avto.Add("Nissan", 1990);
    //foreach (var result in Avto)
    //{
    //    Console.WriteLine($"\nМарка:{result.Key}\nГод выпуска:{result.Value}");
    //}
    //   using (appContext db = new appContext())
    //   {
    //       var Query = db.employees.Select(t=>new 
    //       {
    //           LastName = t.LasName,
    //           FirstName = t.firstName,
    //           Age = t.Age
    //       });
    //        foreach (var rez in Query)
    //        {
    //            Console.WriteLine($"\nФамилия:{rez.FirstName}\nИмя:{rez.LastName}-\nВозраст{rez.Age}");
    //        }
    //    }









