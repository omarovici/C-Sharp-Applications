namespace Assignment_02_OOP;

class Program
{
    static void Main(string[] args)
    {
        HiringDate h1 = new HiringDate(1, 1, 2015);
        HiringDate h2 = new HiringDate(5, 7, 2020);
        HiringDate h3 = new HiringDate(20, 4, 2024);

        Employee[] emp = new Employee[3];
        emp[0] = new Employee(1, "Omar Khalid", SecurityLevel.Developer, 70000, h1, "M");
        emp[1] = new Employee(2, "Shehab Mohamed", SecurityLevel.Guest, 55000, h2, "M");
        emp[2] = new Employee(3, "Ziad Ahmed", SecurityLevel.DBA, 350000, h2, "M");

        foreach (var employee in emp)
        {
            Console.WriteLine(employee);
            Console.WriteLine();
        }

    }
}