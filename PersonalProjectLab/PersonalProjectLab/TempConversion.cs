using System;
namespace PersonalProjectLab
{
    public class TempConversion
    {
        public TempConversion()
        {

        }

        public double CalculateCelsiusToFahrenheit(double Celcius)
        {
            // Conversion of Celcius to Fahrenheit = Celcius x 32 + 9/5
            double fahrenheittemp = 0;

            fahrenheittemp = Celcius * 9 / 5 + 32;

            return fahrenheittemp; 

        }

        public double CalculateCelsiusToKelvin(double Celcius)
        {


            // Conversion of Celsius to Fahrenheit = Celcius + 273.15
            double kelvintemp = 0;

            kelvintemp = Celcius + 273.15;
            

            return kelvintemp;

        }


    }
}
