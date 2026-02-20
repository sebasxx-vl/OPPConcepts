using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OPPConcepts.Backed;

public class CommisionEmployee : Employee
{
    private float _commisionPercentaje;
    private decimal _sales;
    public CommisionEmployee(int id, string firstName, string lastName, Date? hireDate,
   Date? bornDate, bool isActive, float commisionPercentaje, decimal sales) : base(id,
   firstName, lastName, hireDate, bornDate, isActive)
    {
        CommisionPercentaje = ValidateCommisionPercentaje(commisionPercentaje);
        Sales = ValidateSales(sales);
    }
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
    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
        $"Commision %....: {_commisionPercentaje,15:P2}\n\t" +
        $"Sales..........: {_sales,15:C2}\n\t" +
        $"Salary.........: {GetValueToPay(),15:C2}";
    }
    public override decimal GetValueToPay()
    {
        return _sales * (decimal)_commisionPercentaje;
    }
    private float ValidateCommisionPercentaje(float commisionPercentaje)
    {
        if (commisionPercentaje < 0 || commisionPercentaje > .3)
        {
            throw new ArgumentOutOfRangeException($"The commision percentaje: {commisionPercentaje:P2} is not valid.");
        }
        return commisionPercentaje;
    }
    private decimal ValidateSales(decimal sales)
    {
        if (sales < 0)
        {
            throw new ArgumentOutOfRangeException($"The sales: {sales:C2} is not valid.");
        }
        return sales;


    }
}