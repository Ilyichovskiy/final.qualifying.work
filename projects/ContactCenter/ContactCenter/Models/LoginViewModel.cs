using System.ComponentModel.DataAnnotations;

namespace ContactCenter.Models;
public class LoginViewModel
{
    [Required]
    [Display(Name = "Логин")]
    public string UserName { get; set; }

    [Required]
    // ReSharper disable once Mvc.TemplateNotResolved
    [UIHint("password")]
    [Display(Name = "Пароль")]
    public string Password { get; set; }

    [Display(Name = "Запомнить меня?")]
    public bool RememberMe { get; set; }
}