namespace Assignment_01_Advanced;

public class Range<T> where T : IComparable<T>
{
    public Range(T minimum, T maximum)
    {
        if (minimum.CompareTo(maximum) > 0) throw new Exception();
        Minimum = minimum;
        Maximum = maximum;
    }
    public T Minimum { get; set; }
    public T Maximum { get; set; }

    public bool IsInRange(T value)
    {
        return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
    }

    public T Length()
    {
        return (dynamic)Maximum - (dynamic)Minimum;
    }
    
}