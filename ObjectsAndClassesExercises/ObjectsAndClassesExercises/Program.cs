using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.CurrentCulture;
            string format = "dd-MM-yyyy";
            string holidaysFormat = "dd-MM";
            DateTime[] holidays = new DateTime[12];
            holidays[0] = DateTime.ParseExact("01-01", holidaysFormat, provider);
            holidays[1] = DateTime.ParseExact("03-03", holidaysFormat, provider);
            holidays[2] = DateTime.ParseExact("01-05", holidaysFormat, provider);
            holidays[3] = DateTime.ParseExact("06-05", holidaysFormat, provider);
            holidays[4] = DateTime.ParseExact("24-05", holidaysFormat, provider);
            holidays[5] = DateTime.ParseExact("06-09", holidaysFormat, provider);
            holidays[6] = DateTime.ParseExact("22-09", holidaysFormat, provider);
            holidays[7] = DateTime.ParseExact("01-11", holidaysFormat, provider);
            holidays[8] = DateTime.ParseExact("24-12", holidaysFormat, provider);
            holidays[10] = DateTime.ParseExact("25-12", holidaysFormat, provider);
            holidays[11] = DateTime.ParseExact("26-12", holidaysFormat, provider);

            int workingDays = 0;
            string startDateInput = Console.ReadLine();
            string endDateInput = Console.ReadLine();                        
            DateTime startDate = DateTime.ParseExact(startDateInput, format, provider);
            DateTime endDate = DateTime.ParseExact(endDateInput, format, provider);
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday &&
                    i.DayOfWeek != DayOfWeek.Sunday &&
                    (i.Day != holidays[0].Day || i.Month != holidays[0].Month) &&
                    (i.Day != holidays[1].Day || i.Month != holidays[1].Month) &&
                    (i.Day != holidays[2].Day || i.Month != holidays[2].Month) &&
                    (i.Day != holidays[3].Day || i.Month != holidays[3].Month) &&
                    (i.Day != holidays[4].Day || i.Month != holidays[4].Month) &&
                    (i.Day != holidays[5].Day || i.Month != holidays[5].Month) &&
                    (i.Day != holidays[6].Day || i.Month != holidays[6].Month) &&
                    (i.Day != holidays[7].Day || i.Month != holidays[7].Month) &&
                    (i.Day != holidays[8].Day || i.Month != holidays[8].Month) &&
                    (i.Day != holidays[9].Day || i.Month != holidays[9].Month) &&
                    (i.Day != holidays[10].Day || i.Month != holidays[10].Month) &&
                    (i.Day != holidays[11].Day || i.Month != holidays[11].Month)) {
                        workingDays++;
                }
            }
            Console.WriteLine(workingDays);
        }
    }
}
