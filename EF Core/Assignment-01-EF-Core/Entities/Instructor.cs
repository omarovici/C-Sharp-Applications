namespace Assignment_01_EF_Core.Entities;

public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Bonus { get; set; }
    public int Salary { get; set; }
    public string Address { get; set; }
    public int HourRate { get; set; }
    public int DepartmentId { get; set; }
}