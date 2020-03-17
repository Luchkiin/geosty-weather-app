namespace Geosty.Droid
{
    using Android.App;
    using Android.Content;
    using Android.OS;
    using Android.Support.V7.App;
    using System;

    /// <summary>
    /// Defines the <see cref="SplashActivity" />
    /// </summary>
    [Activity(Label = "Geosty",
           Theme = "@style/Theme.Splash",
           MainLauncher = true,
           NoHistory = true)]
    internal class SplashActivity : AppCompatActivity
    {
        /// <summary>
        /// The OnCreate
        /// </summary>
        /// <param name="savedInstanceState">The savedInstanceState<see cref="Bundle"/></param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        /// <summary>
        /// The OnResume
        /// </summary>
        protected override void OnResume()
        {
            try
            {
                base.OnResume();
                var intent = new Intent(this, typeof(MainActivity));
                if (Intent.Extras != null)
                {
                    intent.PutExtras(Intent.Extras);
                }
                StartActivity(intent);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}