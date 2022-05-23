﻿using System.ComponentModel.DataAnnotations;

namespace ContactCenter.Domain.Entities;

public abstract class EntityBase
{
    protected EntityBase() => CreatedOn = DateTime.UtcNow;
    
    [Required]
    public Guid Id { get; set; }

    [Display(Name = "Название (заголовок)")]
    public virtual string? Title { get; set; }
    
    [Display(Name = "Краткое описание")]
    public virtual string? Subtitle { get; set; }
    
    [Display(Name = "Полное описание")]
    public virtual string? Text { get; set; }
    
    [Display(Name = "Титульная картинка")]
    public virtual string? TitleImagePath { get; set; }
    
    [DataType(DataType.Time)]
    public DateTime CreatedOn { get; set; }
}