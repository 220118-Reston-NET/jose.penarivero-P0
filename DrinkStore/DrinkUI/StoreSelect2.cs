// using DrinkBL;
using DrinkModel;
namespace DrinkUI

{

    public class StoreSelect2 : IUserMenu
    {
          
        private static StoreFront2 _Storeloc2 = new StoreFront2();
                public void Display()
        {
            Console.WriteLine(" Welcome to Drinks Store Locations\n");
          string a;
          
            Console.WriteLine("Orlando location information: "+_Storeloc2.StoreName2+"\n"+_Storeloc2.StoreAddress2+"\n"+_Storeloc2.phone+"\n"+_Storeloc2.StoreEmail2);
             //Console.WriteLine("Miami Location!. \n"+_Storeloc1.StoreName+"\n"+_Storeloc1.StoreAddress+"\n"+_Storeloc1.phone+_Storeloc1.StoreEmail);
              Console.WriteLine("[2]Save");
             Console.WriteLine("[1]Go back");
            
        }
             public string UserChoice()
        {
            string UserInput = Console.ReadLine();
            
            switch(UserInput)
            {
     case "0":
          return "MainMenu";

    case "1":
          return "MainMenu";
     
     case "2":
          return "Save";
     case "3":
    //  //_Storeloc1.StoreName = Console.ReadLine();
    //        return "AddStore1";

    //  case "4":  
    // //   _Storeloc2.StoreName2 = Console.ReadLine();
    //         return "AddStore2";
     default:
              Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
        }
        }
    }
}