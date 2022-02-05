namespace DrinkModel

   
{

   public class Orders
   {


       public string StoreLocation { get; set; }
       public string ListLineItems{ get; set; }
       public double TotalPrice { get; set; }
   
      
                                   public Orders()
                                   {
                                          StoreLocation = "Miami Florida 33324";
                                          ListLineItems= "coke,pepsi, wines etc, Boubons!!!!!";
                                          TotalPrice = 0;

                                   }

}
}