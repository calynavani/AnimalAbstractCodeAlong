using System;

namespace AnimalAbstractCodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            Chimp c = new Chimp();
            Food meat = new Food(100, FoodType.Meat);
            Food plant = new Food(500, FoodType.Plants);

            c.Eat(plant);
            c.Eat(plant);
           
           


            Console.WriteLine("Calores: " + c.CurrentCalories);
            Console.WriteLine("Meat Calories " + c.MeatCalories);
            Console.WriteLine("Full " + c.EatenEnough);
        }
    }
}
