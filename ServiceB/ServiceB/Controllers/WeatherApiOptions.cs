using System.ComponentModel.DataAnnotations;

namespace ServiceB.Controllers
{
    public class WeatherApiOptions
    {
        public const string WeatherApi = "MapSettings";
        
        [Required]
        public string Provider { get; set; }
        [Required]
        public int ZoomLevel { get; set; }

        public Cordinate Center { get; set; }

        public override string ToString() {
            return $"Provider: {Provider}\nZoomLevel: {ZoomLevel}\nlat: {Center.Latitude}\nlong:{Center.Longitude}";
        }
    }

    public class Cordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

}