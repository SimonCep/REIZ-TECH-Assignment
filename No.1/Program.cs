using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;
            ReadConsole(ref hours, ref minutes);
            if(hours < 0 || hours > 24)
            {
                Console.WriteLine("An analogue clock has a maximum of 24 hours" +
                    " and a minimum of 0. Please restart the program and try again.");
                Environment.Exit(0);
            }    
            if(minutes < 0 || minutes > 60)
            {
                Console.WriteLine("An analogue clock has a maximum of 60 minutes" +
                    " and a minimum of 0. Please restart the program and try again.");
                Environment.Exit(0);
            }
            Console.WriteLine("The lesser angle is: {0} degrees", Angle(hours, minutes));
            Console.WriteLine("The program has finished it's work.");
        }
        /// <summary>
        /// Method to read the console data.
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        public static void ReadConsole(ref int hours, ref int minutes)
        {
            Console.WriteLine("Input the desired" +
                " hours and minutes of an analogue clock(in one line):");
            string temp = Console.ReadLine();
            string[] arr = temp.Split(' ');
            hours = Convert.ToInt32(arr[0]);
            minutes = Convert.ToInt32(arr[1]);
        }
        /// <summary>
        /// Method to calculate the lesser angle.
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <returns>The lesser angle between the hour and the minute hands</returns>
        public static double Angle(int hours, int minutes)
        {
            double angle;
            double HoursAngle;
            double MinutesAngle;
            if (hours == 12 && hours == 24)
                hours = 0;
            else if (hours > 12)
                hours = hours - 12;
            if (minutes == 60)
                minutes = 0;
            HoursAngle = (hours * 360 / 12) + (minutes * 360 / 720);
            MinutesAngle = minutes * 360 / 60;
            angle = Math.Abs(HoursAngle - MinutesAngle);
            angle = Math.Min(360 - angle, angle);
            return angle;
        }
    }
}
