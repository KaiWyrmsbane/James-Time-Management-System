using James_Time_Management_System;

namespace James_Time_Management_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TimeClockHoursWorkedTest()
        {
            //arrange
            var timeClock = new TimeClock();
            var expected = new TimeSpan(8,0,0);
            var startTime = new DateTime(2022,12,17,6,0,0);
            var endTime = new DateTime(2022,12,17,14,0,0);
            //act
            var actual = timeClock.HoursWorked(startTime,endTime);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}