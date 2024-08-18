namespace Assignment_01_EF_Core.Entities;

public class Course
{
    public int Id { get; set; }
    public int Duration { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int TopicId { get; set; }
    public ICollection<Stud_Course> Stud_Course { get; set; }
}