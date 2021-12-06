using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant() { Id = 1, Name = "Scott's Pizza", Location = "Maryland", Cuisine = CuisineType.Italian },
                new Restaurant() { Id = 2, Name = "El Chappo", Location = "San Fransisco", Cuisine = CuisineType.Mexican },
                new Restaurant() { Id = 3, Name = "Guru", Location = "New York", Cuisine = CuisineType.Indian },
                new Restaurant() { Id = 4, Name = "Namaste India", Location = "San Andreas", Cuisine = CuisineType.Indian },
                new Restaurant() { Id = 5, Name = "Desperados", Location = "Los Angeles", Cuisine = CuisineType.Mexican },
                new Restaurant() { Id = 6, Name = "Godfather & son", Location = "Seattle", Cuisine = CuisineType.Italian },
                new Restaurant() { Id = 7, Name = "La Costa", Location = "California", Cuisine = CuisineType.Mexican },
            };
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrWhiteSpace(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
