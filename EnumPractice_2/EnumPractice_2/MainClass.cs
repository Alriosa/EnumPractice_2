using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice_2
{
    class MainClass
    {

        enum Day
        {
            Sun = 1 ,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserte una opcion");
            Console.WriteLine("1 - Sunday");
            Console.WriteLine("2 - Monday");
            Console.WriteLine("3 - Tuesday");
            Console.WriteLine("4 - Wednesday");
            Console.WriteLine("5 - Thursday");
            Console.WriteLine("6 - Friday");
            Console.WriteLine("7 - Saturday");
            

            Menu();

            




            //int var1 = (int) Day.Sun;
            //int var2 = (int) Day.Sat;

            
        }

        public static void Menu()
        {
            int opcion;
            int printEnum;
            opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    printEnum = (int)Day.Sun;
                    Console.WriteLine("Sun = {0}", printEnum);
                    waitKey();
                    break;
                case 2:
                    printEnum = (int)Day.Mon;
                    Console.WriteLine("Mon = {0}", printEnum);
                    waitKey();
                    break;
                case 3:
                    printEnum = (int)Day.Tue;
                    Console.WriteLine("Tue = {0}", printEnum);
                    waitKey();
                    break;
                case 4:
                    printEnum = (int)Day.Wed;
                    Console.WriteLine("Wed = {0}", printEnum);
                    waitKey();
                    break;
                case 5:
                    printEnum = (int)Day.Thu;
                    Console.WriteLine("Thu = {0}", printEnum);
                    waitKey();
                    break;
                case 6:
                    printEnum = (int)Day.Fri;
                    Console.WriteLine("Fri = {0}", printEnum);
                    waitKey();
                    break;
                case 7:
                    printEnum = (int)Day.Sat;
                    Console.WriteLine("Sat = {0}", printEnum);
                    waitKey();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    Menu();
                    break;
            }
        }

        public static void waitKey()
        {
            Console.ReadKey();
        }
    }
}
