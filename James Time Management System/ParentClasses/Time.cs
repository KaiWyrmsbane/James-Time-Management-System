namespace James_Time_Management_System.ParentClasses
{
    public class Time
    {
        //inheritance
        public float vacationHours { get; set; } = 112.0f;
        public float sickHours { get; set; } = 56.0f;
        public float emergencyHours { get; set; } = 24.0f;
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
        public void DisplayPTOTime()
        {
            Console.WriteLine("PTO time left");
            Console.WriteLine($"Vacation: {vacationHours} hours");
            Console.WriteLine($"Sick: {sickHours} hours");
            Console.WriteLine($"Emergency: {emergencyHours} hours");
        }
    }
}
