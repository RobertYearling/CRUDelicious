using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required]
        [Display(Name ="Chef's name.")]
        public string ChefName {get;set;}

        [Required]
        [Display(Name ="Dish name.")]
        public string DishName {get;set;}

        [Required]
        [Range(1,15000)]
        [Display(Name ="Number of Calories.")]
        public string Calories {get;set;}

        [Required]
        [Range(1,5)]
        [Display(Name ="Tastiness.")]
        public string Tastiness {get;set;}

        [Display(Name ="Comments.")]
        public string Comments {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}