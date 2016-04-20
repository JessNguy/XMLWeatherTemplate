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
        public Form1()
        {
            InitializeComponent();

            // get information about current and forecast weather from the internet
            GetData();

            // take info from the current weather file and display it to the screen
            ExtractCurrent();

            // take info from the forecast weather file and display it to the screen
            ExtractForecast();
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            string currentFile = "http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            string forecastFile = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";
            
            //download this web address file and save it into weatherdata document file
              //client.DownloadFile(currentFile, "WeatherData.xml");
              //client.DownloadFile(forecastFile, "WeatherData7Day.xml");
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
                            labelWind.Text = grandChild.Attributes["name"].Value;
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

            int day = 1;
            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
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
                        foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                        {
                            //if (greatGrandChild.Name == "symbol var")
                            //{
                            //    labelType.Text = greatGrandChild.Attributes["name"].Value;
                            //}
                            if (greatGrandChild.Name == "temperature")
                            {
                                switch (day)
                                {
                                    case 1:
                                        labelMax.Text = greatGrandChild.Attributes["max"].Value;
                                        labelMin.Text = greatGrandChild.Attributes["min"].Value;

                                        break;
                                    case 2:
                                        labelMax2.Text = greatGrandChild.Attributes["max"].Value;
                                        label1.Text = greatGrandChild.Attributes["min"].Value;

                                        break;
                                    default:
                                        break;
                                }
                            }

                            if (greatGrandChild.Name == "clouds")
                            {
                                switch (day)
                                {
                                    case 1:
                                        labelCloud1.Text = greatGrandChild.Attributes["value"].Value;
                                        day++;
                                        break;
                                    case 2:
                                        labelCloud2.Text = greatGrandChild.Attributes["value"].Value;
                                        day++;
                                        break;
                                    default:
                                        break;
                                }
                            }
                       
                        }
                    }
                }
            }
        }


        private void MakePictureParent()
        {
            
        }

  
    }
}
