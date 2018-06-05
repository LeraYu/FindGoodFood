using FGF.Core.food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGF.Core.json
{
    class Content
    {
        public Content(List<Food> foods, List<Restaurant> restaurants)
        {
            Foods = foods;
            Restaurants = restaurants;

        }

        public List<Food> Foods { get; set; }
        public List<Restaurant> Restaurants { get; set; }
    }
}
