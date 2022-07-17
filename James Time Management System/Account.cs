namespace James_Time_Management_System
{
    public class Account : ParentClasses.Employee
    {
        //Question: how to save values to vairables that are inherited 

        //eventually may have a username and password
        public void AccountMenu()
        {
            Console.WriteLine("1: View current account info");
            Console.WriteLine("2: Edit account info");
            string accountMenuAnswer = Console.ReadLine();
            switch (accountMenuAnswer)
            {
                case "1":
                    ViewAccountInfo();
                    break;
                case "2":
                    EditEmailAddress();
                    EditName();
                    break;
            }
        }
        public void ViewAccountInfo()
        {
            Console.Write("Email: ");
            Console.WriteLine(emailAddress);
            Console.Write("Fullname: ");
            Console.WriteLine(firstName + " " + lastName);
        }
        public string EditName()
        {
            Console.WriteLine("Enter new first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter new last name: ");
            lastName = Console.ReadLine();
            return firstName + " " + lastName;
        }
        public string EditEmailAddress()
        {
            Console.WriteLine("Enter new email address: ");
            emailAddress = Console.ReadLine();
            return emailAddress;
        }
    }
}
