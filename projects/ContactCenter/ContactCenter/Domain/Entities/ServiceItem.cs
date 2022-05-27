using System.ComponentModel.DataAnnotations;

namespace ContactCenter.Domain.Entities;

public class ServiceItem : EntityBase
{
    [Required(ErrorMessage = "Заполните название сервиса")]
    [Display(Name = "Название сервиса")]
    public override string? Title { get; set; }

    [Display(Name = "Краткое название сервиса")]
    public override string? Subtitle { get; set; }

    [Display(Name = "Полное описание сервиса")]
    public override string? Text { get; set; }
}