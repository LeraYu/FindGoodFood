using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGF.Core.food
{
    class Restaurant
    {
        private bool _isInited = false;

        public int Id { get; set; }
        public int RestaurantName { get; set; }

        public virtual List<PathElement> Path { get; set; }

        public class PathElement
        {
            public PathElement(int id, int foodId, Time time, int price)
            {
                Id = id;
                FoodId = foodId;

                Time = time;
                Price = price;
            }

            public int Id { get; set; }

            public int FoodId { get; set; }

            public Time Time { get; set; }

            public int Price { get; set; }

            
            public virtual int RestaurantId { get; set; }

           
            public virtual Restaurant Restaurant { get; set; }
        }

        public class Time
        {
            public string TimeOfEat { get; set; }
        }

    }
}
    

