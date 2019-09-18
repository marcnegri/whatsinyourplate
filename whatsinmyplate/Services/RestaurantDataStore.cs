using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using whatsinmyplate.Models;

namespace whatsinmyplate.Services
{
    public class RestaurantDataStore : IDataStore<Restaurant>
    {
        List<Restaurant> restaurants;

        public RestaurantDataStore()
        {
            restaurants = new List<Restaurant>();
            var mockItems = new List<Restaurant>
            {
                new Restaurant{Name="Vintage", Description="Restaurant brasserie typique Bordelais", Picture="http://res.cloudinary.com/crahart486/image/upload/c_fill,h_300,w_400/v1567097762/xrgtlupfkeft30j4ratj.jpg", Address="1 Rue des fleurs 33 000 Bordeaux"},
                new Restaurant{Name="Le Kabuki", Description="Restaurant très fin de spécialité Italienne et méditerranéenne.", Picture="http://res.cloudinary.com/crahart486/image/upload/c_fill,h_300,w_400/v1567149642/j7aybyvhmmnh3ufvof3t.jpg", Address="18 Vital Carles 33 000 Bordeaux"},
                new Restaurant{Name="Tripletta", Description="Restaurant très fin de spécialité Italienne et méditerranéenne.", Picture="http://res.cloudinary.com/crahart486/image/upload/c_fill,h_300,w_400/v1567098114/hbjgjwwv60ovzgizgxcs.jpg" , Address="18 Vital Carles 33 000 Bordeaux"}
            };

        

            foreach (var item in mockItems)
            {
                restaurants.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Restaurant item)
        {
            restaurants.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Restaurant item)
        {
            var oldItem = restaurants.Where((Restaurant arg) => arg.Id == item.Id).FirstOrDefault();
            restaurants.Remove(oldItem);
            restaurants.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = restaurants.Where((Restaurant arg) => arg.Id == id).FirstOrDefault();
            restaurants.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Restaurant> GetItemAsync(string id)
        {
            return await Task.FromResult(restaurants.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Restaurant>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(restaurants);
        }
    }
}