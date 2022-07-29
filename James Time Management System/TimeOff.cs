using System;
using System.Globalization;
namespace James_Time_Management_System
{
    public class TimeOff : ParentClasses.Time
    {
        //then make it  to where there is only a certain number of hours they can take off
        //need a total amount of time they can take off so the user can't go over the alotted amount
        public void TimeOffSubMenu()
        {
            employeeHours = 8.0f;
            DisplayPTORenewalDate();
            DisplayPTOTime();
            Console.WriteLine("1: Taking a day off");
            Console.WriteLine("2: Taking Multiple days off");
            Console.WriteLine("3: Convert time");
            string TimeOffSubMenuAnswer = Console.ReadLine();
            switch (TimeOffSubMenuAnswer)
            {
                case "1":
                    Console.WriteLine("Enter the Day you wish to take off (MM/DD/YYYY);");
                    DateTime startDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("What Time are you taking from");
                    Console.WriteLine("1: Sick");
                    Console.WriteLine("2: Vacation");
                    Console.WriteLine("3: Emergency");
                    var timeTypeAnswer = Console.ReadLine();
                    switch (timeTypeAnswer)
                    {
                        case "1":
                            DayOff(startDate, employeeHours);
                            sickHours -= employeeHours;
                            break;
                        case "2":
                            DayOff(startDate, employeeHours);
                            vacationHours -= employeeHours;
                            break;
                        case "3":
                            DayOff(startDate, employeeHours);
                            emergencyHours -= employeeHours;
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Enter the first date (MM/DD/YYYY);");
                    startDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second date (MM/DD/YYYY)");
                    DateTime endDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("What Time are you taking from");
                    Console.WriteLine("1: Sick");
                    Console.WriteLine("2: Vacation");
                    Console.WriteLine("3: Emergency");
                    timeTypeAnswer = Console.ReadLine();
                    switch (timeTypeAnswer)
                    {
                        case "1":
                            MoreThanADayOff(startDate,endDate,sickHours);
                            sickHours -= employeeHours;
                            break;
                        case "2":
                            MoreThanADayOff(startDate,endDate,vacationHours);
                            vacationHours -= employeeHours;
                            break;
                        case "3":
                            MoreThanADayOff(startDate,endDate,emergencyHours);
                            emergencyHours -= employeeHours;
                            break;
                    }
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
        public TimeSpan MoreThanADayOff(DateTime startDate, DateTime endDate, float timeType)
        {
            TimeSpan DaysPassed = endDate.Subtract(startDate);
            var days = DaysPassed.Days;
            employeeHours = employeeHours * days;
            timeType = timeType - employeeHours;
            if (timeType >= 0)
            {
                Console.WriteLine($"You are off from {startDate} to {endDate} using {employeeHours} hours of PTO time");
            }
            else
            {
                employeeHours = 0;
                Console.WriteLine($"You have exceeded your approved PTO hours");
            }
            return DaysPassed;
        }

        //Conversion tool
        // 0.125 point = 1.0 hours
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
