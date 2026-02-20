using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPConcepts.Backed;

public class BaseCommisionEmployee : CommisionEmployee
{
    private decimal _salary;
    public BaseCommisionEmployee(int id, string firstName, string lastName, Date?
   hireDate, Date? bornDate, bool isActive, float commisionPercentaje, decimal sales,
   decimal salary) : base(id, firstName, lastName, hireDate, bornDate, isActive,
   commisionPercentaje, sales)
    {
        Salary = ValidateSalary(salary);
    }
    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }
    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
        $"Base...........: {_salary,15:C2}\n\t" +
        $"Salary.........: {GetValueToPay(),15:C2}";
    }
    public override decimal GetValueToPay()
    {
        return base.GetValueToPay() + _salary;
    }
    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 1000000)
        {
            throw new ArgumentOutOfRangeException($"The salary {salary:C2} is less than minimum salary.");
        }
        return salary;
    }
}
