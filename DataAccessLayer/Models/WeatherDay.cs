namespace DataAccessLayer.Models
{
    public class WeatherDay
    {
        public int Id { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public WeatherStatus WeatherStatus { get; set; }
        public int WeatherStatusId { get; set; }
        public decimal MaxTemperature { get; set; }
        public decimal MinTemperature { get; set; }
        public decimal AverageHumidity { get; set; }
        public TimeSpan SunRise { get; set; }
        public TimeSpan SunSet { get; set; }
    }
}
