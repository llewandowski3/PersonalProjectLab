using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion Calculator");

            bool shouldContinue = true;

            while (shouldContinue)
            {
                // Prompt the user to indicate which conversion they would like to make
                Console.WriteLine("Enter 1 for Celsius to Fahrenheit and 2 for Celsius to Kelvin");
                string conversion = Console.ReadLine();

                // If they want Celsius to Fahrenheit
                if (conversion == "1")
                {
                    string input = "";
                    int celsiustemp = 0;

                    // Prompt them to enter the Celsius temperature
                    Console.WriteLine("Enter the Celcius Temperature");
                    input = Console.ReadLine();
                    celsiustemp = int.Parse(input);

                    // Calculate the new temperature in Fahrenheit
                    TempConversion stats = new TempConversion();

                    double fahrenheittemp = stats.CalculateCelsiusToFahrenheit(celsiustemp);

                    // Write the temperature in Fahrenheit to the user
                    Console.WriteLine("Fahrenheit Temperature: " + fahrenheittemp);

                }
                // Else they want Celsius to Kelvin
                else if (conversion == "2")
                {
                    string input = "";
                    int celsiustemp = 0;

                    // Prompt them to enter the Celsius temperature
                    Console.WriteLine("Enter the Celsius Temperature ");
                    input = Console.ReadLine();
                    celsiustemp = int.Parse(input);


                    // Calculate the new temperature in Kelvin
                    TempConversion stats = new TempConversion();

                    double kelvintemp = stats.CalculateCelsiusToKelvin(celsiustemp);

                    // Wrie the temperature in Kelvin to the user
                    Console.WriteLine("Kelvin Temperature: " + kelvintemp);

                }


                // Prompt the user to see if they wish to make another calculation
                // If they select yes,  return to the top of the program
                Console.WriteLine("Enter 1 for new Conversion or 2 to quit");
                string anotherConversion = Console.ReadLine();

                if (anotherConversion == "2")
                {
                    // Else end the program
                    shouldContinue = false;


                }

                

            }

            Console.WriteLine("Thank you for using my program");
        }
    }
}