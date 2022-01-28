

namespace DrinkModel
{
public class Inventory 
{

 public string Product1 { get; set; }
public string Product2 { get; set; }
public string Product3 { get; set; }
public string Product4 { get; set; }
public string Product5 { get; set; }

        //Full property is needed to add validation
        private int _quantity;
   

    public int Quantity
        {
            get { return _quantity; }
            //You can only set PP above 0
            set 
            {
                if (value > 4)
                {
                    _quantity = value; 
                }
                else
                {
                    throw new Exception("You cannot have a Zero value ");
                }
            }
        }
        

        public Inventory()
        {
           Product1 = "Bears";
           Product2 = "Sodas";
           Product3 = "Sparkling waters";
           Product4 = "Juices";
           Product5 = "Bourbons";
           Quantity = 40;
            
        }
}

}
