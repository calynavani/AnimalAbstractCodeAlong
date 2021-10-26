using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAbstractCodeAlong
{
    //Bush
    //eats light and only needs 50 calories a day
    class Bush : Animal
    {
        public Bush() : base(50, FoodType.Light)
        {

        }

        public override void Eat(Food food)
        {

            if (EdibleFoods.Contains(food.FoodType))
            {
                CurrentCalories += food.Calories;
            }
            else
            {
                Console.WriteLine("Hey! Bushes can't eat that.");
                Console.WriteLine("They can only eat sunlight!");
            }

        }





    }
}
