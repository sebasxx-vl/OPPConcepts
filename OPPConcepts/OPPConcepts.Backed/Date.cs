namespace OPPConcepts.Backed;

public class Date
{
    private int _day;
    private int _month;
    private int _year;
    public Date()

    {
        _year = 1900;
        _month = 1;
        _day = 1;

    }
    public Date(int year, int month, int day)

    {
        _year = ValidateYear(year);
        _month = ValidateMonth(month);
        _day = ValidateDay(day);
    }
    public int Day
    {
        get => _day;
        set => _day = ValidateDay(value);
    }
    public int Month
    {
        get => _month;
        set => _month = ValidateMonth(value);
    }
    public int Year
    {
        get => _year;
        set => _year = ValidateYear(value);
    }
    public override string ToString()
    {
        return $"{_year:0000}/{_month:00}/{_day:00}";
    }
    private int ValidateYear(int year)
    {
        if (year < 0)
        {
            throw new ArgumentException($"The year: {year}, not is valid.");
        }
        return year;
    }
    private int ValidateMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new ArgumentException($"The month: {month}, not is valid.");
        }
        return month;
    }
    private int ValidateDay(int day)
    {
        if (day < 1)
        {
            throw new ArgumentException($"The day: {day}, not is valid.");
        }
        if (day == 29 && _month == 2 && IsLeapYear(_year))
        {
            return day;
        }
        if ((day <= 28 && _month == 2) || (day <= 30 && (_month == 4 || _month == 6 || _month == 9 || _month == 11))
||
 (day <= 31 && (_month == 1 || _month == 3 || _month == 5 || _month == 7 ||
_month == 8 || _month == 10 || _month == 12)))
        {
            return day;
        }
        throw new ArgumentException($"The day: {day}, not is valid.");
    }
    private bool IsLeapYear(int year)
    {
        return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
    }
}

/*
public class Date
{
    private int _year;
    private int _month;
    private int _day;

    public Date()
    {
        _year = 1900;
        _month = 1;
        _day = 1;
    }

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public int Year 
    {
        get => _year; 
        set => _year = ValidateYear(value);    
    }
  
    public int Month 
    {
        get => _month;
        set => _month = ValidateMonth(value);
    }

    public int Day
    {
        get => _day;
        set => _day = ValidateDay(value);
    }

    public override string ToString()
    {
        return $"{Year:0000}/{Month:00}/{Day:00}";
    }

    private int ValidateYear(int year)
    {
        if(year < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(year), "Year must be greathest than 0.");
        }
        return year;
    }

    private int ValidateMonth(int month)
    {
        if(month < 1 || month > 12)
        {
            throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12.");
        }
        return month;
    }

    private int ValidateDay(int day)
    {
        if (day < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(day), "Day must be greathest than 0.");
        }
        if (day == 29 && Month == 2 && IsLeapYear(Year))
        {
            return day;
        }
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (day > daysInMonth[Month - 1])
        {
            throw new ArgumentOutOfRangeException(nameof(day), $"Day must be between 1 and {daysInMonth[Month - 1]} for month {Month}.");
        }

        return day;
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
*/
