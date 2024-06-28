using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejectionSamples
{
    public class Weather
    {
        public string City { get; set; }
        public string Description { get; set; }
        public double TemperatureCentrigrade { get; set; }
        public double RainfallInches { get; set; }
    }
    public static class WeatherData
    {
        public static IEnumerable<Weather> Weather = new List<Weather>()
        {
            new Weather
            {
                City = "cityA",
                Description = "DescriptionA",
                TemperatureCentrigrade = 19,
                RainfallInches = 20,
            },
            new Weather
            {
                City = "cityB",
                Description = "DescriptionB",
                TemperatureCentrigrade = 12,
                RainfallInches = 22,
            },
            new Weather
            {
                City = "cityC",
                Description = "DescriptionC",
                TemperatureCentrigrade = 29,
                RainfallInches = 28,
            },
            new Weather
            {
                City = "cityD",
                Description = "DescriptionD",
                TemperatureCentrigrade = 19,
                RainfallInches = 8,
            },
        };
    }
}
