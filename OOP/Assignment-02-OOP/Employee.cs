namespace Assignment_02_OOP;

public class Employee
{
    internal int ID { get; set; }
    internal string Name { get; set; }
    internal SecurityLevel SecurityLevel { get; set; }
    internal Decimal Salary { get; set; }
    internal HiringDate HireDate { get; set; }
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

    public Employee(int id , string name ,SecurityLevel securityLevel, decimal salary , HiringDate hireDate , string gender)
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
        return string.Format("ID: {0}, Name: {1}, Security Level: {2}, Salary: {3}, Hire Date: {4}, Gender: {5}",ID,Name,SecurityLevel,Salary,HireDate,Gender);
    }

}