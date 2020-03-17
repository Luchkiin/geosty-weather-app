namespace Geosty.iOS
{
    using UIKit;

    /// <summary>
    /// Defines the <see cref="Application" />
    /// </summary>
    public class Application
    {
        // This is the main entry point of the application.
        /// <summary>
        /// The Main
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/></param>
        internal static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
            UIApplication.SharedApplication.StatusBarHidden = true;
        }
    }
}