using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    class dayForecast
    {
        
        public string rain, high, low, windDirection, windSpeed, date;

        public dayForecast(string _high, string _low, string _windDirection, string _windSpeed, string _rain, string _date)
        {
            high = _high;
            low = _low;
            windDirection = _windDirection;
            windSpeed = _windSpeed;           
            rain = _rain;
            date = _date;
        }
    }
}
