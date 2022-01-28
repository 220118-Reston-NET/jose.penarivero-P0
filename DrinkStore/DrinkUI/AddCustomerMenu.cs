using DrinkModel;

namespace DrinkUI
{

    public class AddCustomerMenu : IUserMenu
    {
        private static Customer _newCustomer = new Customer();
        public void Display()
        {
             Console.WriteLine("Enter Customer information");
            Console.WriteLine("[4]Name - " + _newCustomer.Name);
            Console.WriteLine("[3]Adress - "+_newCustomer.Address);
            Console.WriteLine("[2]Phone - "+_newCustomer.Phone);
            Console.WriteLine("[1]Save");
            Console.WriteLine("[0]Go back");
            Console.WriteLine("Choose an option from above to be added or press 0 to go back.");
        }

        public string UserChoice()
        {
             string? UserInput = Console.ReadLine();

            switch(UserInput)
            {
     case "0":
          return "MainMenu";
     case "1":
           return "MainMenu";
     case "2":

     Console.WriteLine("Please enter your phone number");
     _newCustomer.Phone = Convert.ToDouble(Console.ReadLine());// Getting user input to set a value
           return "AddCustomer";
     case "3":
     Console.WriteLine("Please enter your address");
     _newCustomer.Address = Console.ReadLine();// Getting user input to set a value
          return "AddCustomer";
           case "4":
     Console.WriteLine("Please enter your name");
     _newCustomer.Name = Console.ReadLine();// Getting user input to set a value
         
          return "AddCustomer";
     default:
              Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
        }
    }
}
}