﻿using James_Time_Management_System;
public class Program
{
    //features that are expected to be in program
    //master loop----
    //unit test
    //inheritance from parent classes---
    //conversion tool

    static void Main(string[] args)
    {
        RunProgram();
    }
    static public void RunProgram()
    {
        TimeClock timeClock = new TimeClock();
        TimeOff timeOff = new TimeOff();
        Account account = new Account();
        Console.WriteLine("1 = Clock-in or Clock-out");
        Console.WriteLine("2 = Request Time Off");
        Console.WriteLine("3 = Edit Account Information");
        Console.WriteLine("4 = Exit Time Management System");
        var answer = Console.ReadLine();
        //master loop
        while (true)
        {
            switch (answer)
            {
                case "1":
                    timeClock.ClockInOrOut();
                    break;
                case "2":
                    timeOff.TimeOffSubMenu();
                    break;
                case "3":
                    account.AccountSubMenu();
                    break;
                case "4":
                    return;
            }
            Console.WriteLine("Would you like to do something else: ");
            Console.WriteLine("1 = Clock-in or Clock-out");
            Console.WriteLine("2 = Request Time Off");
            Console.WriteLine("3 = Edit Account Information");
            Console.WriteLine("4 = Exit Time Management System");
            answer = Console.ReadLine();
        }
    }
}
