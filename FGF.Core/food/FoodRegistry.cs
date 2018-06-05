using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGF.Core.food
{
    class FoodRegistry
    {
        private readonly Dictionary<int, List<Restaurant>> foodToRestaurants;

        public FoodRegistry(List<Restaurant> restaurants)
        {
                foodToRestaurants= new Dictionary<Food, List<Restaurant>>();
                foreach (var restaurant in restaurants)
                    foreach (var pathElement in restaurant.Path)
                    {
                        if (foodToRestaurants.TryGetValue(pathElement.FoodId, out List<Restaurant> foodRestaurant))
                        {
                            foodRestaurant.Add(restaurant);
                        }
                        else
                        {
                            foodToRestaurants.Add(pathElement.FoodId, new List<Restaurant>() { restaurant });
                        }
                    }
            }
        }

        public List<Food> GetFoods()
        {
            return foods;
        }

        public Food GetFoodById(int id)
        {
            return foods.Find(food => food.Id == id);
        }

        public Food GetFoodByName(string foodName)
        {
            return foods.Find(food => food.FoodName.Equals(foodName));
        }

        public List<Restaurant> GetRestaurantByFood(Food food)
        {
            List<Restaurant> result = new List<Restaurant>();
            Console.WriteLine(foodToRestaurants);
            if (foodToRestaurants.TryGetValue(food.Id, out result))
            {
                Console.WriteLine("Result");
                return result;
            }
            else
            {
                Console.WriteLine("null");

                return null;
            }
        }
    }
}
