namespace DrinkModel

{
public class Customer
{

//customer properties
public string Name { get; set; }
public string Address  { get; private set; }
public long Phone { get; private set; }

private List<Inventory> _inventory;
public List<Inventory> Inventory
{

get { return _inventory; }
set 
{
 if (value.Count < 2)
                {
                    _inventory = value;
                }
                else
                {
                    throw new Exception("Store cannot hold more than 4 items!");
                }
            }

        }
        

        //Default constructor to add default values to the properties
        public Customer()
        {
            Name = "jose";
            Address = "Fort Lauderdale";
            Phone = 7864268393;
            _inventory = new List<Inventory>()
            {
                new Inventory()
            };

}
}

}


