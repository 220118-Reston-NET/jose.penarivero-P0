using DrinkModel;
using System.Collections.Generic;


namespace DrinkModel
{

  public class LineItems
  {





   public string Soda1 { get; set; }
   public string Soda2 { get; set; }
   public string Soda3 { get; set; }
   public string Soda4 { get; set; }
   public string Wine1 { get; set; }
   public string Wine2 { get; set; }
   public string Wine3 { get; set; }
   public string Wine4 { get; set; }

   public string whysky1 { get; set; }
   public string whysky2 { get; set; }
   public string whysky3 { get; set; }
   public string whysky4 { get; set; }
  public int Quantity { get; set; }

  

        public LineItems()
        {{
            //Sodas availables
            Quantity =0;
            Soda1= "Coke ";
            Soda2= "Diet Coke ";
            Soda3= "Pepsi ";
            Soda4 = "Diet Pepsi ";
            //Wines
            Wine1 =  "Sauvignon Blanc ";
            Wine2 =  "Cabernet ";
            Wine3 =  "Pinot Gris ";
            Wine4  = "Chadoney ";
            // Whiskies
            whysky1 = "Jim Beam ";
            whysky2 = "Knob Creek ";
            whysky3 = "Old Crow ";
            whysky4 = "asil Hayden's ";

        }}




    }
}