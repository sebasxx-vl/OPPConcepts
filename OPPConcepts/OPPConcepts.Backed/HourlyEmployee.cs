/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OPPConcepts.Backed;
public class HourlyEmployee : Employee
{
    private decimal _hourValue;
    private int _workingHours;
    public HourlyEmployee(int id, string firstName, string lastName, Date? hireDate,
   Date? bornDate, bool isActive, decimal hourValue, int workingHours) : base(id,
   firstName, lastName, hireDate, bornDate, isActive)
    {
        HourValue = ValidateHourValue(hourValue);
        WorkingHours = ValidateWorkingHours(workingHours);
    }
    public decimal HourValue
    {
        get => _hourValue;
        set => _hourValue = ValidateHourValue(value);
    }
    public int WorkingHours
    {
        get => _workingHours;
        set => _workingHours = ValidateWorkingHours(value);
    }
    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
        $"Working hours..: {_workingHours,15:N2}\n\t" +
        $"Hour Value.....: {_hourValue,15:C2}\n\t" +
        $"Salary.........: {GetValueToPay(),15:C2}";
    }
    public override decimal GetValueToPay()
    {
        return _workingHours * _hourValue;
    }
    private decimal ValidateHourValue(decimal hourValue)
    {
        if (hourValue < 18000)
        {
            throw new ArgumentOutOfRangeException($"The hour value: {hourValue:C2} is less than minimum salary.");
        }
        return hourValue;
    }
    private int ValidateWorkingHours(int workingHours)
    {
        if (workingHours < 0)
        {
            throw new ArgumentOutOfRangeException($"The working ours: {workingHours:N0} is not valid.");
        }
        return workingHours;
    }
}