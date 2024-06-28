namespace RejectionSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new CSVGenerator<Book>(Bookdata.Books, "Book").Generate();
            new CSVGenerator<Weather>(WeatherData.Weather, "Weather").Generate();
        }
    }
}
