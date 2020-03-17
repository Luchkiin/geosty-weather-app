namespace Geosty.Models
{
    /// <summary>
    /// Defines the <see cref="WeatherViewModel" />
    /// </summary>
    internal class WeatherViewModel
    {
        /// <summary>
        /// Gets or sets the Temp
        /// </summary>
        public int Temp { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherViewModel"/> class.
        /// </summary>
        public WeatherViewModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherViewModel"/> class.
        /// </summary>
        /// <param name="temp">The temp<see cref="int"/></param>
        public WeatherViewModel(int temp)
        {
            Temp = temp;
        }
    }
}