using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_02_EF_Core.Entities;

public class Course
{
    public int Id { get; set; }
    public int Duration { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Stud_Course> Stud_Course { get; set; }
    [ForeignKey("TopicId")]
    public Topic Topic { get; set; }
    public int TopicId { get; set; }
}