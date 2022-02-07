// See https://aka.ms/new-console-template for more information

using DrinkDL;
using DrinkkBL;
using DrinkUI;

Console.WriteLine("Hello, World!");
// using DrinkModel;
// using DrinkUI;
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
              menu = new AddCustomerMenu(new DrinkBL(new Repository()));
              break;

              case  "Ordering":
              menu = new Order();
              break;
               case  "AddStore1":
             menu = new StoreSelect();
             break;

             case  "Searchcustomer":
            menu = new SearchCustomer();
            break;

            


             case  "Go back":
              menu =  new MainMenu();
              break;

             case  "Drinkpro":
              menu =  new prodts();
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
