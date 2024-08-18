namespace Assignment_02_EF_Core.Entities;

public class Student
{
    public int Id { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public Department Department { get; set; }
    public int DepartmentId { get; set; }
    public ICollection<Stud_Course> Stud_Course { get; set; }
}