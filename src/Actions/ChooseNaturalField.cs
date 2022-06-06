using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, ISeedProducing plant)
        {
            Utils.Clear();

            
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                if(farm.NaturalFields[i].GetCurrentRowCount() < farm.NaturalFields[i].Capacity)
                {
                    Console.WriteLine($"{i + 1}. Natural Field");
                }
            }
            

            Console.WriteLine();

            // How can I output the type of plant chosen here?
            Console.WriteLine($"Place the seeds where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Plant seeds succesfully added to Natural Field ({choice})");
            Console.Write("Press enter to return to the main menu");
            Console.ReadLine();

            farm.NaturalFields[choice-1].AddResource(plant);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<INatural>(animal, choice);

        }
    }
}