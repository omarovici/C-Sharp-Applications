using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_02_EF_Core.Entities;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime HiringDate { get; set; }
    [ForeignKey("InstructorId")]
    public Instructor Instructor { get; set; }
    public int InstructorId { get; set; }
}