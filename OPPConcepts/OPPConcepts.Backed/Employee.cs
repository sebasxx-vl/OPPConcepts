using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPConcepts.Backed;

public abstract class Employee : IPay
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Date? HireDate { get; set; }
    public Date? BornDate { get; set; }
    public bool IsActive { get; set; }
    protected Employee(int id, string firstName, string lastName, Date? hireDate, Date?
   bornDate, bool isActive)
    {
        Id = id;
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        HireDate = hireDate;
        BornDate = bornDate;
        IsActive = isActive;
    }
    public override string ToString()
    {
        return $"{Id}\t{FirstName} {LastName}\n\t" +
        $"Hired in.......: {HireDate,15}\n\t" +
        $"Born date......: {BornDate,15}\n\t" +
        $"Is active......: {IsActive,15}";
    }
    public abstract decimal GetValueToPay();
}

/*
public abstract class Employee
{
    //Constructors
    protected Employee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        IsActive = isActive;
        BornDate = bornDate;
        HireDate = hireDate;
    }

    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public bool IsActive { get; }
    public Date BornDate { get; set; } = null!;
    public Date HireDate { get; set; } = null!;

    //Methods
    public override string ToString()
    {
        return $"{Id}\t{FirstName} {LastName}\n\t" +
            $"Value to pay: {GetValueToPay()}";
    }

    private object GetValueToPay()
    {
        throw new NotImplementedException();
    }
};
*/

