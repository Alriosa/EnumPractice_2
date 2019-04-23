using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice_2
{
    class MainClass
    {

        enum Day
        {
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat
        }

        static void Main(string[] args)
        {
            int var1 = (int) Day.Sun;
            int var2 = (int) Day.Fri;

            Console.WriteLine("Sun = {0}", var1);
            Console.WriteLine("Fri = {0}", var2);
            Console.ReadKey();
        }
    }
}
