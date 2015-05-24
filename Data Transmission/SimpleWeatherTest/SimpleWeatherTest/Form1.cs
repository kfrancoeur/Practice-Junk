using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather;
using Conversions;


namespace SimpleWeatherTest
{
    public partial class WeatherWindow : Form
    {
    //Private Variables
        private RootObject currWeather;
        private RadioButton[] rbtns;
        private int tempScale;
        // 1 = Celsius, 2 = Fahrenheit

    //Constructor
        public WeatherWindow()
        {
            InitializeComponent();
            rbtns = new RadioButton[] { CTempRadio, FTempRadio, KTempRadio, RTempRadio };

            for (int i = 0; i < rbtns.Length; i++)
            {
                rbtns[i].Tag = i;
                rbtns[i].CheckedChanged += new EventHandler(radionButtons_CheckedChanged);
            }
        }

        private void radionButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = sender as RadioButton;
            if (rbtn != null)
            {
                tempScale = (int)rbtn.Tag;
                if (TemperatureText.Text != "")
                {
                    TemperatureSet();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
        }

        private void TemperatureButton_Click(object sender, EventArgs e)
        {
            currWeather = WeatherAPI.Call(ZipText.Text, "us");

            if (currWeather.cod != 404)
            {
                LocationSet();
                TemperatureSet();
            }

        }


        //Textbox manipulation functions
        private void LocationSet()
        {
            //Convert raw location data to more human readable format.
            LocText.Text =
                ((currWeather.coord.lon > 0) ? Math.Round(currWeather.coord.lon, 2) + "°N " :
                    Math.Abs(Math.Round(currWeather.coord.lon, 2)) + "°S ") +
                ((currWeather.coord.lat > 0) ? Math.Round(currWeather.coord.lat, 2) + "°E" :
                    Math.Abs(Math.Round(currWeather.coord.lat, 2)) + "°W");
        }

        //Sets relevant temperature boxes
        private void TemperatureSet()
        {

            TemperatureText.Text = TempParse(currWeather.main.temp);
            //HiTempText.Text = TempParse(currWeather.main.temp_max);
            //LowTempText.Text = TempParse(currWeather.main.temp_min);

        }

        //Rounds, converts to proper temperature scale.
        private string TempParse(double temp)
        {
            switch (tempScale)
            {
                case 0:
                    temp = Temp.KToC(temp);
                    break;
                case 1:
                    temp = Temp.KToF(temp);
                    break;
                case 2:
                    break;
                case 3:
                    temp = Temp.KToR(temp);
                    break;
            }

            return Math.Round(temp,2).ToString();
            
        }

    }
}
