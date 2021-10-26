using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAbstractCodeAlong
{
    public enum FoodType
    { 
        Meat,
        Plants,
        Light
    }

    class Food
    {
        public int Calories { get; set; }
        public FoodType FoodType { get; set; }

        public Food(int Calories, FoodType Foodtype)
        {
            this.Calories = Calories;
            this.FoodType = FoodType;
        }
    }

}
