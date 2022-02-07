using DrinkModel;

namespace DrinkUI
{




    public class StoreSelect : IUserMenu
    {
      private static StoreFront _Storeloc1 = new StoreFront();
       // private static StoreFront2 _Storeloc2 = new StoreFront2();
                public void Display()
        {
            Console.WriteLine("Store Information.\n");
          string a;
         
            //Console.WriteLine("Orlando location information: "+ a);
             Console.WriteLine("Miami Location!. \n"+_Storeloc1.StoreName+"\n"+_Storeloc1.StoreAddress+"\n"+_Storeloc1.phone+_Storeloc1.StoreEmail);
              Console.WriteLine("[2]Save");
             Console.WriteLine("[1]Go back");
            
        }
             public string UserChoice()
        {
            string UserInput = Console.ReadLine();
            
            switch(UserInput)
            {
    
    case "1":
          return "Go back";
     
     case "2":
      //_Storeloc1.StoreName = Console.ReadLine();
           return "AddStore1";
         
     case "3":
//     _Storeloc1.StoreName = Console.ReadLine();
//            return "AddStore1";

     case "4":  
     // _Storeloc2.StoreName2 = Console.ReadLine();
            return "AddStore2";
     default:
              Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMen";//
        }
        }
    }
}