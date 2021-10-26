using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalAbstractCodeAlong
{//tracks the animals current hunger
    //childre are to figure out what the specific animal eats and caloric needs


    //we need a food class containg type of food and calories
    abstract class Animal
    {

        public int NeededCalories { get; set; }
        public int CurrentCalories { get; set; } = 0;

        //this list checs to see if the animal is allowed to eat a food
        public List<FoodType> EdibleFoods { get; set; } = new List<FoodType>();

        public virtual bool EatenEnough => NeededCalories <= CurrentCalories;

        public Animal(int NeededCalories, params FoodType[] EdibleFoods)
        {
            this.NeededCalories = NeededCalories;
            this.EdibleFoods = EdibleFoods.ToList();

        }


        //this method takes in a food object as parameter
        //remeber this method has no body
        public abstract void Eat(Food food);
       
    }
}
