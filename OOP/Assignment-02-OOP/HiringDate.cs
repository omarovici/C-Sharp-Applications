namespace Assignment_02_OOP;

public class HiringDate
{
    internal int Day;
    internal int Month;
    internal int Year;

    public HiringDate(int day , int month , int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }
    
    public override string ToString()
    {
        return $"{Day}/{Month}/{Year}";
    }
}