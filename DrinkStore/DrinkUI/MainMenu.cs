using DrinkModel;

namespace   DrinkUI
{

    public class MainMenu : IUserMenu
    {

        
        
        public void Display()
        {
            Console.WriteLine(" Welcome to Drinks Depot Store. Please enter your information to customize your order");
            Console.WriteLine(" ===========================================================================================================\n");
            Console.WriteLine("[1] Register customers loggin\n");
            Console.WriteLine("[2] New customers, please press [2] to sign up!");

            Console.WriteLine("  Press [3] for store information!");
            Console.WriteLine("  Press [4] for Products");
            Console.WriteLine("  Press [5] for Line of drinks");
            Console.WriteLine("  Press [6] order");
            Console.WriteLine("  Press [7] Search customer!");
            Console.WriteLine("  Press [0] to Exit");

           //Console.WriteLine("[3]Available beverages");
            
             //Console.WriteLine("Press [1] to enter customer information to customize your order!.");
           

        }

        public string UserChoice()
        {

            string? userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "custlog";
                case "2":
                    return "AddCustomer";
                case "3":
                    return "AddStore1";
                case "4":
                    return "Drinkpro";

                    case "5":
                    return "Drinktp5";
                    case "6":
                    return "Ordering";
                    
                    case "7":
                    return "Drinktp";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }


}
//