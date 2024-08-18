namespace Assignment_01_EF_Core.Entities;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int InstructorId { get; set; }
    public DateTime HiringDate { get; set; }
}