
using DrinkkBL;

using DrinkModel;


namespace DrinkUI
{

public class AddCustomerMenu : IUserMenu
{
       //static variable -non access modifier need to to classes
        
         private static Customer _newCustomer = new Customer();
       //Dependency Injection
     //==========================
       private IDrinkBL _customerBL;
       public AddCustomerMenu(IDrinkBL c_customerBL)
        {
           _customerBL = c_customerBL;
        }
        //==========================
        public void Display()
        {
             Console.WriteLine("New customer registration:");
            Console.WriteLine("\n[5]Pressto enter your Name: " + _newCustomer.Name);
            Console.WriteLine("[4]press  to enter your Address: "+_newCustomer.Address);
            Console.WriteLine("[3]Press  to enter your Phone :"+_newCustomer.Phone);
            Console.WriteLine("[2]Press to enter your Email - "+_newCustomer.Email);
            Console.WriteLine("[1]Save");
            Console.WriteLine("[0]Go back");
            Console.WriteLine("Choose an option from above to be added or press 0 to go back.");
        }
        public string UserChoice()
        
        {
             string UserInput = Console.ReadLine();

            switch(UserInput)
            {
     case "0":
          return "Go back";
     case "1":     
     _customerBL.AddCustomer(_newCustomer);                                             //_customerBL.AddCustomer(_newCustomer);
           return "MainMenu";
      case "2":
     Console.WriteLine("Enter your email account");
     _newCustomer.Email += Console.ReadLine();// Getting user input to set a value
          return "AddCustomer";
           case "3":
     Console.WriteLine("Enter your phone number");
     _newCustomer.Phone += Console.ReadLine();// Getting user input to set a value     
          return "AddCustomer";

           case "4":
     Console.WriteLine("Enter your address");
     _newCustomer.Address = Console.ReadLine();// Getting user input to set a value     
          return "AddCustomer";

           case "5":
     Console.WriteLine("Enter your name");
     _newCustomer.Name = Console.ReadLine();// Getting user input to set a value 
     
          return "AddCustomer2";
     default:
              Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
        }
    }
}
}