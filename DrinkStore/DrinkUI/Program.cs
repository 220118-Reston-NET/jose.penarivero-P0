// See https://aka.ms/new-console-template for more information
 //using DrinkModel;
 using DrinkUI;
// Console.WriteLine("Hello, World!");
// Inventory ab = new Inventory();
// ab.DrinkType =  1;
bool repeating =true;
IUserMenu menu = new MainMenu();

while(repeating)
{
Console.Clear();

menu.Display();
 
 string answer = menu.UserChoice();

 switch(answer)
{

    case "AddCustomer":
    menu = new AddCustomerMenu();
    break;

    case "SearchCustomer":
    menu = new SearchCustomer();
    break;
  case "MainMenu":
  menu = new MainMenu();
  break;
  case "Exit":
  repeating = false;
  break;
  default:
  Console.WriteLine(" Page does not exist");
  break;


}
}