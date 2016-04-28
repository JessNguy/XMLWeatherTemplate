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

        public Form1()
        {      
            InitializeComponent();
            // get information about current and forecast weather from the internet
            GetData();

            DateTime currentTime = new DateTime();
            //currentTime.TimeOfDay;
            //TimeSpan start = new TimeSpan(10, 0, 0); //10 o'clock
            //TimeSpan end = new TimeSpan(12, 0, 0); //12 o'clock
            //TimeSpan now = DateTime.Now.TimeOfDay;

            dayForecast df;

            // take info from the current weather file and display it to the screen
            //ExtractCurrent();
            // take info from the forecast weather file and display it to the screen
            ExtractForecast();
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            string currentFile = "http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            string forecastFile = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

            //download this web address file and save it into weatherdata document file
            client.DownloadFile(currentFile, "WeatherData.xml");
            client.DownloadFile(forecastFile, "WeatherData7Day.xml");
        }

        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                // TODO if the "city" element is found display the value of it's "name" attribute
                if (child.Name == "city")
                {
                    cityOutput.Text = child.Attributes["name"].Value;
                }
              
                if(child.Name =="temperature")
                {
                    labelTemp.Text = child.Attributes["value"].Value;
                }
                if(child.Name == "wind")
                {
                    foreach(XmlNode grandChild in child.ChildNodes)
                    {
                        if(grandChild.Name == "speed")
                        {
                            //labelWindDir.Text = grandChild.Attributes["name"].Value;
                        }
                    }
                }
            }
        }

        private void ExtractForecast()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            //if user presses "day 2" make 'day'(variable to 2 etc.)
            //put 'day' into a switch case 
            //in days put : country, city, temp, type of day, date, max, min ,w.dir.spd

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
                                    labelDate.Text = Convert.ToDateTime(grandChild.Attributes["day"].Value).ToString("dddd, MMMM dd, yyy");
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        labelType.Text = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        labelWindSpd.Text = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        labelWindSpd.Text += greatGrandChild.Attributes["mps"].Value;
                                    }
                                    if(greatGrandChild.Name == "temperature")
                                    {
                                   //find current time to find out if its morning, evening or night to show what the temperature is
                                        //if()
                                        //{

                                        //}
                                    }
                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        labelMax.Text = greatGrandChild.Attributes["max"].Value;
                                        labelMin.Text = greatGrandChild.Attributes["min"].Value;
                                    }
                                    if (greatGrandChild.Name == "clouds")
                                    {
                                        labelCloud1.Text = greatGrandChild.Attributes["value"].Value;
                                    }
                                }
                                #endregion
                                break;

                            case 2:
                                #region Day 2
                                if (grandChild.Name == "time")
                                {
                                    labelDate.Text = Convert.ToDateTime(grandChild.Attributes["day"].Value).ToString("dddd, MMMM dd, yyy");
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        labelType.Text = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        labelWindSpd.Text = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        labelWindSpd.Text += greatGrandChild.Attributes["mps"].Value;
                                    }

                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        labelMax.Text = greatGrandChild.Attributes["max"].Value;
                                        labelMin.Text = greatGrandChild.Attributes["min"].Value;
                                    }
                                    if (greatGrandChild.Name == "clouds")
                                    {
                                        labelCloud1.Text = greatGrandChild.Attributes["value"].Value;
                                    }
                                }
                                #endregion
                                break;

                            case 3:
                                #region Day 3
                                if (grandChild.Name == "time")
                                {
                                    labelDate.Text = Convert.ToDateTime(grandChild.Attributes["day"].Value).ToString("dddd, MMMM dd, yyy");
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        labelType.Text = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        labelWindSpd.Text = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        labelWindSpd.Text += greatGrandChild.Attributes["mps"].Value;
                                    }

                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        labelMax.Text = greatGrandChild.Attributes["max"].Value;
                                        labelMin.Text = greatGrandChild.Attributes["min"].Value;
                                    }
                                    if (greatGrandChild.Name == "clouds")
                                    {
                                        labelCloud1.Text = greatGrandChild.Attributes["value"].Value;
                                    }
                                }
                                #endregion
                                break;

                            case 4:
                                #region Day 4
                                if (grandChild.Name == "time")
                                {
                                    labelDate.Text = Convert.ToDateTime(grandChild.Attributes["day"].Value).ToString("dddd, MMMM dd, yyy");
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        labelType.Text = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        labelWindSpd.Text = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        labelWindSpd.Text += greatGrandChild.Attributes["mps"].Value;
                                    }

                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        labelMax.Text = greatGrandChild.Attributes["max"].Value;
                                        labelMin.Text = greatGrandChild.Attributes["min"].Value;
                                    }
                                    if (greatGrandChild.Name == "clouds")
                                    {
                                        labelCloud1.Text = greatGrandChild.Attributes["value"].Value;
                                    }
                                }
                                #endregion
                                break;

                            case 5:
                                #region Day 5
                                if (grandChild.Name == "time")
                                {
                                    labelDate.Text = Convert.ToDateTime(grandChild.Attributes["day"].Value).ToString("dddd, MMMM dd, yyy");
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        labelType.Text = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        labelWindSpd.Text = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        labelWindSpd.Text += greatGrandChild.Attributes["mps"].Value;
                                    }

                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        labelMax.Text = greatGrandChild.Attributes["max"].Value;
                                        labelMin.Text = greatGrandChild.Attributes["min"].Value;
                                    }
                                    if (greatGrandChild.Name == "clouds")
                                    {
                                        labelCloud1.Text = greatGrandChild.Attributes["value"].Value;
                                    }
                                }
                                #endregion
                                break;

                            case 6:
                                #region Day 6
                                if (grandChild.Name == "time")
                                {
                                    labelDate.Text = Convert.ToDateTime(grandChild.Attributes["day"].Value).ToString("dddd, MMMM dd, yyy");
                                }

                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        labelType.Text = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        labelWindSpd.Text = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        labelWindSpd.Text += greatGrandChild.Attributes["mps"].Value;
                                    }

                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        labelMax.Text = greatGrandChild.Attributes["max"].Value;
                                        labelMin.Text = greatGrandChild.Attributes["min"].Value;
                                    }
                                    if (greatGrandChild.Name == "clouds")
                                    {
                                        labelCloud1.Text = greatGrandChild.Attributes["value"].Value;
                                    }
                                }
                                #endregion
                                break;

                            case 7:
                                #region Day 7
                                if (grandChild.Name == "time")
                                {
                                    labelDate.Text = Convert.ToDateTime(grandChild.Attributes["day"].Value).ToString("MMM dd");
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        //light rain, scattered clouds, heavy intensity rain, moderate rain
                                        labelType.Text = greatGrandChild.Attributes["name"].Value;
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        labelWindSpd.Text = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        labelWindSpd.Text += greatGrandChild.Attributes["mps"].Value;
                                    }

                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        labelMax.Text = greatGrandChild.Attributes["max"].Value;
                                        labelMin.Text = greatGrandChild.Attributes["min"].Value;
                                    }
                                    if (greatGrandChild.Name == "clouds")
                                    {
                                        labelCloud1.Text = greatGrandChild.Attributes["value"].Value;
                                    }
                                }
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
            day = 1;
            
        }

        private void buttonDay2_Click(object sender, EventArgs e)
        {
            day = 2;
            
        }

        private void buttonDay3_Click(object sender, EventArgs e)
        {
            day = 3;
            
        }

        private void buttonDay4_Click(object sender, EventArgs e)
        {
            day = 4;
        }

        private void buttonDay5_Click(object sender, EventArgs e)
        {
            day = 5;
        }

        private void buttonDay6_Click(object sender, EventArgs e)
        {
            day = 6;
        }

        private void buttonDay7_Click(object sender, EventArgs e)
        {
            day = 7;
        }
    }
}

