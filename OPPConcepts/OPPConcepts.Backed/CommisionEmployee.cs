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
        set => _commisionPercentaje = ValidateCommisionPercentaje(value); 
    }
    public decimal Sales 
    { 
        get => _sales; 
        set => _sales = ValidateSales(value); 
    }

    // Methods
    public override decimal GetValueToPay() => (decimal)CommisionPercentaje * Sales;
    public override string ToString() => base.ToString() + $"\n\t" + 
        $"Commision Percentaje: {CommisionPercentaje,20:P2}\n\t" + 
        $"Sales...............: {Sales,20:C2}";
    
    private float ValidateCommisionPercentaje(float commisionpercentaje)
    {
        if(commisionpercentaje < 0 || commisionpercentaje > 1)
        {
            throw new ArgumentOutOfRangeException(nameof(commisionpercentaje), "Commision percentaje must be between 0 and 1");
        }
        return commisionpercentaje;
    }

    private decimal ValidateSales(decimal sales)
    {
        if (sales < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(sales), "Sales must be greater than than or equal 0");
        }
        return sales;
    }
}
