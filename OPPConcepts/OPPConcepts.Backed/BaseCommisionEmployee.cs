using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OPPConcepts.Backed;

public class BaseCommisionEmployee : CommisionEmployee
{
    // Fields
    private decimal _salary;

    // Constructors
    public BaseCommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commisionPercentaje, decimal sales, decimal salary) : base(id, firstName, lastName, isActive, bornDate, hireDate, commisionPercentaje, sales)
    {
        Salary = salary;
    }

    // Properties
    public decimal Salary 
    { 
        get => _salary; 
        set => _salary = ValidateSalary(value); 
    }

    // Methods
    public override decimal GetValueToPay() => base.GetValueToPay() + Salary;
    public override string ToString() => $"{base.ToString()}\n\tSalary base.........: {Salary,20:C2}";
    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 500000)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary base must be greater than or equal to $500,000.");
        }
        return salary;
    }
}
