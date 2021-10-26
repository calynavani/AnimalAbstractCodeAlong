using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAbstractCodeAlong
{
    //Mouse will only eat plants
    //they dont need many calories
    class Mouse: Animal
    {
        //(calories,addtoFoodTypeList. Plants) these are the parents parameters 
        public Mouse() : base(120,FoodType.Plants)
        {

        }

        public override void Eat(Food food)
        {
           // for example if the mouse's metabolism allows them to double the amount of calories they eat
           if(EdibleFoods.Contains(food.FoodType))
            {
                CurrentCalories += food.Calories * 2;
            }
            else
            {
                Console.WriteLine( "Hey! Mice cant eat that.");
                Console.WriteLine("They can only eat plants!");
            }
            
        }
    }

}
