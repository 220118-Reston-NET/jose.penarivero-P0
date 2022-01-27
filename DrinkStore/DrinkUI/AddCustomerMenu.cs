using DrinkModel;

namespace DrinkUI
{

    public class AddCustomerMenu : IUserMenu
    {
        private Customer _newCustomer = new Customer();
        public void Display()
        {
             Console.WriteLine("Enter Customer information");
            Console.WriteLine("[4]Name - " + _newCustomer.Name);
            Console.WriteLine("[3]Adress - "+_newCustomer.Address);
            Console.WriteLine("[2]Phone - "+_newCustomer.Phone);
            Console.WriteLine("[1]Save");
            Console.WriteLine("[0]Go back");
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
           return "AddCustomer";
     case "3":
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