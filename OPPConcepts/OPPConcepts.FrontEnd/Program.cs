using OPPConcepts.Backed;
using System.ComponentModel.DataAnnotations;

try
{
    var expences = new List<IPay>();
    decimal total = 0;
    var employee1 = new SalaryEmployee(1010, "Maria", "Pérez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    expences.Add(employee1);
    var employee2 = new SalaryEmployee(2020, "Joaquin", "Gonzalez", true, new Date(1980, 3, 5), new Date(2016, 11, 15), 10395876);
    expences.Add(employee2);
    var employee3 = new HourlyEmployee(3030, "Ana", "López", true, new Date(1995, 8, 20), new Date(2022, 6, 1), 18000, 95);
    expences.Add(employee3);
    var employee4 = new HourlyEmployee(4040, "Kevin", "Rúa", true, new Date(1998, 8, 20), new Date(2012, 7, 17), 10000, 112);
    expences.Add(employee4);
    var employee5 = new CommisionEmployee(5050, "Sofía", "Hincapié", true, new Date(1992, 6, 12), new Date(2018, 3, 15), 0.03f, 600000000);
    expences.Add(employee5);
    var employee6 = new CommisionEmployee(6060, "Juan", "Zuluaga", true, new Date(1985, 6, 16), new Date(2010, 9, 1), 0.03f, 120000000);
    expences.Add(employee6);
    var employee7 = new BaseCommisionEmployee(7070, "Laura", "García", true, new Date(1992, 7, 30), new Date(2018, 3, 15), 0.015f, 250000000, 550000);
    expences.Add(employee7);
    var employee8 = new BaseCommisionEmployee(8080, "Carlos", "Rodríguez", true, new Date(1988, 4, 10), new Date(2026, 2, 10), 0.015f, 0, 550000);
    expences.Add(employee8);
    var invoice1 = new Invoice(9090, "Iphone 14 Pro Max", new Date(2024, 6, 1), 2, 8000000);
    expences.Add(invoice1);
    var invoice2 = new Invoice(1010, "Samsung Galaxy S24 Ultra", new Date(2024, 6, 1), 3, 7000000);
    expences.Add(invoice2);
    var invoice3 = new Invoice(1111, "UTP Level 6", new Date(2024, 6, 1), 100.45f, 6450);
    expences.Add(invoice3);

    foreach (var expense in expences)
    {
        Console.WriteLine(new string('-', 50));
        Console.WriteLine(expense);
        total += expense.GetValueToPay();
    }
    Console.WriteLine(new string('=', 50));
    Console.WriteLine($"TOTAL.......................: {total,20:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
