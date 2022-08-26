using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PizzaHouseApp.UI.UserControls
{
    public class MenuButton : RadioButton
    {
        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(ImageSource), typeof(MenuButton), new PropertyMetadata(null));
    }
}
