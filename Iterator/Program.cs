using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new Cars();
            cars.Add(new Car {Name = "audi"});
            cars.Add(new Car {Name = "bmw"});
            cars.Add(new Car {Name = "mercedes"});
            cars.Add(new Car {Name = "volvo"});

            var iterator = cars.CreateIterator();

            while (iterator.HasNext())
            {
                var car = iterator.Next();
                Console.WriteLine(car.Name);
            }
        }
    }
}