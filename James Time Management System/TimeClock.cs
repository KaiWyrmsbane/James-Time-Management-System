namespace James_Time_Management_System
{
    public class TimeClock : ParentClasses.Time
    {
        //if time permits
        //track datetime.hours when user clocks in to the point they clock out
        //be able to tell whether user is clocked-in or clocked-out
        public bool EmployeeIsClockedIn { get; set; }
        public DateTime startTime { get; set; }

        //Remember
        //need to add PTORenewal date
        //Sicktime time, Vacation time, Emergency Time
        public bool ClockInOrOut()
        {
            Console.WriteLine("1: Clock-In");
            Console.WriteLine("2: Clock-Out");
            var clockInOrOut = Console.ReadLine();
            switch (clockInOrOut)
            {
                case "1":
                    ClockIn();
                 break;
                case "2":
                    ClockOut();
                    break;
                default:
                    break;
            }
            return EmployeeIsClockedIn;
        }
        public bool ClockIn()
        {
            if (EmployeeIsClockedIn)
            {
                Console.WriteLine("You are already clocked in");
            }
            else
            {
                EmployeeIsClockedIn = true;
                startTime = DateTime.Now;
                Console.WriteLine("You have clocked-in");
            }
            return EmployeeIsClockedIn;
        }
        public bool ClockOut()
        {
            if (!EmployeeIsClockedIn)
            {
                Console.WriteLine("You are off work already");
            }
            else
            {
                EmployeeIsClockedIn = false;
                Console.WriteLine("You have clocked-out");
                // need these to be times in hours
                HoursWorked(startTime,DateTime.Now);
            }
         
            return EmployeeIsClockedIn;
        }

        public TimeSpan HoursWorked(DateTime startTime, DateTime endTime)
        {
            TimeSpan timeWorked = endTime.Subtract(startTime);
            Console.WriteLine($"you have worked: {timeWorked.Hours} hours, {timeWorked.Minutes} Minutes, {timeWorked.Seconds}");
            return timeWorked;
        }
    }
}

