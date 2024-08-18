using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_02_EF_Core.Entities;

public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Bonus { get; set; }
    public int Salary { get; set; }
    public string Address { get; set; }
    public int HourRate { get; set; }
}