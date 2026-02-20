using OPPConcepts.Backed;

try
{
    var employee1 = new SalaryEmployee(1010, "Maria", "Pérez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    var employee2 = new SalaryEmployee(2020, "Joaquin", "Gonzalez", true, new Date(1980, 3, 5), new Date(2016, 11, 15), 10395876);

    Console.WriteLine(employee1);
    Console.WriteLine(employee2);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
