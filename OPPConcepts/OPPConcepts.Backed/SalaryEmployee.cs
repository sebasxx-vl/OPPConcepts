using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OPPConcepts.Backed;

public class SalaryEmployee : Employee
{
    private decimal _salary;
    private readonly StreamingContext minimum;

    public SalaryEmployee(int id, string firstName, string lastName, Date? hireDate,
   Date? bornDate, bool isActive, decimal salary) : base(id, firstName, lastName, hireDate,
   bornDate, isActive)
    {
        _salary = ValidateSalary(salary);
    }
    public decimal Salary
    {
        get => _salary;
        set => ValidateSalary(value);
    }
    public override string ToString()
    {
        return $"{base.ToString()}\n\tSalary.........: {GetValueToPay(),15:C2}";
    }
    public override decimal GetValueToPay()
    {
        return _salary;
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

/*
public class SalaryEmployee : Employee
{
    //Fields
    private decimal salary;
    //Constructors
    public SalaryEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate) :
        base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
    }

    //Properties
    public decimal ValidateSalary(decimal salary)
    {
        if(salary < 2000000)
        { 
            
        }
        return salary;
    }

    //Methods
    
}
*/