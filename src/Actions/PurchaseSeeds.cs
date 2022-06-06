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
                Console.WriteLine(@"Sunflowers can be planeted in Natural Fields and in Plowed fields where would you like to plant these?
                                    1. Natural Field
                                    2. Plowed Field");
                    string fieldChoice = Console.ReadLine ();
                    if(Int32.Parse(fieldChoice) ==1){
                        ChooseNaturalField.CollectInput(farm, new Sunflower());
                    }else{
                         ChoosePlowedField.CollectInput(farm, new Sunflower());
                    }
                    
                    break;
                case 3:
                    ChooseNaturalField.CollectInput(farm, new Wildflower());
                    break;
                default:
                    break;
            }
        }
    }
}