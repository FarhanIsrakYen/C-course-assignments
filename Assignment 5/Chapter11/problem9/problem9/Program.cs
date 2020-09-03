﻿using System;

namespace problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2019, 12, 24),
                new DateTime(2019, 12, 25),
                new DateTime(2020, 01, 01),
                new DateTime(2020, 01, 02),
                new DateTime(2020, 03, 02),
                new DateTime(2020, 03, 03),
                new DateTime(2020, 04, 10),
                new DateTime(2020, 04, 13),
                new DateTime(2020, 05, 01),
                new DateTime(2020, 05, 06),
                new DateTime(2020, 09, 21),
                new DateTime(2020, 09, 22),
                new DateTime(2020, 12, 24),
                new DateTime(2020, 12, 25),
            };
            DateTime[] workSaturdays = new DateTime[]
            {
                new DateTime(2020, 01, 24),
                new DateTime(2020, 03, 21),
                new DateTime(2020, 09, 12),
                new DateTime(2020, 12, 12),
            };
            int workingDays = 0;
            Console.Write("Enter end date (YYYY/MM/DD): ");
            DateTime endDate = System.Convert.ToDateTime(Console.ReadLine());
            DateTime now = DateTime.Now;
            do
            {
                now = now.AddDays(1);
                if ((now.DayOfWeek >= DayOfWeek.Monday) && (now.DayOfWeek <= DayOfWeek.Friday))
                    workingDays++;
                foreach (var i in holidays)
                    if (i.Date == now.Date)
                        workingDays--;
                foreach (var i in workSaturdays)
                    if (i.Date == now.Date)
                        workingDays++;
            } while (now.Date != endDate.Date);
            Console.WriteLine($"{workingDays} working days.");
        }
    }
}
