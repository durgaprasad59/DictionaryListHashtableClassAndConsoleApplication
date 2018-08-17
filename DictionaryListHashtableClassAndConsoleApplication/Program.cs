using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryListHashtableClassAndConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------Age Calculator App--------------------\n");
            Console.WriteLine("Enter Your Date of Birth (MM/DD/YYYY)\n");
            Console.Write("Enter the Month: ");
            int usermonth = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Day: ");
            int userday = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Year: ");
            int useryear = Convert.ToInt16(Console.ReadLine());


            AgeFinder Agecal = new AgeFinder();

            Agecal.AgeCalculator(usermonth, userday, useryear);
            
            Console.ReadKey();
        }

        
    }
}
