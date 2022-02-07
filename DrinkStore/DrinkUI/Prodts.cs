namespace DrinkUI
{

    public class prodts : IUserMenu
    {
        //static variable -non access modifier need to to classes
        // private static Products p_product = new Products();
       //Dependency Injection
     //    //==========================
     //    private ICustomerBL _customerBL;
     //    public AddCustomerMenu(ICustomerBL c_customerBL)
     //    {
     //        _customerBL = c_customerBL;
     //    }
        //==========================
        public void Display()
        {
             Console.WriteLine("Products: ");
            Console.WriteLine("\na) Sodas:" );
            Console.WriteLine("b) Wines:" );
            Console.WriteLine("c) Bourbons:\n" );
             
             
            Console.WriteLine("[1]Back to menu.");
          
        }

        public string UserChoice()
        {
             string UserInput = Console.ReadLine();

            switch(UserInput)
            {
     case "0":
          return "MainMenu";
     case "1":                                                   //_customerBL.AddCustomer(_newCustomer);
           return "Go back";
     case "2":     
          return "AddCustomer";
    case "3":   
          return "Drinkpro";
     case "4":    
          return "Drinkpro";
     case "5":      
         return "MainMenu";
     default:
              Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
        }
    }
}
}