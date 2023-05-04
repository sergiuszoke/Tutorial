using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class WeatherContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<WeatherStatus> WeatherStatus { get; set; }

        public DbSet<WeatherDay> WeatherDays { get; set; }

        public DbSet<WeatherHour> WeatherHours { get; set; }

        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {
            
        }
    }
}