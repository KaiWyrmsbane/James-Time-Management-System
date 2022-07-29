using James_Time_Management_System;

namespace James_Time_Management_Test
{
    public class TimeManagementTestMethods
    {
        TimeOff timeOff = new TimeOff();
        TimeClock timeClock = new TimeClock();
        Account account = new Account();
        //Three unit tests
        //TimeClock
        [Fact]
        public void TimeClockHoursWorkedTest()
        {
            //arrange
            TimeSpan expected = new TimeSpan(8,0,0);
            DateTime startTime = new DateTime(2022,12,17,6,0,0);
            DateTime endTime = new DateTime(2022,12,17,14,0,0);
            //act
            TimeSpan actual = timeClock.HoursWorked(startTime,endTime);
            //assert
            Assert.Equal(expected, actual);
        }
        //TimeOff
        [Fact]
        public void TimeOffMoreThanADayOffTest()
        {
            //arrange
            TimeSpan expected = TimeSpan.FromDays(5);
            DateTime startDate = DateTime.Parse("08/17/2022");
            DateTime endDate = DateTime.Parse("08/22/2022");
            //act
            TimeSpan actual = timeOff.MoreThanADayOff(startDate, endDate, 8.0f);
            //assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void TimeOffHourToPointConversionTest()
        {
            //arrange
            float expected = 1.0f;
            float employeeHours = 8.0f;
            //act
            float actual = timeOff.HourToPointConversion(employeeHours);
            //assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void TimeOffPointToHourConversion()
        {
            //arrange
            float expected = 8.0f;
            float employeePoints = 1.0f;
            //act
            float actual = timeOff.PointToHourConversion(employeePoints);
            //assert
            Assert.Equal(expected,actual);
        }
        //Account
        [Fact]
        public void AccountDisplayAccountInfoTest()
        {
            //arrange
            string expected = $"Fullname is James VanMeter, emailaddress is jamesvanmeter1219@gmail.com";
            string fullName = "James VanMeter";
            string emailAddress = "jamesvanmeter1219@gmail.com";
            //act
            string actual = account.DisplayAccountInfo(fullName, emailAddress);
            //assert
            Assert.Equal(expected,actual);
        }
    }
}