namespace Geosty.Views
{
    using Geosty.Helper;
    using Geosty.Models;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Xamarin.Essentials;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    /// <summary>
    /// Defines the <see cref="CurrentWeatherPage" />
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrentWeatherPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentWeatherPage"/> class.
        /// </summary>
        public CurrentWeatherPage()
        {
            InitializeComponent();
            GetCoordinates();
            //GetWeatherInfo();
        }

        /// <summary>
        /// Gets or sets the Location
        /// </summary>
        private string Location { get; set; } = "New York";

        /// <summary>
        /// Gets or sets the Latitude
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the Longitude
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// The GetCoordinates
        /// </summary>
        private async void GetCoordinates()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Best, TimeSpan.FromSeconds(30));
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    Latitude = location.Latitude;
                    Longitude = location.Longitude;
                    Location = await GetCity(location);

                    GetWeatherInfo();
                }

                if (location == null)
                    city_title.Text = "No GPS found";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// The GetCity
        /// </summary>
        /// <param name="location">The location<see cref="Location"/></param>
        /// <returns>The <see cref="Task{string}"/></returns>
        private async Task<string> GetCity(Location location)
        {
            var locations = await Geocoding.GetPlacemarksAsync(location);
            var currentPlace = locations?.FirstOrDefault();

            if (currentPlace != null)
                //return $"{currentPlace.Locality},{currentPlace.CountryName}";
            return $"{currentPlace.AdminArea}, {currentPlace.CountryName}";

            return null;
        }

        //private async void GetBackground()
        //{
        //    var url = $"https://api.pexels.com/v1/search?query={Location}+query&per_page=15&page=1";
        //    var result = await ApiCaller.Get(url, "563492ad6f9170000100000131385daf28d542d79cd704855fe04c87");

        //    if (result.Successful)
        //    {
        //        var bgInfo = JsonConvert.DeserializeObject<BackgroundInfo>(result.Response);

        //        if (bgInfo != null && bgInfo.photos.Length > 0)
        //            bg_image.Source = ImageSource.FromUri(
        //                new Uri(bgInfo.photos[new Random().Next(0, bgInfo.photos.Length - 1)]
        //                .src.portrait));
        //    }
        //}
        /// <summary>
        /// The GetWeatherInfo
        /// </summary>
        private async void GetWeatherInfo()
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={Location}&appid=88285d76c85c10d5be7b3b1bcf131a67&units=metric";
            var result = await ApiCaller.Get(url);

            if (result.Successful)
            {
                try
                {
                    var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(result.Response);
                    weather_title.Text = weatherInfo.weather[0].main.Substring(0);
                    weather_temp.Text = weatherInfo.main.temp.ToString("0");
                    weather_icon.Source = $"w{weatherInfo.weather[0].icon}";
                    humidity_Txt.Text = $"{weatherInfo.main.humidity}%";
                    wind_Txt.Text = $"{weatherInfo.wind.speed} m/s";
                    city_title.Text = weatherInfo.name.Substring(0) + ",";
                    country_title.Text = weatherInfo.sys.country;
                    current_date.Text = DateTime.Now.ToString("ddd, d MMM HH:mm");

                    GetForecast();
                    //GetBackground();
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Weather Info", ex.Message, "OK");
                }
            }
            else
            {
                await DisplayAlert("Weather Info", "No weather information could be found.", "OK");
            }
        }

        /// <summary>
        /// The GetForecast
        /// </summary>
        private async void GetForecast()
        {
            var url1 = $"https://api.openweathermap.org/data/2.5/weather?q={Location}&appid=88285d76c85c10d5be7b3b1bcf131a67&units=metric";

            var result1 = await ApiCaller.Get(url1);

            if (result1.Successful)
            {
                try
                {
                    var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(result1.Response);
                    current_weather_icon_c1.Source = $"w{weatherInfo.weather[0].icon}";
                    current_temp_text_c1.Text = weatherInfo.main.temp.ToString("0");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Weather Info", ex.Message, "OK");
                }
            }
            else
            {
                await DisplayAlert("Weather Info", "No weather information could be found.", "OK");
            }

            var url2 = $"https://api.openweathermap.org/data/2.5/forecast?q={Location}&appid=88285d76c85c10d5be7b3b1bcf131a67&units=metric";
            var result2 = await ApiCaller.Get(url2);

            if (result2.Successful)
            {
                try
                {
                    var forecastInfo = JsonConvert.DeserializeObject<ForecastInfo>(result2.Response);

                    List<List> allList = new List<List>();

                    foreach (var list in forecastInfo.list)
                    {
                        var date = DateTime.Parse(list.dt_txt);

                        if (date >= DateTime.Now)
                            allList.Add(list);
                    }

                    current_time_text_c2.Text = DateTime.Parse(allList[0].dt_txt).ToString("HH");
                    current_weather_icon_c2.Source = $"w_sm{allList[0].weather[0].icon}";
                    current_temp_text_c2.Text = allList[1].main.temp.ToString("0");

                    current_time_text_c3.Text = DateTime.Parse(allList[1].dt_txt).ToString("HH");
                    current_weather_icon_c3.Source = $"w_sm{allList[1].weather[0].icon}";
                    current_temp_text_c3.Text = allList[1].main.temp.ToString("0");

                    current_time_text_c4.Text = DateTime.Parse(allList[2].dt_txt).ToString("HH");
                    current_weather_icon_c4.Source = $"w_sm{allList[2].weather[0].icon}";
                    current_temp_text_c4.Text = allList[2].main.temp.ToString("0");

                    current_time_text_c5.Text = DateTime.Parse(allList[3].dt_txt).ToString("HH");
                    current_weather_icon_c5.Source = $"w_sm{allList[3].weather[0].icon}";
                    current_temp_text_c5.Text = allList[3].main.temp.ToString("0");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Weather Info", ex.Message, "OK");
                }
            }
            else
            {
                await DisplayAlert("Weather Info", "No forecast information could be found.", "OK");
            }
        }

        //Menu fucntions
        /// <summary>
        /// The MenuBtn_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void MenuBtn_Clicked(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The SubMenuItem1_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void SubMenuItem1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message", "Refresh Clicked", "OK");
        }

        /// <summary>
        /// The SubMenuItem2_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void SubMenuItem2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message", "About clicked", "OK");
        }

        /// <summary>
        /// The SubMenuItem3_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void SubMenuItem3_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message", "Settings clicked", "OK");
        }

        async void UpdateBtnClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CurrentWeatherPage(), true);
        }

        async void DailyBarTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DailyWeatherPage(), true);
        }
    }
}