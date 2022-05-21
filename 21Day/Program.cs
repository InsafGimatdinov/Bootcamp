// Worker w = new Worker(){Id = 1, Age = 26, FullName = "Insaf Gimatdinov"};

// Worker w1 = CopyService.CopyWorker(w);

// w1.Age = 33;
// w1.FullName = "Katya Molina";

// // System.Console.WriteLine(w);
// // System.Console.WriteLine(w1);

// Organization o1 = new Organization(){Manager = w, Name = "Oganization 1"};
// Organization o2 = CopyService.CopyOrganization(o1);
// o2.Manager = w1;

// System.Console.WriteLine(o1);
// System.Console.WriteLine(o2);

// Departament d1 = new Departament()
// {Name = "d1"};
// d1.CDepartament = new Departament()
// {Name = "d2"};

// WeatherService.GetCountyList(id:1);

// using System.Dynamic;

// dynamic d = new ExpandoObject();

// d.FullName = "d FIO";
// d.Age = "123";
// d.Salary = "200";
// d.items = new string[] {"item1", "item2"};
// System.Console.WriteLine(d.Age);
// var model = new {
//     Title = "Book",
//     PageCount = 23,
//     Authors = new string[] {"Author 1", "Author 2"}
// };
// System.Console.WriteLine(model);

// int t = MathService.Sum(1, 2, 3, 4, 5, 6, 7);
// System.Console.WriteLine(t);

Foo.Start();
System.Console.WriteLine("Push enter to exit");
System.Console.ReadLine();