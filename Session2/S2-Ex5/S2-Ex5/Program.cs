using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace S2_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            for (int i = 0; i < 10; i++)
            {
                cars.Add(new Car());
                Console.Out.WriteLine(cars[i].ToString());
            }

            Console.Out.WriteLine("\t Blue Cars: \t");
            cars.FindAll(IsBlue).ForEach(Console.WriteLine);

            Console.Out.WriteLine("\t Cars with engine bigger than 3l: \t");
            cars.FindAll(HasEngineBiggerThan3L).ForEach(Console.WriteLine);

            Console.Out.WriteLine("\t Cars with fuel economy lower than 10l/100km \t");
            cars.FindAll(HasFuelEconomyLowerThan10).ForEach(Console.WriteLine);

            Console.Out.WriteLine("\t Cars that are black and have engine bigger than 3l \t");
            cars.FindAll(IsBlackAndHasEngineBiggerThan3L).ForEach(Console.WriteLine);
        }

        private static bool IsBlue(Car car) => car.Color == "Blue";
        private static bool HasEngineBiggerThan3L(Car car) => car.EngineSize > 3;
        private static bool HasFuelEconomyLowerThan10(Car car) => car.FuelEconomy < 10;
        private static bool IsBlackAndHasEngineBiggerThan3L(Car car) => car.EngineSize > 3 && car.Color == "Black";
    }
}