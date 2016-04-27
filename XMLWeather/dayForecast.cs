using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    class dayForecast
    {
        int high, low, windDirection, windSpeed, temp;
        string typeOfDay;

        public dayForecast(int _high, int _low, int _windDirection, int _windSpeed, int _temp, string _typeOfDay)
        {
            high = _high;
            low = _low;
            windDirection = _windDirection;
            windSpeed = _windSpeed;
            temp = _temp;
            typeOfDay = _typeOfDay;
        }
    }
}
