using James_Time_Management_System;
public class Program
{
    //features that are expected to be in program
    //master loop
    //unit test
    //inheritance from parent classes
    //conversion tool
    static void Main(string[] args)
    {
        RunProgram();
    }
    static public void RunProgram()
    {
        //it would be nice if the driver was it's own method
        Console.WriteLine("1 = Clock-in and Clock-out");
        Console.WriteLine("2 = Request Time Off");
        Console.WriteLine("3 = Edit Account Information");
        Console.WriteLine("4 = Exit Time Management System");

        var answer = Console.ReadLine();
        var driver = new Program();
        bool WantProgramToRun = true;

        //put the actual value you want case to have when define case
        while (WantProgramToRun)
        {
            switch (answer)
            {
                case "1":
                    driver.timeClock();
                    break;
                case "2":
                    driver.timeOff();
                    break;
                case "3":
                    driver.account();
                    break;
                case "4":
                    return;
            }
            Console.WriteLine("Would you like to do something else: ");
            Console.WriteLine("1 = Clock-in and Clock-out");
            Console.WriteLine("2 = Request Time Off");
            Console.WriteLine("3 = Edit Account Information");
            Console.WriteLine("4 = Exit Time Management System");
            answer = Console.ReadLine();
        }
    }
    public void timeClock()
    {
        var timeClock = new TimeClock();
        timeClock.ClockInOrOut();
    }
    public void timeOff()
    {
        var timeOff = new TimeOff();
        timeOff.RequestTimeOff();
    }
    public void account()
    {
        var account = new Account();
        account.AccountMenu();
    }
}
