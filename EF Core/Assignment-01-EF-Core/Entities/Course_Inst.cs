using Microsoft.EntityFrameworkCore;
namespace Assignment_01_EF_Core.Entities;

[PrimaryKey("CourseId", "InstructorId")]
public class Course_Inst
{
    public int CourseId { get; set; }
    public int InstructorId { get; set; }
    public int Evaluate { get; set; }
}