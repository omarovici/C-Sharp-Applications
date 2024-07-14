namespace Assignment_04_OOP;

class Program
{
    static void Main(string[] args)
    {
        double a, b;
        bool check = true;
        do
        {
            Console.Write("Enter the value of a: ");
            check = double.TryParse(Console.ReadLine(), out a);
            if (!check) Console.WriteLine("Wrong value, please enter the value again.");
        } while (!check);

        do
        {
            Console.Write("Enter the value of b: ");
            check = double.TryParse(Console.ReadLine(), out b);
            if (!check) Console.WriteLine("Wrong value, please enter the value again.");
        } while (!check);
        
        Console.WriteLine("Add: " + Maths.Add(a, b));
        Console.WriteLine("Subtract: " + Maths.Subtract(a, b));
        Console.WriteLine("Multiply: " + Maths.Multiply(a, b));
        Console.WriteLine("Divide: " + Maths.Divide(a, b));
    }
}