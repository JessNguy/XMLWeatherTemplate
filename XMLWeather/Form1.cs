//Name: Jess Nguyen
//Topic: Weather App
//Date Start: April 20, 2016
//Date End:April 28, 2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        int day = 1;

        List<dayForecast> days = new List<dayForecast>();

        public Form1()
        {      
            InitializeComponent();
            // get information about current and forecast weather from the internet
            GetData();

            // take info from the current weather file and display it to the screen
            //ExtractCurrent();
            // take info from the forecast weather file and display it to the screen
            ExtractForecast();
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            //string currentFile = "http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            string forecastFile = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

            //download this web address file and save it into weatherdata document file
            //client.DownloadFile(currentFile, "WeatherData.xml");
            //client.DownloadFile(forecastFile, "WeatherData7Day.xml");
        }

        //private void ExtractCurrent()
        //{
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load("WeatherData.xml");

        //    //create a node variable to represent the parent element
        //    XmlNode parent;
        //    parent = doc.DocumentElement;

        //    //check each child of the parent element
        //    foreach (XmlNode child in parent.ChildNodes)
        //    {
        //        // TODO if the "city" element is found display the value of it's "name" attribute
        //        if (child.Name == "city")
        //        {
        //            cityOutput.Text = child.Attributes["name"].Value;
        //        }             
                
        //        if(child.Name == "wind")
        //        {
        //            foreach(XmlNode grandChild in child.ChildNodes)
        //            {
        //                if(grandChild.Name == "speed")
        //                {
        //                    //labelWindDir.Text = grandChild.Attributes["name"].Value;
        //                }
        //            }
        //        }
        //    }
        //}

        private void ExtractForecast()
        {

            string rain, high, low, windDirection, windSpeed, date;
            rain = high = low = windDirection = windSpeed = date = "";

            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            #region City, Country

            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "location")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "name")
                        {
                            cityOutput.Text = grandChild.InnerText;
                        }
                    }
                }
                if (child.Name == "location")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "country")
                        {
                            labelCountry.Text = grandChild.InnerText;
                        }
                    }
                }
                #endregion

                if (child.Name == "forecast")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        switch (day)
                        {
                            case 1:
                                #region Day 1
                                if (grandChild.Name == "time")
                                {
                                    date = grandChild.Attributes["day"].Value;
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    { 
                                        //"symbol" will define the image that will be shown
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        rain = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDirection = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        windSpeed= greatGrandChild.Attributes["mps"].Value;
                                    }                                   
                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        high = greatGrandChild.Attributes["max"].Value;
                                        low = greatGrandChild.Attributes["min"].Value;
                                    }
                                  
                                }
                                dayForecast df = new dayForecast(high, low, windDirection, windSpeed, rain, date);
                                days.Add(df);
                                day++;
                                #endregion
                                break;

                            case 2:
                                #region Day 2
                                if (grandChild.Name == "time")
                                {
                                    date = grandChild.Attributes["day"].Value;
                                    //labelDate.Text = Convert.ToDateTime(grandChild.Attributes["day"].Value).ToString("MMM dd");
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                       
                                        rain = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDirection = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        windSpeed = greatGrandChild.Attributes["mps"].Value;
                                    }
                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        high = greatGrandChild.Attributes["max"].Value;
                                        low = greatGrandChild.Attributes["min"].Value;
                                    }                                  
                                }
                                dayForecast df2 = new dayForecast(high, low, windDirection, windSpeed, rain, date);                               
                                days.Add(df2);
                                day++;                      
                                #endregion
                                break;

                            case 3:
                                #region Day 3
                                if (grandChild.Name == "time")
                                {
                                    date = grandChild.Attributes["day"].Value;
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        rain = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDirection = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        windSpeed = greatGrandChild.Attributes["mps"].Value;
                                    }

                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        high = greatGrandChild.Attributes["max"].Value;
                                        low = greatGrandChild.Attributes["min"].Value;
                                    }
                                   
                                }
                                dayForecast df3 = new dayForecast(high, low, windDirection, windSpeed, rain, date);
                                days.Add(df3);
                                day++;
                                #endregion
                                break;

                            case 4:
                                #region Day 4
                                if (grandChild.Name == "time")
                                {
                                    date = grandChild.Attributes["day"].Value;
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        rain = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDirection = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        windSpeed = greatGrandChild.Attributes["mps"].Value;
                                    }

                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        high = greatGrandChild.Attributes["max"].Value;
                                        low = greatGrandChild.Attributes["min"].Value;
                                    }                                 
                                }

                                dayForecast df4 = new dayForecast(high, low, windDirection, windSpeed, rain, date);
                                days.Add(df4);
                                day++;
                                #endregion
                                break;

                            case 5:
                                #region Day 5
                                if (grandChild.Name == "time")
                                {
                                    date = grandChild.Attributes["day"].Value;
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        rain = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDirection = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        windSpeed = greatGrandChild.Attributes["mps"].Value;
                                    }

                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        high = greatGrandChild.Attributes["max"].Value;
                                        low= greatGrandChild.Attributes["min"].Value;
                                    }
                                }
                                dayForecast df5 = new dayForecast(high, low, windDirection, windSpeed, rain, date);
                                days.Add(df5);
                                day++;
                                #endregion
                                break;

                            case 6:
                                #region Day 6
                                if (grandChild.Name == "time")
                                {
                                    labelDate.Text = Convert.ToDateTime(grandChild.Attributes["day"].Value).ToString("MMM dd");
                                }

                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        rain = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDirection = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        windSpeed = greatGrandChild.Attributes["mps"].Value;
                                    }

                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        high = greatGrandChild.Attributes["max"].Value;
                                        low = greatGrandChild.Attributes["min"].Value;
                                    }
                                }
                                dayForecast df6 = new dayForecast(high, low, windDirection, windSpeed, rain, date);
                                days.Add(df6);
                                day++;                                
                                #endregion
                                break;

                            case 7:
                                #region Day 7
                                if (grandChild.Name == "time")
                                {
                                    date = grandChild.Attributes["day"].Value;
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        rain = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDirection = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        windSpeed = greatGrandChild.Attributes["mps"].Value;
                                    }

                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        high = greatGrandChild.Attributes["max"].Value;
                                        low = greatGrandChild.Attributes["min"].Value;
                                    }
                                }
                                dayForecast df7 = new dayForecast(high, low, windDirection, windSpeed, rain, date);
                                days.Add(df7);
                                day++;
                                #endregion
                                break;

                            default:
                                break;
                        }                                                
                    }
                }
            }
        }

        private void MakePictureParent()
        {
            
        }

        private void buttonDay1_Click(object sender, EventArgs e)
        {
            labelMax.Text = days[0].high;
            labelMin.Text = days[0].low;
            labelWindSpd.Text = days[0].windDirection;
            labelWindSpd.Text = days[0].windSpeed;            
            labelType.Text = days[0].rain;
            labelDate.Text = days[0].date;

            //light rain, scattered clouds, heavy intensity rain, moderate rain, clear skys, broken clouds
            if (days[0].rain == "light rain")
            {
                pictureBoxTemp.Image = Properties.Resources._4;
            }
            if (days[0].rain == "scattered clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            if (days[0].rain == "heavy intensity rain")
            {
                pictureBoxTemp.Image = Properties.Resources._7;
            }
            if (days[0].rain == "moderate rain")
            {
                pictureBoxTemp.Image = Properties.Resources._3;
            }
            if (days[0].rain == "clear sky")
            {
                pictureBoxTemp.Image = Properties.Resources._2;
            }
            if (days[0].rain == "broken clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }

            this.BackColor = System.Drawing.Color.Red;
        }

        private void buttonDay2_Click(object sender, EventArgs e)
        {
            labelMax.Text = days[1].high;
            labelMin.Text = days[1].low;
            labelWindSpd.Text = days[1].windDirection;
            labelWindSpd.Text = days[1].windSpeed;          
            labelType.Text = days[1].rain;
            labelDate.Text = days[1].date;


            //light rain, scattered clouds, heavy intensity rain, moderate rain
            if (days[1].rain == "light rain")
            {
                pictureBoxTemp.Image = Properties.Resources._4;
            }
            if (days[1].rain == "scattered clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            if (days[1].rain == "heavy intensity rain")
            {
                pictureBoxTemp.Image = Properties.Resources._7;
            }
            if (days[1].rain == "moderate rain")
            {
                pictureBoxTemp.Image = Properties.Resources._3;
            }
            if (days[1].rain == "clear sky")
            {
                pictureBoxTemp.Image = Properties.Resources._2;
            }
            if (days[1].rain == "broken clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            this.BackColor = System.Drawing.Color.DarkOrange;
        }

        private void buttonDay3_Click(object sender, EventArgs e)
        {
            labelMax.Text = days[2].high;
            labelMin.Text = days[2].low;
            labelWindSpd.Text = days[2].windDirection;
            labelWindSpd.Text = days[2].windSpeed;
            labelType.Text = days[2].rain;
            labelDate.Text = days[2].date;

            //light rain, scattered clouds, heavy intensity rain, moderate rain
            if (days[2].rain == "light rain")
            {
                pictureBoxTemp.Image = Properties.Resources._4;
            }
            if (days[2].rain == "scattered clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            if (days[2].rain == "heavy intensity rain")
            {
                pictureBoxTemp.Image = Properties.Resources._7;
            }
            if (days[2].rain == "moderate rain")
            {
                pictureBoxTemp.Image = Properties.Resources._3;
            }
            if (days[2].rain == "clear sky")
            {
                pictureBoxTemp.Image = Properties.Resources._2;
            }
            if (days[2].rain == "broken clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            this.BackColor = System.Drawing.Color.Yellow;
        }

        private void buttonDay4_Click(object sender, EventArgs e)
        {
            labelMax.Text = days[3].high;
            labelMin.Text = days[3].low;
            labelWindSpd.Text = days[3].windDirection;
            labelWindSpd.Text = days[3].windSpeed;
            labelType.Text = days[3].rain;
            labelDate.Text = days[3].date;


            //light rain, scattered clouds, heavy intensity rain, moderate rain
            if (days[3].rain == "light rain")
            {
                pictureBoxTemp.Image = Properties.Resources._4;
            }
            if (days[3].rain == "scattered clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            if (days[3].rain == "heavy intensity rain")
            {
                pictureBoxTemp.Image = Properties.Resources._7;
            }
            if (days[3].rain == "moderate rain")
            {
                pictureBoxTemp.Image = Properties.Resources._3;
            }
            if (days[3].rain == "clear sky")
            {
                pictureBoxTemp.Image = Properties.Resources._2;
            }
            if (days[3].rain == "broken clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            this.BackColor = System.Drawing.Color.Lime;
        }

        private void buttonDay5_Click(object sender, EventArgs e)
        {
            labelMax.Text = days[4].high;
            labelMin.Text = days[4].low;
            labelWindSpd.Text = days[4].windDirection;
            labelWindSpd.Text = days[4].windSpeed;
            labelType.Text = days[4].rain;
            labelDate.Text = days[4].date;


            //light rain, scattered clouds, heavy intensity rain, moderate rain
            if (days[4].rain == "light rain")
            {
                pictureBoxTemp.Image = Properties.Resources._4;
            }
            if (days[4].rain == "scattered clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            if (days[4].rain == "heavy intensity rain")
            {
                pictureBoxTemp.Image = Properties.Resources._7;
            }
            if (days[4].rain == "moderate rain")
            {
                pictureBoxTemp.Image = Properties.Resources._3;
            }
            if (days[4].rain == "clear sky")
            {
                pictureBoxTemp.Image = Properties.Resources._2;
            }
            if (days[4].rain == "broken clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            this.BackColor = System.Drawing.Color.RoyalBlue;
        }

        private void buttonDay6_Click(object sender, EventArgs e)
        {
            labelMax.Text = days[5].high;
            labelMin.Text = days[5].low;
            labelWindSpd.Text = days[5].windDirection;
            labelWindSpd.Text = days[5].windSpeed;
            labelType.Text = days[5].rain;
            labelDate.Text = days[5].date;


            //light rain, scattered clouds, heavy intensity rain, moderate rain
            if (days[5].rain == "light rain")
            {
                pictureBoxTemp.Image = Properties.Resources._4;
            }
            if (days[5].rain == "scattered clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            if (days[5].rain == "heavy intensity rain")
            {
                pictureBoxTemp.Image = Properties.Resources._7;
            }
            if (days[5].rain == "moderate rain")
            {
                pictureBoxTemp.Image = Properties.Resources._3;
            }
            if (days[5].rain == "clear sky")
            {
                pictureBoxTemp.Image = Properties.Resources._2;
            }
            if (days[5].rain == "broken clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            this.BackColor = System.Drawing.Color.MidnightBlue;
        }

        private void buttonDay7_Click(object sender, EventArgs e)
        {
            labelMax.Text = days[6].high;
            labelMin.Text = days[6].low;
            labelWindSpd.Text = days[6].windDirection;
            labelWindSpd.Text = days[6].windSpeed;
            labelType.Text = days[6].rain;
            labelDate.Text = days[6].date;


            //light rain, scattered clouds, heavy intensity rain, moderate rain
            if (days[6].rain == "light rain")
            {
                pictureBoxTemp.Image = Properties.Resources._4;
            }
            if (days[6].rain == "scattered clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            if (days[6].rain == "heavy intensity rain")
            {
                pictureBoxTemp.Image = Properties.Resources._7;
            }
            if (days[6].rain == "moderate rain")
            {
                pictureBoxTemp.Image = Properties.Resources._3;
            }
            if (days[6].rain == "clear sky")
            {
                pictureBoxTemp.Image = Properties.Resources._2;
            }
            if (days[6].rain == "broken clouds")
            {
                pictureBoxTemp.Image = Properties.Resources._5;
            }
            this.BackColor = System.Drawing.Color.Purple;
        }

        
    }
}

