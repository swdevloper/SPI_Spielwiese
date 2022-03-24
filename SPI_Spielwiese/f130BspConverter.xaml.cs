using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SPI_Spielwiese
{
    /// <summary>
    /// Interaction logic for f130BspConverter.xaml
    /// </summary>
    public partial class f130BspConverter : Window
    {
        private Window _callerWindow;
        Random rand;
        private const int MIN_NUMBER_OF_FORECASTDAYS = 1;
        private const int MAX_NUMBER_OF_FORECASTDAYS = 14;
        private const int TEMPERATURE_MIN = -10;
        private const int TEMPERATURE_MAX = 20;
        private const int TEMPERATURE_DEVIATION_MIN = 5;
        private const int TEMPERATURE_DEVIATION_MAX = 15;
        private const int NUMBEROFDECIMALS = 2;

        public f130BspConverter()
        {



            InitializeComponent();
        }


        public f130BspConverter(Window f) : this()
        {
            _callerWindow = f;
            cbxNumberOfDays.ItemsSource = Enumerable.Range(MIN_NUMBER_OF_FORECASTDAYS, MAX_NUMBER_OF_FORECASTDAYS);
            rand = new Random();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _callerWindow.Show();

            
        }

        private void btnForecast_Click(object sender, RoutedEventArgs e)
        {
            int numberOfDaysForForecast = Convert.ToInt32(cbxNumberOfDays.SelectedValue);

            List<Forecast> forecastList = new List<Forecast>();
            for (int i = 1; i <= numberOfDaysForForecast; i++)
            {
                Forecast forecast = new Forecast();
                forecast.GeneralForecast = (GeneralForecast)rand.Next(Enum.GetValues(typeof(GeneralForecast)).Length);
                forecast.TemperatureLow = GetTemperatureLow();
                forecast.TemperatureHigh = GetTemperatureHigh(forecast.TemperatureLow); 
                forecastList.Add(forecast);
            }
            DataContext = forecastList;
        }



        private double GetTemperatureLow()
        {
            double temperatureLow = rand.Next(TEMPERATURE_MIN, TEMPERATURE_MAX);
            double fraction = Math.Round(rand.NextDouble(), NUMBEROFDECIMALS);
            temperatureLow = temperatureLow + fraction;
            if (temperatureLow > TEMPERATURE_MAX)
            {
                temperatureLow = temperatureLow - 1;
            }
            return Math.Round(temperatureLow, NUMBEROFDECIMALS);
        }

        private double GetTemperatureHigh(double temperatureLow)
        {
            double temperatureToAdd =  rand.Next(TEMPERATURE_DEVIATION_MIN, TEMPERATURE_DEVIATION_MAX);
            double fraction = Math.Round(rand.NextDouble(), NUMBEROFDECIMALS);
            double temperatureHigh = temperatureLow + temperatureToAdd + fraction;
            return Math.Round(temperatureHigh, NUMBEROFDECIMALS);
        }

    }
}
