using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class SecondProgram

    {
        enum Marks
        {
            verybad,
            bad,
            good,
            average,
            excellent
        }
        static void Main(string[] args)
        {
            //MarksCalculation();

            //numberRange();
            //DayOfWeek();
            Console.ReadLine();


            void numberRange()
            {
                Console.WriteLine("Enter  a number");
                int no1 = Convert.ToInt32(Console.ReadLine());
                if (no1 < 0)
                {
                    Console.WriteLine("Number smaller than 0");
                    Console.WriteLine($"number is {no1}");
                }
                else if (no1 > 0 && no1 <= 10)
                {
                    Console.WriteLine("Number is in range of 1 to 10");
                }
                else
                {
                    Console.WriteLine("Negative input or zero");
                    Console.WriteLine($"number is {no1}");
                }
            }

            void MarksCalculation()
            {
                Console.WriteLine("Enter Marks");
                int m = Convert.ToInt32(Console.ReadLine());
                Marks priority;
                if (m < 35)
                {
                    priority = Marks.verybad;
                }
                else if (m > 35 && m < 50)
                {
                    priority = Marks.average;
                }
                else if (m > 50)
                {
                    priority = Marks.good;
                }
                else
                {
                    priority = Marks.excellent;
                }
                switch (priority)
                {

                    case Marks.verybad:
                        Console.WriteLine("Marks are very bad");
                        break;

                    case Marks.bad:
                        Console.WriteLine("Marks are bad ");
                        break;
                    case Marks.good:
                        Console.WriteLine("Marks are very good");
                        break;
                    case Marks.average:
                        Console.WriteLine("Marks are very average");
                        break;
                    case Marks.excellent:
                        Console.WriteLine("Marks are very excellent");
                        break;
                }
            }
        }

        private static void DayOfWeek()
        {
            Console.WriteLine("Enter  a date");
            DateTime dt = Convert.ToDateTime(Console.ReadLine());
            switch (dt.DayOfWeek)
            {
                case System.DayOfWeek.Monday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case System.DayOfWeek.Tuesday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case System.DayOfWeek.Wednesday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case System.DayOfWeek.Friday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case System.DayOfWeek.Thursday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case System.DayOfWeek.Saturday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case System.DayOfWeek.Sunday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                default:
                    Console.WriteLine("Its not 1 or 2");
                    break;



            }
        }
    }
}
