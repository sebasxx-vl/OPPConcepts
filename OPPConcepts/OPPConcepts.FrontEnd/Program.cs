using OPPConcepts.Backed;
try
{
    var employee1 = new SalaryEmployee(1, "Patricia", "Morales", new Date(2020, 4, 15),
new Date(1981, 1, 12), true, 2500000);
    var employee2 = new HourlyEmployee(2, "Ricardo", "Sanchez", new Date(2021, 12, 5),
   new Date(1971, 8, 11), true, 23000, 156);
    var employee3 = new CommisionEmployee(3, "Monica", "Correa", new Date(2022, 5, 5),
   new Date(1985, 2, 11), true, 0.03f, 290000000);
    var employee4 = new BaseCommisionEmployee(3, "Sandra", "Jaramillo", new Date(2022,
   5, 5), new Date(1985, 2, 11), true, 0.015f, 120000000, 1100000);
    var employees = new List<Employee>() { employee1, employee2, employee3, employee4 };
    decimal total = 0;
    Console.WriteLine("PAY ROL");
    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
        Console.WriteLine();
        total += employee.GetValueToPay();
    }
    var invoice1 = new Invoice(1, "Chair", new Date(2025, 2, 5), 4, 350000);
    var invoice2 = new Invoice(2, "Computer", new Date(2025, 2, 5), 2, 2850000);
    var invoice3 = new Invoice(3, "Paper", new Date(2025, 2, 5), 10, 56000);
    var invoices = new List<Invoice>() { invoice1, invoice2, invoice3 };
    Console.WriteLine("INVOICES");
    foreach (var invoice in invoices)
    {
        Console.WriteLine(invoice);
        Console.WriteLine();
        total += invoice.GetValueToPay();
    }
    Console.WriteLine($"TOTAL..................: {total,15:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
