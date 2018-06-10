using API_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Core.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApiContext context)
        {
            context.Database.EnsureCreated();

            // Look for any restaurants.
            if (context.Restaurants.Any())
            {
                return;   // DB has been seeded 
            }

            //create restaurantes 
            var restaurants = new Restaurant[]
            {
            new Restaurant{Name="Dinho's"},
            new Restaurant{Name="Eddie's"}
            };

            foreach (Restaurant r in restaurants)
            {
                context.Restaurants.Add(r);
            }
            context.SaveChanges();

            var menus = new Menu[]
            {
                //menu for 1st restaurant
                new Menu{Name="Main Course", Restaurant=context.Restaurants.FirstOrDefault(), RestaurantId = context.Restaurants.FirstOrDefault().Id},
                //menu for the last restaurant
                new Menu{Name="Main Course", Restaurant=context.Restaurants.LastOrDefault(), RestaurantId = context.Restaurants.LastOrDefault().Id},
            };
            foreach (Menu c in menus)
            {
                context.Menus.Add(c);
            }
            context.SaveChanges();

            var items = new Item[]
            {
            new Item{Name="Chicken noodles", Menu=context.Menus.FirstOrDefault(), MenuId=context.Menus.FirstOrDefault().Id},
            new Item{Name="Beef and rice", Menu=context.Menus.FirstOrDefault(), MenuId=context.Menus.FirstOrDefault().Id},
            new Item{Name="BBQ Sampler", Menu=context.Menus.FirstOrDefault(), MenuId=context.Menus.FirstOrDefault().Id},

            new Item{Name="Item 1", Menu=context.Menus.LastOrDefault(), MenuId=context.Menus.LastOrDefault().Id},
            new Item{Name="Item 2", Menu=context.Menus.LastOrDefault(), MenuId=context.Menus.LastOrDefault().Id}

            };

            foreach (Item i in items)
            {
                context.Items.Add(i);
            }
            context.SaveChanges();
        }
    }
}
