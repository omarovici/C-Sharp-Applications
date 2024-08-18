using Microsoft.EntityFrameworkCore;
namespace Assignment_02_EF_Core.Entities;

[PrimaryKey("StudentId", "CourseId")]
public class Stud_Course
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public int Grade { get; set; }
}