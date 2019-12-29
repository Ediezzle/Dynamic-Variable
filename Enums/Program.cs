using System;

namespace Enums
{
    class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            

        Console.WriteLine(Enum.GetName(typeof(WeekDays), 4));

            Console.WriteLine("WeekDays constant names:");

            foreach (string str in Enum.GetNames(typeof(WeekDays)))
                        Console.WriteLine(str);

            foreach (int i in Enum.GetValues(typeof(WeekDays)))
                Console.WriteLine(i);

            Console.WriteLine("Enum.TryParse():");

            WeekDays wdEnum;
                    Enum.TryParse<WeekDays>("1", out wdEnum);
            Console.WriteLine(wdEnum);
            
        }
    }
}
