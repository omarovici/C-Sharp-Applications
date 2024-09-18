using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models;

public class ForgetPasswordViewModel
{
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Format for Email")]
    public string Email { get; set; }
}