using System;
using System.Globalization;
//create a conversion tool
//then make it  to where there is only a certain number of hours they can take off
//be sure to add PTORenewal Date
namespace James_Time_Management_System
{
    public class TimeOff : ParentClasses.Time
    {
        //then make it  to where there is only a certain number of hours they can take off
        //be sure to add PTORenewal Date
        //need a total amount of time they can take off so the user can't go over the alotted amount
        public void TimeOffSubMenu()
        {
            //vacationhours = 112 hours
            //sickhours = 56 hours
            //emergencyhours = 24 hours
            employeeHours = 8.0f;
            Console.WriteLine("1: Taking a day off");
            Console.WriteLine("2: Taking Multiple days off");
            Console.WriteLine("3: Convert time");
            string TimeOffSubMenuAnswer = Console.ReadLine();
            switch (TimeOffSubMenuAnswer)
            {
                case "1":
                    Console.WriteLine("Enter the Day you wish to take off (MM/DD/YYYY);");
                    DateTime startDate = DateTime.Parse(Console.ReadLine());
                    DayOff(startDate, employeeHours);
                    break;
                case "2":
                    Console.WriteLine("Enter the first date (MM/DD/YYYY);");
                    startDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second date (MM/DD/YYYY)");
                    DateTime endDate = DateTime.Parse(Console.ReadLine());
                    MoreThanADayOff(startDate, endDate, employeeHours);
                    break;
                case "3":
                    Console.WriteLine("1: Convert Points to hours");
                    Console.WriteLine("2: Convert hours to Points");
                    string conversionAnswer = Console.ReadLine();
                    if (conversionAnswer == "1")
                    {
                        Console.WriteLine("Enter the Number of points you want to convert");
                        float Points = float.Parse(Console.ReadLine());
                        PointToHourConversion(Points);
                    }
                    else
                    {
                        Console.WriteLine("Enter the Number of hours you want to convert");
                        float hours = float.Parse(Console.ReadLine());
                        HourToPointConversion(hours);
                    }
                    break;
            }

        }
        public DateTime DayOff(DateTime startDate, float userDailyHours)
        {
            Console.WriteLine($"You are off on {startDate} for {userDailyHours} hours`");
            return startDate;
        }
        //I might want to make userDailyHours in it's own method
        public TimeSpan MoreThanADayOff(DateTime startDate, DateTime endDate, float userDailyHours)
        {
            TimeSpan DaysPassed = endDate.Subtract(startDate);
            Console.WriteLine(DaysPassed);
            var days = DaysPassed.Days;
            userDailyHours = userDailyHours * days;
            Console.WriteLine($"You are off for {userDailyHours} hours, from {startDate} - {endDate}");
            return DaysPassed;
        }

        //Conversion tool
        // 0.125 point = 1.0 hours
        //make sure that the public employeeHours and employeePoints will not be affected
        public float HourToPointConversion(float employeeHours)
        {
            employeePoints = 0.125f * employeeHours;
            Console.WriteLine($"The equivalence is {employeePoints} points");
            return employeePoints;
        }
        public float PointToHourConversion(float employeePoints)
        {
            employeeHours = employeePoints / 0.125f;
            Console.WriteLine($"The equivalence is {employeeHours} hours");
            return employeeHours;
        }
    }
}
