using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace SPI_Spielwiese
{
    public class GerneralForecast2BrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Forecast forecast = (Forecast)value;
            GeneralForecast generalForecast = forecast.GeneralForecast;
            switch (generalForecast)
            {
                case GeneralForecast.Sunny:
                    return Brushes.Yellow;
                case GeneralForecast.Dry:
                    return Brushes.LightYellow;
                case GeneralForecast.Rainy:
                    return Brushes.LightGreen;
                case GeneralForecast.Cloudy:
                    return Brushes.LightGray;
                case GeneralForecast.Snowy:
                    return Brushes.LightBlue;
            }
            return Binding.DoNothing;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
