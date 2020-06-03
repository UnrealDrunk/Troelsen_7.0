using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen_7._0
{
    /// <summary>
    /// Демонстрация работы Switch(case)  на примере перечислений (энумераторов)
    /// </summary>
    public static class ExecuteTests
    {
        public static void SwitchOnEnumExample()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("SwitchOnEnumExample");
            Console.Write("Enter your favorite day of the week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }

            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Footbal!!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Anoter day, another dollar");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it's not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost friday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed/");
                    break;

            }
            Console.WriteLine();
        }







    }




}
