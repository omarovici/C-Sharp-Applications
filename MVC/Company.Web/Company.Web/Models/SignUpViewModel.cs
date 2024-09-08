using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models;

public class SignUpViewModel
{
    [Required(ErrorMessage = "First Name is required")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Last Name is required")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Format for Email")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password is required")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W)(?:([a-zA-Z\d\W])(?!.*\1)){2,}.{6,}$",ErrorMessage = "Password must contain at least 2 characters, 1 uppercase letter, 1 lowercase letter, 1 number and 1 special character")]
    public string Password { get; set; }
    [Required(ErrorMessage = "Confirm Password is required")]
    [Compare(nameof(Password), ErrorMessage = "Password and Confirm Password do not match")]
    public string ConfirmPassword { get; set; }
    [Required (ErrorMessage = "Agree is required")]
    public bool IsAgree { get; set; }
}