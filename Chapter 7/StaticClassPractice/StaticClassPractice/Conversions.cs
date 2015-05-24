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
        static double FToC(double f)
        {
            return (f - 32) / 1.8;
        }

        //Kelvin
        static double FToK(double f)
        {
            return CToK(FToC(f));

        }

        //I didn't know "Rankine" existed before today, but here it is.
        //Rankine
        static double FToR(double f)
        {
            return f + 459.67;
        }

    //Celsius to...

        //Fahrenheit
        static double CToF(double c)
        {
            return (c * 1.8) + 32;
        }

        //Kelvin
        static double CToK(double c)
        {
            return c + 273.15;
        }

        //Rankine
        static double CToR(double c)
        {
            return FToR(CToF(c));
        }

    //Kelvin to...

        //Celsius
        static double KToC(double k)
        {
            return k - 273.15;
        }

        //Fahrenheit
        static double KToF(double k)
        {
            return CToF(KToC(k));
        }

        //Rankine
        static double KToR(double k)
        {
            return FToR(KToF(k));
        }

    //Rankine to...

        //Celsius
        static double RToC(double r)
        {
            return FToC(RToF(r));

        }

        //Fahrenheit
        static double RToF(double r)
        {
            return r - 459.67;
        }

        //Kelvin
        static double RToK(double r)
        {
            return CToK(RToC(r));
        }
    }

    static class Distance
    {

    }

}
