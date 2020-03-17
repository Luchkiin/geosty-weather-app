namespace Geosty.Controls
{
    using Xamarin.Forms;

    /// <summary>
    /// Defines the <see cref="BindableToolbarItem" />
    /// </summary>
    internal class BindableToolbarItem : ToolbarItem
    {
        /// <summary>
        /// Defines the IsVisibleProperty
        /// </summary>
        public static readonly BindableProperty IsVisibleProperty =
            BindableProperty.Create("BindableToolbarItem", typeof(bool), typeof(ToolbarItem),
                true, BindingMode.TwoWay, propertyChanged: OnIsVisibleChanged);

        /// <summary>
        /// Initializes a new instance of the <see cref="BindableToolbarItem"/> class.
        /// </summary>
        public BindableToolbarItem()
        {
            InitVisibility();
        }

        /// <summary>
        /// Gets or sets a value indicating whether IsVisible
        /// </summary>
        public bool IsVisible
        {
            get { return (bool)GetValue(IsVisibleProperty); }
            set { SetValue(IsVisibleProperty, value); }
        }

        /// <summary>
        /// The InitVisibility
        /// </summary>
        private void InitVisibility()
        {
            OnIsVisibleChanged(this, false, IsVisible);
        }

        /// <summary>
        /// The OnIsVisibleChanged
        /// </summary>
        /// <param name="bindable">The bindable<see cref="BindableObject"/></param>
        /// <param name="oldvalue">The oldvalue<see cref="object"/></param>
        /// <param name="newvalue">The newvalue<see cref="object"/></param>
        private static void OnIsVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var item = bindable as BindableToolbarItem;

            if (item != null && item.Parent == null)
                return;

            if (item != null)
            {
                var items = ((ContentPage)item.Parent).ToolbarItems;

                if ((bool)newvalue && !items.Contains(item))
                {
                    Device.BeginInvokeOnMainThread(() => { items.Add(item); });
                }
                else if (!(bool)newvalue && items.Contains(item))
                {
                    Device.BeginInvokeOnMainThread(() => { items.Remove(item); });
                }
            }
        }
    }
}