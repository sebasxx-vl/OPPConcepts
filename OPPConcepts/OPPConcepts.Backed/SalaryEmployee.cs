using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPConcepts.Backed;

public class SalaryEmployee : Employee
{
    // Fields
    private decimal _salary;

    // Constructors
    public SalaryEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, decimal salary) : 
        base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
        Salary = salary;
    }

    //Properties
    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }

    // Methods (first publics methods and then private methods)
    public override decimal GetValueToPay() => Salary;

    public override string ToString() => base.ToString();

    private decimal ValidateSalary(decimal salary)
    {
        if(salary < 2000000)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to $2,000,000");
        }
        return salary;
    }
}