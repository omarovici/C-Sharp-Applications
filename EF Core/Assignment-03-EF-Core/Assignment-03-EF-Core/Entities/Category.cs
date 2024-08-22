namespace Assignment_03_EF_Core;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Product> Products { get; set; }
    public Category ParentCategory { get; set; }
    public int? ParentCategoryId { get; set; }
    public ICollection<Category> ChildCategories { get; set; }
}