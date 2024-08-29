namespace Data.Models.Entities;

public class Employee : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public decimal Salary { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime HireDate { get; set; }
    public string ImageUrl { get; set; }
    public Department Department { get; set; }
    public int? DepartmentId { get; set; }
}