using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehatBank
{
    internal class Food
    {
        public int FoodID { get; }
        public string FoodName { get; }
        public int Calories { get; }

        public Food(int foodID, string foodName, int calories)
        {
            FoodID = foodID;
            FoodName = foodName;
            Calories = calories;
        }
    }
}
