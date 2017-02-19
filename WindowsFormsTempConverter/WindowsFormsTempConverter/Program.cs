using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTempConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Tempature
    {
        public static double FahrenheitToCelsius(double temp)
        {

            double f;
            f = temp;
            return (f - 32) * 5 / 9;

        }
        public static double CelsiusToFahrenheit(double temp)
        {
            double c;
            c = temp;
            return c * 9 / 5 + 32;
        }
        public static double KelvinToCelsius(double temp)
        {
            double k;
            k = temp;
            return k - 273.15;
        }
        public static double CelsiusToKelvin(double temp)
        {
            double c;
            c = temp;
            return c + 273.15;
        }
        public static double FahrenheitToKelvin(double temp)
        {
            double f;
            f = temp;
            return (f + 459.67) * 5 / 9;
        }
        public static double KelvinToFahrenheit(double temp)
        {
            double k;
            k = temp;
            return k * 9 / 5 - 459.67;
        }
        public static double AnyToAny(double temp, String deg1, String deg2)
        {
            string deg1temp;
            string deg2temp;
            deg1temp = FirstLetterToUpper(deg1);
            deg2temp = FirstLetterToUpper(deg2);
            String methodName = deg1temp + "To" + deg2temp;

            if (deg1.ToLower().Equals("fahrenheit"))
            {
                if (methodName.Equals("FahrenheitToCelsius"))
                {
                    return FahrenheitToCelsius(temp);
                }
                else if (methodName.Equals("FahrenheitToKelvin"))
                {
                    return FahrenheitToKelvin(temp);
                }
            }
            else if (deg1.ToLower().Equals("celsius"))
            {
                if (methodName.Equals("CelsiusToFahrenheit"))
                {
                    return CelsiusToFahrenheit(temp);
                }
                else if (methodName.Equals("CelsiusToKelvin"))
                {
                    return CelsiusToKelvin(temp);
                }
            }
            else if (deg1.ToLower().Equals("kelvin"))
            {
                if (methodName.Equals("KelvinToFahrenheit"))
                {
                    return KelvinToFahrenheit(temp);
                }
                else if (methodName.Equals("KelvinToCelsius"))
                {
                    return KelvinToCelsius(temp);
                }
            }

            return temp;
        }
        public static string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
    }
}

