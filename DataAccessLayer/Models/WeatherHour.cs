namespace DataAccessLayer.Models
{
    public class WeatherHour
    {
        public int Id { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public WeatherStatus WeatherStatus { get; set; }
        public int WeatherStatusId { get; set; }
        public decimal Temperature { get; set; }
        public decimal RealisticTemperature { get; set; }
        public int Humidity { get; set; }
        public int WindSpeed { get; set; }
        public int Visibility { get; set; }
    }
}
