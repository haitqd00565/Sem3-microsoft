using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xBindingExamples.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
    }
    public class DrinkManager
    {
        public static List<Drink> GetDrinks()
        {
            var drinks = new List<Drink>();
            drinks.Add(new Drink { DrinkId = 1, Title = "Drink 1", Description = "Rất ngon 1", CoverImage = "Assets/drinks/1.jpeg" });
            drinks.Add(new Drink { DrinkId = 2, Title = "Drink 2", Description = "Rất ngon 2", CoverImage = "Assets/drinks/2.jpeg" });
            drinks.Add(new Drink { DrinkId = 3, Title = "Drink 3", Description = "Rất ngon 3", CoverImage = "Assets/drinks/3.jpeg" });
            drinks.Add(new Drink { DrinkId = 4, Title = "Drink 4", Description = "Rất ngon 4", CoverImage = "Assets/drinks/4.jpeg" });
            drinks.Add(new Drink { DrinkId = 5, Title = "Drink 5", Description = "Rất ngon 5", CoverImage = "Assets/drinks/5.jpeg" });
            drinks.Add(new Drink { DrinkId = 6, Title = "Drink 6", Description = "Rất ngon 6", CoverImage = "Assets/drinks/6.jpeg" });
            drinks.Add(new Drink { DrinkId = 7, Title = "Drink 7", Description = "Rất ngon 7", CoverImage = "Assets/drinks/7.jpeg" });
            drinks.Add(new Drink { DrinkId = 8, Title = "Drink 8", Description = "Rất ngon 8", CoverImage = "Assets/drinks/8.jpeg" });
            drinks.Add(new Drink { DrinkId = 9, Title = "Drink 9", Description = "Rất ngon 9", CoverImage = "Assets/drinks/9.jpeg" });
            drinks.Add(new Drink { DrinkId = 10, Title = "Drink 10", Description = "Rất ngon 10", CoverImage = "Assets/drinks/10.jpeg" });
            drinks.Add(new Drink { DrinkId = 11, Title = "Drink 11", Description = "Rất ngon 11", CoverImage = "Assets/drinks/11.jpeg" });
            drinks.Add(new Drink { DrinkId = 12, Title = "Drink 12", Description = "Rất ngon 12", CoverImage = "Assets/drinks/12.jpeg" });
            drinks.Add(new Drink { DrinkId = 13, Title = "Drink 13", Description = "Rất ngon 13", CoverImage = "Assets/drinks/13.jpeg" });
            drinks.Add(new Drink { DrinkId = 14, Title = "Drink 14", Description = "Rất ngon 14", CoverImage = "Assets/drinks/14.jpeg" });
            drinks.Add(new Drink { DrinkId = 15, Title = "Drink 15", Description = "Rất ngon 15", CoverImage = "Assets/drinks/15.jpeg" });
            return drinks;
        }
          
    }       
}
