using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryListHashtableClassAndConsoleApplication
{
    class AgeFinder
    {
        DateTime Presentdatetime = DateTime.Now;


        int NumberofMonths;
        int NumberofDays;
        int NumberofYears;


        public void AgeCalculator(int Month, int Day, int Year)
        {


            NumberofYears = Presentdatetime.Year - Year;

            if (Presentdatetime.Month > Month)
            {
                NumberofMonths = Presentdatetime.Month - Month;
            }
            else if (Presentdatetime.Month < Month)
            {
                NumberofMonths = (12 - Month) + Presentdatetime.Month;
                NumberofYears = NumberofYears - 1;
            }

            if (Presentdatetime.Day > Day)
            {
                NumberofDays = Presentdatetime.Day - Day;
            }
            else if (Presentdatetime.Day < Day)
            {
                NumberofDays = 31 - Day + Presentdatetime.Day;
                NumberofMonths = NumberofMonths - 1;
            }

            Console.WriteLine($"\nAge: {NumberofYears} Years, {NumberofMonths} Months, {NumberofDays} Days");
        }

        
    }
    }
