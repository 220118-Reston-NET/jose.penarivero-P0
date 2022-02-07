using DrinkModel;

namespace DrinkUI
{

    public class LineOfDrinkTypes : IUserMenu
    {
        //private static LineItems _drinktype = new LineItems();
              public void Display()
        {
          Console.WriteLine("Line Items of Drinks information\n");
          //   Console.WriteLine("Soft drinks:\n   " +_drinktype.Soda1+"\n   "+_drinktype.Soda2+"\n   "+_drinktype.Soda3+"\n   "+_drinktype.Soda4+".");
          //   Console.WriteLine("------------------------------------------------------------------------------------------------------------\n");
          //   Console.WriteLine("Wines:\n   " +_drinktype.Wine1+"\n   "+_drinktype.Wine2+"\n   "+_drinktype.Wine3+"\n   "+_drinktype.Wine4+".");
          //  Console.WriteLine("------------------------------------------------------------------------------------------------------------\n");
          //   Console.WriteLine("Bourbons:\n   " +_drinktype.whysky1+"\n   "+_drinktype.whysky2+"\n   "+_drinktype.whysky3+"\n   "+_drinktype.whysky4+".");
            Console.WriteLine("\n   [1]Save");
            Console.WriteLine("\n   [0]Go back");

            
        }

        public string UserChoice()
        {
             string UserInput = Console.ReadLine();
           

            switch(UserInput)
            {
     case "0":
          return "Go back";
     case "1":
           return "MainMenu";
     case "2":
              
           return "AddCustomer";
     case "3": 
     
          // Console.WriteLine();
          return "Drinktp5";

     default:
              Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
        }

}
    }
}