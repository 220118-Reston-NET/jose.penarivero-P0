using DrinkModel;

namespace DrinkUI
{


    public class DrinkList : IUserMenu
    {

        private static Inventory _drinktype = new Inventory();
        public void Display()
        {
             Console.WriteLine("Drink Type information");
            Console.WriteLine("[2]Beverages available: " +_drinktype.Product1+", "+_drinktype.Product2+", "+_drinktype.Product3+", "+_drinktype.Product4+", "+_drinktype.Product5+", ");
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
       
          return "Inventory";

     default:
              Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
        }
    }
}
}