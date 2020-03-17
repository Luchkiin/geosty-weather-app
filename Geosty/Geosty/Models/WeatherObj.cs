namespace Geosty.Models
{
    /// <summary>
    /// Defines the <see cref="ForecastInfo" />
    /// </summary>
    public class ForecastInfo
    {
        /// <summary>
        /// Gets or sets the cod
        /// </summary>
        public string cod { get; set; }

        /// <summary>
        /// Gets or sets the message
        /// </summary>
        public int message { get; set; }

        /// <summary>
        /// Gets or sets the cnt
        /// </summary>
        public int cnt { get; set; }

        /// <summary>
        /// Gets or sets the list
        /// </summary>
        public List[] list { get; set; }

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public City city { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="City" />
    /// </summary>
    public class City
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the coord
        /// </summary>
        public Coord coord { get; set; }

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// Gets or sets the population
        /// </summary>
        public int population { get; set; }

        /// <summary>
        /// Gets or sets the timezone
        /// </summary>
        public int timezone { get; set; }

        /// <summary>
        /// Gets or sets the sunrise
        /// </summary>
        public int sunrise { get; set; }

        /// <summary>
        /// Gets or sets the sunset
        /// </summary>
        public int sunset { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="List" />
    /// </summary>
    public class List
    {
        /// <summary>
        /// Gets or sets the dt
        /// </summary>
        public int dt { get; set; }

        /// <summary>
        /// Gets or sets the main
        /// </summary>
        public Main main { get; set; }

        /// <summary>
        /// Gets or sets the weather
        /// </summary>
        public Weather[] weather { get; set; }

        /// <summary>
        /// Gets or sets the clouds
        /// </summary>
        public Clouds clouds { get; set; }

        /// <summary>
        /// Gets or sets the wind
        /// </summary>
        public Wind wind { get; set; }

        /// <summary>
        /// Gets or sets the sys
        /// </summary>
        public Sys sys { get; set; }

        /// <summary>
        /// Gets or sets the dt_txt
        /// </summary>
        public string dt_txt { get; set; }

        /// <summary>
        /// Gets or sets the rain
        /// </summary>
        public Rain rain { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="Main" />
    /// </summary>
    public class Main
    {
        /// <summary>
        /// Gets or sets the temp
        /// </summary>
        public float temp { get; set; }

        /// <summary>
        /// Gets or sets the temp_min
        /// </summary>
        public float temp_min { get; set; }

        /// <summary>
        /// Gets or sets the temp_max
        /// </summary>
        public float temp_max { get; set; }

        /// <summary>
        /// Gets or sets the pressure
        /// </summary>
        public int pressure { get; set; }

        /// <summary>
        /// Gets or sets the sea_level
        /// </summary>
        public int sea_level { get; set; }

        /// <summary>
        /// Gets or sets the grnd_level
        /// </summary>
        public int grnd_level { get; set; }

        /// <summary>
        /// Gets or sets the humidity
        /// </summary>
        public int humidity { get; set; }

        /// <summary>
        /// Gets or sets the temp_kf
        /// </summary>
        public float temp_kf { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="Rain" />
    /// </summary>
    public class Rain
    {
        /// <summary>
        /// Gets or sets the _3h
        /// </summary>
        public float _3h { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="WeatherInfo" />
    /// </summary>
    public class WeatherInfo
    {
        /// <summary>
        /// Gets or sets the coord
        /// </summary>
        public Coord coord { get; set; }

        /// <summary>
        /// Gets or sets the weather
        /// </summary>
        public Weather[] weather { get; set; }

        /// <summary>
        /// Gets or sets the _base
        /// </summary>
        public string _base { get; set; }

        /// <summary>
        /// Gets or sets the main
        /// </summary>
        public Main main { get; set; }

        /// <summary>
        /// Gets or sets the visibility
        /// </summary>
        public int visibility { get; set; }

        /// <summary>
        /// Gets or sets the wind
        /// </summary>
        public Wind wind { get; set; }

        /// <summary>
        /// Gets or sets the clouds
        /// </summary>
        public Clouds clouds { get; set; }

        /// <summary>
        /// Gets or sets the dt
        /// </summary>
        public int dt { get; set; }

        /// <summary>
        /// Gets or sets the sys
        /// </summary>
        public Sys sys { get; set; }

        /// <summary>
        /// Gets or sets the timezone
        /// </summary>
        public int timezone { get; set; }

        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the cod
        /// </summary>
        public int cod { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="Coord" />
    /// </summary>
    public class Coord
    {
        /// <summary>
        /// Gets or sets the lon
        /// </summary>
        public float lon { get; set; }

        /// <summary>
        /// Gets or sets the lat
        /// </summary>
        public float lat { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="Wind" />
    /// </summary>
    public class Wind
    {
        /// <summary>
        /// Gets or sets the speed
        /// </summary>
        public float speed { get; set; }

        /// <summary>
        /// Gets or sets the deg
        /// </summary>
        public int deg { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="Clouds" />
    /// </summary>
    public class Clouds
    {
        /// <summary>
        /// Gets or sets the all
        /// </summary>
        public int all { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="Sys" />
    /// </summary>
    public class Sys
    {
        /// <summary>
        /// Gets or sets the type
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// Gets or sets the sunrise
        /// </summary>
        public int sunrise { get; set; }

        /// <summary>
        /// Gets or sets the sunset
        /// </summary>
        public int sunset { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="Weather" />
    /// </summary>
    public class Weather
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the main
        /// </summary>
        public string main { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the icon
        /// </summary>
        public string icon { get; set; }
    }
}