using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSpanCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age below: ");

            int yourAge = Convert.ToInt16(Console.ReadLine());

            TimeSpan ageData = new TimeSpan(yourAge * 365, 0, 0, 0);

            Console.WriteLine();
            Console.WriteLine("You have been alive for:");
            Console.WriteLine("     {0} seconds", ageData.TotalSeconds);
            Console.WriteLine("     {0} minutes", ageData.TotalMinutes);
            Console.WriteLine("     {0} hours", ageData.TotalHours);
            Console.WriteLine("     {0} days", ageData.TotalDays);
            Console.WriteLine("Press any key to exit: ");
            Console.ReadKey();
        }
    }
}
