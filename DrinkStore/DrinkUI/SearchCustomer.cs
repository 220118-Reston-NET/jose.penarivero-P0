using DrinkModel;

namespace DrinkUI

{


    public class SearchCustomer : IUserMenu
    {
        private static Customer _searchName = new Customer();
        
         

        public void Display()
        {
             Console.WriteLine("Search customer info");
            Console.WriteLine("[4]Name - " + _searchName.Name);
            Console.WriteLine("[3]Adress - "+_searchName.Address);
            Console.WriteLine("[2]Phone - "+_searchName.Phone);
            Console.WriteLine("[1]Save");
            Console.WriteLine("[0]Go back");
            
        }

        public string UserChoice()
        {

            string UserInput = Console.ReadLine();
            
            switch(UserInput)
            {
     case "0":
          return "MainMenu";
     case "1":
           return "Save";
     case "2":
      
           return "Searchcustomer";
     case "3":
         return "Searchcustomer";
           case "7":
           return "Searchcustomer";
     default:
              Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
        }
    }
}
}