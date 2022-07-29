namespace James_Time_Management_System.ParentClasses
{
    public class Time
    {
        //inheritance
        public float vacationHours { get; set; }
        public float sickHours { get; set; }
        public float emergencyHours { get; set; }
        public DateTime PTORenewal { get; set; }
        public DateTime EmployeeJobStartDate { get; set; } = new DateTime(2022,7,28);
        public float employeeHours { get; set; }
        public float employeePoints { get; set; }
        public DateTime DisplayPTORenewalDate()
        {
            PTORenewal = EmployeeJobStartDate.AddYears(1);
            Console.WriteLine($"Your PTO renewal date is: {PTORenewal}");
            return PTORenewal;
        }
    }
}
