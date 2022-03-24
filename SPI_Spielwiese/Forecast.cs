﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPI_Spielwiese
{

    public enum GeneralForecast
    {
        Sunny,
        Dry,
        Rainy,
        Cloudy,
        Snowy
    }


    public class Forecast
    {
        public GeneralForecast GeneralForecast { get; set; }
        public double TemperatureHigh { get; set; }
        public double TemperatureLow { get; set; }


    }
}
