namespace Geosty.Converters
{
    using System;
    using System.Globalization;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    /// <summary>
    /// Defines the <see cref="BgConverter" />
    /// </summary>
    internal class BgConverter : IMarkupExtension, IValueConverter
    {
        /// <summary>
        /// Gets or sets a value indicating whether IsStart
        /// </summary>
        public bool IsStart { get; set; }

        /// <summary>
        /// The Convert
        /// </summary>
        /// <param name="value">The value<see cref="object"/></param>
        /// <param name="targetType">The targetType<see cref="Type"/></param>
        /// <param name="parameter">The parameter<see cref="object"/></param>
        /// <param name="culture">The culture<see cref="CultureInfo"/></param>
        /// <returns>The <see cref="object"/></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is float temp)
            {
                var resources = Application.Current.Resources;

                if (temp >= 20)
                    return IsStart ? resources["WarmStartColor"] : resources["WarmEndColor"];

                if (temp <= -5)
                    return IsStart ? resources["ColdStartColor"] : resources["ColdEndColor"];

                return IsStart ? resources["NormalStartColor"] : resources["NormalEndColor"];
            }

            var resources1 = Application.Current.Resources;

            return IsStart ? resources1["NormalStartColor"] : resources1["NormalEndColor"];
        }

        /// <summary>
        /// The ConvertBack
        /// </summary>
        /// <param name="value">The value<see cref="object"/></param>
        /// <param name="targetType">The targetType<see cref="Type"/></param>
        /// <param name="parameter">The parameter<see cref="object"/></param>
        /// <param name="culture">The culture<see cref="CultureInfo"/></param>
        /// <returns>The <see cref="object"/></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The ProvideValue
        /// </summary>
        /// <param name="serviceProvider">The serviceProvider<see cref="IServiceProvider"/></param>
        /// <returns>The <see cref="object"/></returns>
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}