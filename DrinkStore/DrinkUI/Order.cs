namespace DrinkUI
{


    public class Order : IUserMenu


    {
       public void Display()
        {
            Console.WriteLine(" Please choose item to make your order\n");

           //Console.WriteLine("[3]Available beverages");
            Console.WriteLine("    Order: ");
            Console.WriteLine("    Store location : ");
            Console.WriteLine("    List Line Items: ");
            Console.WriteLine("    Total price: \n");
            Console.WriteLine("[1] Go back");

        }

        public string UserChoice()
        {
            string UserInput = Console.ReadLine();

             switch(UserInput)
            {
     case "0":
          return "Ordering";
     case "1":
            return "Go back";
    case "6":
              
        return "Ordering";
     case "3": 

              default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
    }
}
}