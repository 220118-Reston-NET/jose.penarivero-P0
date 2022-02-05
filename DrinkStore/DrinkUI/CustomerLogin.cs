using DrinkModel;

namespace DrinkUI
{
    public class CustomerLogin : IUserMenu
    {
        
         private  static  CustSigning  _newlogin = new  CustSigning();
      
        public void Display()
        {
             Console.WriteLine(" Customer Login in!");
            Console.WriteLine("\n[3] Enter userID: "+ _newlogin.UserId);
            Console.WriteLine("[2] Enter password: "+_newlogin.Password);
         
            //Console.WriteLine("[1] Save");
            Console.WriteLine("[1] Go back");
            Console.WriteLine("Choose an option from above to be added or press 0 to go back.");
        }

        public string UserChoice()
        {
             string UserInput = Console.ReadLine();

            switch(UserInput)
            {
     case "1":
          return "Go back";
     case "2":
      _newlogin.Password = Console.ReadLine();                                             //_customerBL.AddCustomer(_newCustomer);
           return "custlog";
      case "3":
      _newlogin.UserId = Console.ReadLine();

          return "custlog";         
          default:
              Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
        }
    }
}
}