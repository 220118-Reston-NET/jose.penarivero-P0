
// See https://aka.ms/new-console-template for more information
// using DrinkBL;
using DrinkModel;
using DrinkUI;
// using SerializationFunc;
// Serialization.SerialMain();

// //Customer ab = new Customer();
// ab._quantity = 2;
bool repeating =true;
IUserMenu menu = new MainMenu();
while(repeating)
{
Console.Clear();
menu.Display();

 string answer = menu.UserChoice();

 switch(answer)
{     
           case  "custlog":
              menu =  new CustomerLogin();
              break;

             case  "Drinktp5":
              menu =  new LineOfDrinkTypes();
              break;

            case  "AddCustomer":
              menu = new AddCustomerMenu();
              break;

              case  "Ordering":
              menu = new Order();
              break;
               case  "AddStore1":
             menu = new StoreSelect();
             break;

             case  " Drinktp":
             menu = new LineOfDrinkTypes();
             break;


             case  "Go back":
              menu =  new MainMenu();
              break;

             case  "Drinkpro":
              menu =  new Prodts();
              break;

              case "Back to menu":
              menu = new Order();
              break;

             case "Exit":
              repeating = false;
              break;
              default:
              Console.WriteLine(" Page does not exist");
              break;


}

}






// using DrinkUI;

// Console.WriteLine("Hello, World!");
// // Customer ab = new Customer();
// // ab._quantity = 2;
// bool repeating =true;
// IUserMenu menu = new MainMenu();

// while(repeating)
// {
// Console.Clear();

// menu.Display();
 
//  string answer = menu.UserChoice();

//  switch(answer)
// {

    
// case  "MainMenu":
//   menu = new MainMenu();
//   break;
   
//   case "DrinkList":
//   menu = new DrinkList();
//   break;
  
//    case "SearchCustomer":
//     menu = new SearchCustomer();
//     break;
//   case "AddCustomer":
//     menu = new AddCustomerMenu();
//     break;
    
//   case "Exit":
//   repeating = false;
//   break;
//   default:
//   Console.WriteLine(" Page does not exist");
//   break;


// }
// }0