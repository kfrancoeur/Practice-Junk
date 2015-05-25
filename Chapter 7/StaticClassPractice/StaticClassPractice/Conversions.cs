using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    static class Temp
    {

    //Fahrenheit to...
    
        // Celsius
        public static double FToC(double f)
        {
            return (f - 32) / 1.8;
        }

        //Kelvin
        public static double FToK(double f)
        {
            return CToK(FToC(f));

        }

        //I didn't know "Rankine" existed before today, but here it is.
        //Rankine
        public static double FToR(double f)
        {
            return f + 459.67;
        }

    //Celsius to...

        //Fahrenheit
        public static double CToF(double c)
        {
            return (c * 1.8) + 32;
        }

        //Kelvin
        public static double CToK(double c)
        {
            return c + 273.15;
        }

        //Rankine
        public static double CToR(double c)
        {
            return FToR(CToF(c));
        }

    //Kelvin to...

        //Celsius
        public static double KToC(double k)
        {
            return k - 273.15;
        }

        //Fahrenheit
        public static double KToF(double k)
        {
            return CToF(KToC(k));
        }

        //Rankine
        public static double KToR(double k)
        {
            return k * 1.8 ;
        }

    //Rankine to...

        //Celsius
        public static double RToC(double r)
        {
            return FToC(RToF(r));

        }

        //Fahrenheit
        public static double RToF(double r)
        {
            return r - 459.67;
        }

        //Kelvin
        public static double RToK(double r)
        {
            return r / 1.8;
        }
    }

    /*static class Distance
    {
        //I'll implement it if I ever need it.
    }*/

}
