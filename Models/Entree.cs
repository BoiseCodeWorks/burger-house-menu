using System.ComponentModel.DataAnnotations;
using MenuApi.Models.Interfaces;

namespace MenuApi.Models
{
    public class Entree : IMenuItem
    {
        public int Id {get; set;}

        [Required]
        public string Name { get; set; }
        public float Price { get; set; }
        public int Calories { get; set; }

        // NO CONSTRUCTORS WHEN USING ENTITY FRAMEWORK!!!!!!!!!
        // BECAUSE OF INDEXING
        // public Entree(string name, float price, int calories, int id)
        // {
        //     Name = name;
        //     Price = price;
        //     Calories = calories;
        // }
    }

}