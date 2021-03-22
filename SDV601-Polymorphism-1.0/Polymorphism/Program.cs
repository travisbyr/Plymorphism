using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var zoo = new Zoo();

            var lion = new Lion()
            {
                Name = "Cleopatra"
            }; 
            zoo.Add(lion);

            var tiger = new Tiger
            {
                Name = "Paprika"
            };
            zoo.Add(tiger);

            var mouse = new Mouse
            {
                Name = "Hercules"
            };

            zoo.Add(mouse);

            var worm = new Worm
            {
                Name = "Wormname"
            };

            zoo.Add(worm);

            var dog = new Dog
            {
                Name = "Doggo"
            };

            zoo.Add(dog);

            Console.WriteLine(zoo.About());

            Console.ReadKey();
        }
    }
}
