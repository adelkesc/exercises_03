using System;
using System.Collections.Generic;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            cars.Add(new Car { Color = Colors.Red, EngineSize = 1, FuelEconomy = 20.3});
            cars.Add(new Car { Color = Colors.Green, EngineSize = 2, FuelEconomy = 11.7});
            cars.Add(new Car { Color = Colors.Blue, EngineSize = 3, FuelEconomy = 6.2});
            System.Console.WriteLine("All cars");
            cars.ForEach(System.Console.WriteLine);

            System.Console.WriteLine("Red cars");
            var redCars = cars.FindAll( (car) => car.Color == Colors.Red );
            redCars.ForEach(Console.WriteLine);

            System.Console.WriteLine("Engine size larger than 2");
            (cars.FindAll( (c) => c.EngineSize > 2))
                .ForEach(Console.WriteLine);

            System.Console.WriteLine("Fuel economy lower than 12");
            (cars.FindAll( (c) => c.FuelEconomy < 12))
                .ForEach(Console.WriteLine);

            System.Console.WriteLine("Engine size lower than 3 and Green");
            (cars.FindAll( (c) => c.EngineSize < 3 && c.Color == Colors.Green))
                .ForEach(Console.WriteLine);
        }
    }
}
