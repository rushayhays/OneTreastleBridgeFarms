using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;


namespace Trestlebridge.Actions {
    public class PurchaseSeeds {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Sesame");
            Console.WriteLine ("2. Sunflower");
            Console.WriteLine ("3. Wildflower");

            Console.WriteLine ();
            Console.WriteLine ("Choose seed to purchase.");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChoosePlowedField.CollectInput(farm, new Sesame());
                    break;
                case 2:
                    //Needs choice of Plowed field or Natural Field
                    //ChoosePlowedField.CollectInput(farm, new Sunflower());
                    break;
                case 3:
                    //Needs Choose Natural field
                    //ChoosePlowedField.CollectInput(farm, new Wildflower());
                    break;
                default:
                    break;
            }
        }
    }
}