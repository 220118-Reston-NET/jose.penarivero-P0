namespace DrinkModel

{
    public class StoreFront
    {
public string StoreName  { get; set; }
public string phone  { get; set; }
public string StoreAddress  { get; set; }
public string StoreEmail { get; set; }
public string ListOfProducts { get; set; }
public string ListOfOrders { get; set; }
        public StoreFront()
 {
     StoreName = "Beverages Depot.";
     StoreAddress = "Miami florida";
     StoreEmail = "beveragesdepot@gmail.com";
     ListOfProducts= "";
     ListOfOrders = "";

 }   
 }
}

