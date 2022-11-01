using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var amazon = new Bird() 
            { 
                CanFly = true , 
                CanSing = true, 
                CanTalk = true, 
                IsTropical = true, 
                
            };
            Console.WriteLine($"My {amazon.Size} birds name is {amazon.Name} that has {amazon.Legs} legs it is {amazon.CanFly.ToString().ToLower()} that he can fly." +
                $" It is {amazon.IsFast.ToString().ToLower()} it is fast. A couple more fun facts about this bird is: ");
            Console.WriteLine($"Does bob live in the tropics? {amazon.IsTropical}");
            Console.WriteLine($"Can bob talk? {amazon.CanTalk }");
            Console.WriteLine($"Can bob sing? {amazon.CanSing}\n");
            

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var rattleSnake = new Reptile() 
            { 
                ColdBlooded = "very cold blooded", 
                Friendly = "very mean", 
                Posion = "super poisoness", 
                Scales = "very scaley", 
                
            };
            Console.WriteLine($"My snakes name is {rattleSnake.Name} that has {rattleSnake.Legs} legs and has some poor qualities including: " +
                $"{rattleSnake.ColdBlooded}, " +
                $"{rattleSnake.Friendly}, {rattleSnake.Posion}, " +
                $"{rattleSnake.Scales},and is {rattleSnake.Size}");
            Console.WriteLine($"It is {rattleSnake.IsFast} that is it fast and furious"); 

        }
    }
}
