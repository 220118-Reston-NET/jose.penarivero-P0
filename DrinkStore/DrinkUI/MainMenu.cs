namespace   DrinkUI
{

    public class MainMenu : IUserMenu
    {
        public void Display()
        {
            Console.WriteLine(" Welcome to Drinks Store\n");
            Console.WriteLine("[2]Search for customer");
             Console.WriteLine("[1]Add customer");
            Console.WriteLine("[0]Exit]");
           // string? v = Console.ReadLine();
            //Console.WriteLine("your name is: "+ v);
            //Console.WriteLine(" Please enter your phone number");
            //int phone = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your phone: "+ phone);
            //Console.WriteLine(" Please enter you address");
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
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }


}