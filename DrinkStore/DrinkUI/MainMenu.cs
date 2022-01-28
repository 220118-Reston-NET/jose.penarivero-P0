namespace   DrinkUI
{

    public class MainMenu : IUserMenu
    {
        public void Display()
        {
            Console.WriteLine(" Welcome to Drinks Store. Please choose an option below!\n");
           Console.WriteLine("[3]Available beverages");
            Console.WriteLine("[2]Search for customer");
             Console.WriteLine("[1]Add new customer");
            Console.WriteLine("[0]Exit");

        }

        public string UserChoice()
        {

            string? userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "AddCustomer";
                case "2":
                    return "SearchCustomer";
                case "3":
                    return "DrinkList";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }


}