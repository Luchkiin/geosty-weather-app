namespace Geosty
{
    using Geosty.Views;
    using Xamarin.Forms;

    /// <summary>
    /// Defines the <see cref="App" />
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CurrentWeatherPage());
            //{
            //    BarBackgroundColor = Color.FromHex("#222222"),
            //    BarTextColor = Color.FromHex("#222222")
            //};
        }

        /// <summary>
        /// The OnStart
        /// </summary>
        protected override void OnStart()
        {
        }

        /// <summary>
        /// The OnSleep
        /// </summary>
        protected override void OnSleep()
        {
        }

        /// <summary>
        /// The OnResume
        /// </summary>
        protected override void OnResume()
        {
        }
    }
}