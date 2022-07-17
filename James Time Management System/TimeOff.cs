using System;
using System.Globalization;
using System.Linq;

namespace James_Time_Management_System
{
    //Question: How to use the returns from other methods inside RequestTimeOff()
    public class TimeOff : ParentClasses.Time
    {
        //remember to have PTOrenewal date on here
        //we also may wnat to create a log that way the user's request is stored
        public void RequestTimeOff()
        {
            DateUserIsTakingOff();
            ReasonUserIsTakingOff();
            NumberOfHoursUserIsTakingOff(7.5f);
        }
        //may need help with writing this method
        public DateTime DateUserIsTakingOff()
        {
            Console.WriteLine("Date of the day you want off (MM/DD/YYYY):");
            var userInputDate = Console.ReadLine();
            DateTime userDate = Convert.ToDateTime(userInputDate);
            //the .Date.ToString("MM/dd/yyyy") will remove time from the date
            Console.WriteLine(userDate.Date.ToString("MM/dd/yyyy"));

            return userDate.Date;

        }

        public string ReasonUserIsTakingOff()
        {
            Console.WriteLine($"Enter the reason for taking off");
            string userReason = Console.ReadLine();
            return userReason;
        }
        //i would like to try and pass in the full hours of the user's work day that way they can only ask off the amount of hours they work
        // float userWorkHours = 0f;
        public float NumberOfHoursUserIsTakingOff(float userWorkHours)
        {
            //userWorkHours may default to 0 
            Console.WriteLine("Number of hours taking off: ");
            float hoursUserIsTakingOff = float.Parse(Console.ReadLine());
            if (hoursUserIsTakingOff > userWorkHours)
            {
                Console.WriteLine("You can't take off more than you work");
            }
            else
            {
                Console.WriteLine($"You are taking off {hoursUserIsTakingOff}");
            }
            return hoursUserIsTakingOff;
        }

    }
}
