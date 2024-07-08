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
                throw new ArgumentException("Please enter the gender , it must be M or F");
            }
        }
    }

    public Employee(int id , string name ,SecurityLevel securityLevel, decimal salary , HiringDate hireDate , string gender)
    {
        if (id <= 0) throw new ArgumentException("ID must be positive");
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty");
        if (salary < 0) throw new ArgumentException("Salary must be positive");
        
        ID = id;
        Name = name;
        SecurityLevel = securityLevel;
        Salary = salary;
        HireDate = hireDate;
        Gender = gender;
    }
    public override string ToString()
    {
        return string.Format("ID: {0}, Name: {1}, Security Level: {2}, Salary: {3:C}, Hire Date: {4}, Gender: {5}",ID,Name,SecurityLevel,Salary,HireDate,Gender);
    }

}