namespace Assignment_03_OOP;

public class Duration
{
    public int Hours;
    public int Minutes;
    public int Seconds;
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public Duration(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
        Time();
    }

    public Duration(int seconds) : this(0,0,seconds)
    {
    }
    
    private void Time()
    {
        if (Seconds >= 60)
        {
            Minutes += Seconds / 60;
            Seconds %= 60;
        }

        if (Minutes >= 60)
        {
            Hours += Minutes / 60;
            Minutes %= 60;
        }
    }

    public override string ToString()
    {
        return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
    }

    public static Duration operator +(Duration a, Duration b)
    {
        return new Duration(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
    }
    public static Duration operator +(Duration a, int seconds)
    {
        Duration b = new Duration(seconds);
        return new Duration(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
    }
    public static Duration operator +(int seconds, Duration a)
    {
        Duration b = new Duration(seconds);
        return new Duration(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
    }

    public static Duration operator ++(Duration a)
    {
        return new Duration(a.Hours, ++a.Minutes, a.Seconds);
    }
    public static Duration operator --(Duration a)
    {
        return new Duration(a.Hours, --a.Minutes, a.Seconds);
    }
    public static Duration operator -(Duration a, Duration b)
    {
        return new Duration(int.Abs(a.Hours - b.Hours), int.Abs(a.Minutes - b.Minutes), int.Abs(a.Seconds - b.Seconds));
    }

    public static bool operator >(Duration a, Duration b)
    {
        if (a.Hours > b.Hours) return true;
        if (a.Hours < b.Hours) return false;
        if (a.Minutes > b.Minutes) return true;
        if (a.Minutes < b.Minutes) return false;
        return a.Seconds > b.Seconds;
    }
    public static bool operator <(Duration a, Duration b)
    {
        if (a.Hours < b.Hours) return true;
        if (a.Hours > b.Hours) return false;
        if (a.Minutes < b.Minutes) return true;
        if (a.Minutes > b.Minutes) return false;
        return a.Seconds < b.Seconds;
    }
    public static bool operator <=(Duration a, Duration b)
    {
        if (a.Hours <= b.Hours) return true;
        if (a.Hours >= b.Hours) return false;
        if (a.Minutes <= b.Minutes) return true;
        if (a.Minutes >= b.Minutes) return false;
        return a.Seconds <= b.Seconds;
    }
    public static bool operator >=(Duration a, Duration b)
    {
        if (a.Hours >= b.Hours) return true;
        if (a.Hours <= b.Hours) return false;
        if (a.Minutes >= b.Minutes) return true;
        if (a.Minutes <= b.Minutes) return false;
        return a.Seconds >= b.Seconds;
    }
    public static bool operator true(Duration d)
    {
        return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
    }
    public static bool operator false(Duration d)
    {
        return d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0;
    }

    public static explicit operator DateTime(Duration a)
    {
        return new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,a.Hours, a.Minutes, a.Seconds);
    }
}