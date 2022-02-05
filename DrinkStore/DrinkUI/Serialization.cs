using System.Text.Json;
using DrinkModel;
using DrinkUI;


namespace SerializationFunc

{

public class Serialization 
{
 private static string _filepath = "./Database/Customer.json;";
  public static void SerialMain()
  {
    //==========Demo serialization=======================

    List<Customer> ListofCustomer = new List<Customer>();
   
      Customer cust = new Customer()
      {

            CustomerId = "",
            Name = " jose",
            Address = "Plantation",
            Phone ="5678",
            Email = "Burguer@hotmail.com",
            ListOfOrders= "None"
      };

      ListofCustomer.Add(cust);
      ListofCustomer.Add(cust);
      ListofCustomer.Add(cust);
    //========== Syntax to convert to Jason file Demo serialization=======================
      string jsonString = JsonSerializer.Serialize(ListofCustomer, new JsonSerializerOptions{WriteIndented  = true});
      

      Console.WriteLine(jsonString);
       File.WriteAllText(_filepath, jsonString);
        //========== Syntax to convert to Jason file to an object =======================
        string jsonString2 = File.ReadAllText(_filepath);

    List<Customer> cust2 =JsonSerializer.Deserialize<List<Customer>>(jsonString2);
        Console.WriteLine(cust2[0].CustomerId);
        Console.WriteLine(cust2[0].Name);
        Console.WriteLine(cust2[0].Address);
        Console.WriteLine(cust2[0].Phone);
        Console.WriteLine(cust2[0].Email);
        Console.WriteLine(cust2[0].ListOfOrders);



  }

}

}

