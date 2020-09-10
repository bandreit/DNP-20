using System;
using System.Drawing;

namespace S2_Ex5
{
    public class Car
    {
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public double FuelEconomy { get; set; }
        public bool IsManualShift { get; set; }

        public Car()
        {
            generateRandomCar();
        }

        private void generateRandomCar()
        {
            Random randomGen = new Random();

            string[] colors = new[] {"Blue", "Red", "Yellow", "Black", "Green"};
            Color = colors[randomGen.Next(colors.Length)];

            EngineSize = randomGen.NextDouble() * (5.5 - 0.8) + 0.8;

            FuelEconomy = randomGen.NextDouble() * (20 - 4) + 4;

            IsManualShift = randomGen.NextDouble() > 0.5;
        }

        public override string ToString()
        {
            string txt = "";
            string IsManual = IsManualShift ? "Manual" : "Automatic";
            txt += $"A {Color}, {EngineSize:F1}l engine, {IsManual} that consumes {FuelEconomy:F}l/100km";
            return txt;
        }
    }
}