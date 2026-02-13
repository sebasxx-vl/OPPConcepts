using OPPConcepts.Backed;

try
{
    var day1 = new Date();
    var day2 = new Date(2026, 29, 2);
    var day3 = new Date(2012, 12, 10);

    Console.WriteLine(day1);
    Console.WriteLine(day2);
    Console.WriteLine(day3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}