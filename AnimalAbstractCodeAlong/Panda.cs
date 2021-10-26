using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAbstractCodeAlong
{
    //Panda
    //eats only plants
    //only take in half of the calories they eat
    //they need 3000 calories a day
    class Panda: Animal
    {
        public Panda() : base (3000, FoodType.Plants)
        {

        }

        public override void Eat(Food food)
        {
            
            if (EdibleFoods.Contains(food.FoodType))
            {
                CurrentCalories += food.Calories / 2;
            }
            else
            {
                Console.WriteLine("Hey! Panda's can't eat that.");
                Console.WriteLine("They can only eat plants!");
            }

        }




    }
}
