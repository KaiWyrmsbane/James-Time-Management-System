using James_Time_Management_System.ParentClasses;

namespace James_Time_Management_System
{
    public class Account: Employee
    {
        public string fullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
