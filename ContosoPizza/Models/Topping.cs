using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ContosoPizza.Models;

public class Topping
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    public decimal Calories { get; set; }

    //Make pizza and toppings a many-to-many relations ship but do not serialize the property
    [JsonIgnore]
    public ICollection<Pizza>? Pizzas { get; set; }
}