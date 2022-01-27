namespace DrinkModel
{
public class Inventory
{

 public string Name { get; set; }

        //Full property is needed to add validation
        private int _drinkType;
   

    public int DrinkType
        {
            get { return _drinkType; }
            //You can only set PP above 0
            set 
            {
                if (value > 0)
                {
                    _drinkType = value; 
                }
                else
                {
                    throw new Exception("You cannot have a ");
                }
            }
        }
        

        public Inventory()
        {
            Name = "Tackle";
            DrinkType = 40;
            
        }
}

}
