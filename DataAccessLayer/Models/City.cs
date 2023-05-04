namespace DataAccessLayer.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public Country Country { get; set; }
    }
}
