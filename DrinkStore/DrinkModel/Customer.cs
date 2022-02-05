
namespace DrinkModel
{

    public class Customer
    {
        
       public string CustomerId { get; set; }
        public string Name { get; set; }
         public string Address { get; set; }
         public string Phone { get; set; }
         public string Email { get; set; }
         public string ListOfOrders { get; set; }
         

        //  private int Quantity { get; set; }
        // public int _quantity
        // {

        //     get
        //     {return _quantity ;}
        //     set
        //     {

        //         if(value > 1)
        //         {
        //           _quantity = value;
        //         }
        //         else
        //         {
        //             throw new Exception("Quantity cannot be 0");
        //         }
        //     }
        // }
   


        //Default constructor to add default values to the properties
        public Customer()

        {
            CustomerId = "";
            Name = " jose";
            Address = "22sdsd";
            Phone ="5678";
            Email = "34345353";
            ListOfOrders= "678900";
            // _inventory = new List<Inventory>()
            // {
            //      new Inventory()
            //  };
    }
    


     
//ToString() method is the string version of your object
        public override string ToString()
        {
            return $"Name: {Name}\nLevel: {Address}\nAttack: {Phone}\nDefense: {Email}\nHealth: {ListOfOrders}";
        }
     
    }
}