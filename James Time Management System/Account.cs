namespace James_Time_Management_System
{
    public class Account : ParentClasses.Employee
    {
        //we may want to do the same thing and save to a json file that way we save information
        public void AccountSubMenu()
        {
            Console.WriteLine("1: Change Name");
            Console.WriteLine("2: Change Email");
            Console.WriteLine("3: Display Account Information");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    ChangeFullName();
                    break;
                case "2":
                    ChangeEmail();
                    break;
                case "3":
                    DisplayAccountInfo(fullName,emailAddress);
                    break;
                default:
                    break;
            }
        }
        //we will create methods just for editing the firstName or the lastName
        public string ChangeFullName()
        {
            Console.Write("First name: ");
            firstName = Console.ReadLine();
            Console.Write("Last name: ");
            lastName = Console.ReadLine();
            fullName = $"{firstName} {lastName}";
            Console.WriteLine($"Your name is {firstName} {lastName}");
            return fullName;
        }
        public string ChangeEmail()
        {
            Console.Write("Email: ");
            emailAddress = Console.ReadLine();
            Console.WriteLine($"you new email is: {emailAddress}");
            return emailAddress;
        }
        public string DisplayAccountInfo(string fullName, string emailAddress)
        {
            Console.WriteLine(EmployeeId);
            Console.WriteLine(fullName);
            Console.WriteLine(emailAddress);
            return $"Fullname is {fullName}, emailaddress is {emailAddress}";
        }
    }
}
