namespace Assignment_02_OOP;

public class Employee
{
    internal int ID { get; set; }
    internal string Name { get; set; }
    public SecurityLevel SecurityLevel { get; set; }
    internal Decimal Salary { get; set; }
    internal DateTime HireDate { get; set; }
    private string gender;
    internal string Gender
    {
        get { return gender;}
        set
        {
            if (value.ToString().ToUpper()=="M"||value.ToString().ToUpper()=="F")
            {
                gender = value;
            }
            else
            {
                Console.WriteLine("Please enter the gender , it must be M or F");
            }
        }
    }

    public Employee(int id , string name ,SecurityLevel securityLevel, decimal salary , DateTime hireDate , string gender)
    {
        ID = id;
        Name = name;
        SecurityLevel = securityLevel;
        Salary = salary;
        HireDate = hireDate;
        Gender = gender;
    }
    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary}, Hire Date: {HireDate}, Gender: {Gender}";
    }

}