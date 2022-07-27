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
            Console.WriteLine("Are you taking off more than one day (yes/no): ");
            string yesOrNo = Console.ReadLine();
            if (yesOrNo == "yes")
            {
                Console.WriteLine("Enter the first date (MM/DD/YYYY);");
                DateTime startDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second date (MM/DD/YYYY)");
                DateTime endDate = DateTime.Parse(Console.ReadLine());
                MoreThanADayOff(startDate, endDate, employeeHours);
            }
            else
            {
                Console.WriteLine("Enter the Day you wish to take off (MM/DD/YYYY);");
                DateTime startDate = DateTime.Parse(Console.ReadLine());
                DayOff(startDate, employeeHours);
            }
        }
        public DateTime DayOff(DateTime startDate, float userDailyHours)
        {
            Console.WriteLine($"You are off on {startDate} all day for {userDailyHours} hours`");
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

        //lets create a conversion tool for points to hours
        /*
        1.0 point = 8.0 hours
        0.5 point = 4.0 hours
        0.25 point = 2.0 hours
        0.125 point = 1.0 hours
        Kassi Approved ******
        public float PointsToHours(float employeeHours, float employeePoints)
        {
         Console.WriteLine("Which would you like to do");
         Console.WriteLine("1: Convert hours to points");
         Console.WriteLine("2: Convert points to hours");
         var answer = Console.ReadLine();
         if(answer == "1")
          {
            employeePoints = 0.125 * employeeHours;
          }
         else
          {
            employeeHours = employeeHours / 0.125;
          }

        }

        */
    }
}
