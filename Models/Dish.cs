using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]

        [Required]
        [Display(Name="Chef Name: ")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Name of Dish: ")]
        public string DishName { get; set; }

        [Required]
        [Range(1,15000)]
        [Display(Name="# of Calories: ")]
        public string Calories { get; set; }

        [Required]
        [Range(1,5)]
        [Display(Name="Tastiness: ")]
        public string Tastiness { get; set; }

        [Display(Name="Comments: ")]
        public string Comments { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}