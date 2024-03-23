using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

public class Sauce
{
    [Required]
    [MaxLength(100)]
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool IsVegan { get; set; }
}