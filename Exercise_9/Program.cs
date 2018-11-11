using System;
using System.Collections.Generic;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();

            carList.Add(new Car() {Color = "Blue", EngineSize = 2, FuelEconomy = 27});
            carList.Add(new Car() {Color = "Red", EngineSize = 3, FuelEconomy = 28});
            carList.Add(new Car() {Color = "Yellow", EngineSize = 2, FuelEconomy = 26});

            Console.WriteLine("All Cars");
            foreach(Car vehicle in carList)
            {
                Console.WriteLine(vehicle);
            }
            System.Console.WriteLine();

            var isBlue = carList.FindAll((car) => car.Color == "Blue");

            Console.WriteLine("Blue Cars:");
            foreach(var blueCar in isBlue)
            {
                Console.WriteLine(blueCar);
            }
            System.Console.WriteLine();

            var greaterThan2 = carList.FindAll((car) => car.EngineSize > 2);
            Console.WriteLine("Engine Size Greater than 2:");
            greaterThan2.ForEach(Console.WriteLine);
            System.Console.WriteLine();

            var lessThan28 = carList.FindAll((car) => car.FuelEconomy < 28);
            Console.WriteLine("Fuel Economy Less than 28:");
            lessThan28.ForEach(Console.WriteLine);
            System.Console.WriteLine();

            var lessThan3And28 = carList.FindAll((car) => car.EngineSize < 3 && car.FuelEconomy < 28);
            Console.WriteLine("Engine Size less than 3 and Fuel Economy less than 28:");
            lessThan3And28.ForEach(Console.WriteLine);
            System.Console.WriteLine();
        }
    }
    // Predicate<Car> isBlue = carList.FindAll( (cars) => cars.Color == "Blue");
    // Why didn't this work?
}
