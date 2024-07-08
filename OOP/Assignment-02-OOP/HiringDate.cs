namespace Assignment_02_OOP;

public class HiringDate
{
    internal int Day;
    internal int Month;
    internal int Year;

    public HiringDate(int day , int month , int year)
    {
        if (day < 1 || day > 31) throw new ArgumentException("Invalid day");
        if (month < 1 || month > 12) throw new ArgumentException("Invalid month");
        if (year < 1900 || year > DateTime.Now.Year) throw new ArgumentException("Invalid year");

        Day = day;
        Month = month;
        Year = year;
    }
    
    public override string ToString()
    {
        return $"{Day}/{Month}/{Year}";
    }
}