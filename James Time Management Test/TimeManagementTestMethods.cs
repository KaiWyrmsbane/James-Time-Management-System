using James_Time_Management_System;

namespace James_Time_Management_Test
{
    public class TimeManagementTestMethods
    {
        //Three unit tests
        [Fact]
        public void TimeClockHoursWorkedTest()
        {
            //arrange
            TimeClock timeClock = new TimeClock();
            TimeSpan expected = new TimeSpan(8,0,0);
            DateTime startTime = new DateTime(2022,12,17,6,0,0);
            DateTime endTime = new DateTime(2022,12,17,14,0,0);
            //act
            TimeSpan actual = timeClock.HoursWorked(startTime,endTime);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TimeOffMoreThanADayOffTest()
        {
            //arrange
            TimeOff timeOff = new TimeOff();
            TimeSpan expected = TimeSpan.FromDays(5);
            DateTime startDate = DateTime.Parse("08/17/2022");
            DateTime endDate = DateTime.Parse("08/22/2022");
            //act
            TimeSpan actual = timeOff.MoreThanADayOff(startDate, endDate, 8.0f);
            //assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void AccountDisplayAccountInfoTest()
        {
            //arrange
            Account account = new Account();
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