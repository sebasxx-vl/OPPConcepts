using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPConcepts.Backed;

public class CommisionEmployee : Employee
{
    // Fields
    private float _commisionPercentaje;
    private decimal _sales;

    // Constructors
    public CommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commisionPercentaje, decimal sales) : base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
        CommisionPercentaje = commisionPercentaje;
        Sales = sales;
    }

    // Properties
    public float CommisionPercentaje 
    { 
        get => _commisionPercentaje; 
        set => _commisionPercentaje = value; 
    }
    public decimal Sales 
    { 
        get => _sales; 
        set => _sales = value; 
    }

    // Methods
    public override decimal GetValueToPay() => (decimal)CommisionPercentaje * Sales;
    public override string ToString() => base.ToString() + $"\n\t" + 
        $"Commision Percentaje: {CommisionPercentaje,20:P2}\n\t" + 
        $"Sales...............: {Sales,20:C2}";
}
