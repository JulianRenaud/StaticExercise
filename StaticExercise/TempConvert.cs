using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConvert
    {
        public static double FahrenheitToCelsius(double userInput)
        {
            double Answer = (userInput - 32) * 0.5556;
            return Answer;
        }

        public static double CelsiusToFahrenheit(double userInput)
        {
            double Answer = (userInput / 0.5556) + 32;
            return Answer;
        }
    }
}
