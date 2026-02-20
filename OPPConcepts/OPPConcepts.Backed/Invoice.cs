using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OPPConcepts.Backed;
public class Invoice : IPay
{
    private decimal _value;
    private float _quantity;
    public Invoice(int id, string description, Date date, float quantity, decimal
   value)
    {
        Id = id;
        Description = description;
        Date = date;
        Value = ValidateValue(value);
        Quantity = ValidateQuantity(quantity);
    }
    public string Description { get; set; }
    public int Id { get; set; }
    public Date Date { get; set; }
    public decimal Value
    {
        get => _value;
        set => _value = ValidateValue(value);
    }
    public float Quantity
    {
        get => _quantity;
        set => _quantity = ValidateQuantity(value);
    }
    public override string ToString()
    {
        return $"{Id}\t{Description}\n\t" +
        $"Quantity.......: {_quantity,15:N2}\n\t" +
        $"Value..........: {_value,15:C2}\n\t" +
        $"To pay.........: {GetValueToPay(),15:C2}";
    }
    public decimal GetValueToPay()
    {
        return _value * (decimal)_quantity;
    }
    private float ValidateQuantity(float quantity)
    {
        if (quantity < 0)
        {
            throw new ArgumentOutOfRangeException($"The quantity: {quantity}, is not valid.");
        }
        return quantity;
    }
    private decimal ValidateValue(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException($"The value: {value}, is not valid.");
        }
        return value;
    }
}