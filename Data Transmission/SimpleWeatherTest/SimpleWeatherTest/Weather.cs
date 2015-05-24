using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Weather
{
    static class WeatherAPI
    {
        //Private Variables

        //Public Variables

        //Private Functions
        private static string APIStr(string zip, string country)
        {
            /*string file = @".\Key\ApiKey.txt";
            if (File.Exists(file)){
                string appID = System.IO.File.ReadAllText(file);*/
            string appID = "f17dcce9a6c111750c038c0eb4afe2ff";
                return "http://api.openweathermap.org/data/2.5/weather?zip=" + zip + "," + country + "&APPID=" + appID;
          /*  }else{
                return null;
            }*/
        }

        //Public Functions
        public static RootObject Call(string zip, string country)
        {
            RootObject data;


            WebClient c = new WebClient();
            var json = c.DownloadString(APIStr(zip, country));
            data = JsonConvert.DeserializeObject<RootObject>(json);

            return data;
        }

    }




    //JSON Classes

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Sys
    {
        public double message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double pressure { get; set; }
        public double sea_level { get; set; }
        public double grnd_level { get; set; }
        public int humidity { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public double deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class RootObject
    {
        public Coord coord { get; set; }
        public Sys sys { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
        public string @message { get; set; }
    }

  
}
