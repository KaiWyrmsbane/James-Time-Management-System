namespace James_Time_Management_System
{
    public class TimeClock : ParentClasses.Time
    {
        //we want to some how record the datetime when EmployeeIsClockedIn = true then when it = false
        public bool EmployeeIsClockedIn { get; set; }
        //public DateTime clockedInTime = DateTime.Compare
        public void ClockInOrOut()
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

        }
        public bool ClockIn()
        {
            EmployeeIsClockedIn = true;
            Console.WriteLine("You have clocked-in " + DateTime.Now);
            return EmployeeIsClockedIn;
        }
        public bool ClockOut()
        {
            EmployeeIsClockedIn = false;
            Console.WriteLine("You have clocked-out at: " + DateTime.Now);
            return EmployeeIsClockedIn;
        }
        //need to have a calculation that tells the time between 2 DateTimes
    }
}

