using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    class dayForecast
    {
        
        public string rain, high, low, windDirection, windSpeed, temp;

        public dayForecast(string _high, string _low, string _windDirection, string _windSpeed, string _temp, string _rain)
        {
            high = _high;
            low = _low;
            windDirection = _windDirection;
            windSpeed = _windSpeed;
            temp = _temp;
            rain = _rain;
            
        }
    }
}
