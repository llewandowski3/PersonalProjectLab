using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab; 

namespace PersonalProjectLabTests
{
    [TestClass]
    public class TemperatureConversionTests
    {
        [TestMethod]
        public void TemperatureConversion_CalculateCelsiusToFahrenheit()
        {
            // Arrange
            TemperatureConversion stats = new TemperatureConversion();

            // Acting
            double fahrenheittemp = stats.CalculateCelsiusToFahrenhrheit(20);

            // Asserting
            Assert.AreEqual(68, fahrenheittemp);

        }

        [TestMethod]
        public void TemperatureConversion_CalculateCelsiusToKelvin()
        {
            //Arrange
            TemperatureConversion stats = new TemperatureConversion();

            //Acting
            double kelvintemp = stats.CalculateCelsiusToKelvin(20);

            //Asserting
            Assert.AreEqual(293.15, kelvintemp);


        }
    }
}
