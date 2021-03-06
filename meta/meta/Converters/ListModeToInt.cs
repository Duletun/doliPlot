using System;
using System.Globalization;

using meta.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace meta.Converters
{
    public class ListModeToVisibility: IValueConverter, IMarkupExtension
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((ListMode)value) == ListMode.Vertical;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
