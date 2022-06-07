using System;
using System.Linq;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Grazing Field" + (farm.GrazingFields[i].GetAnimals().Count >= farm.GrazingFields[i].Capacity ? " <-- not a valid choice" : ""));
                Console.WriteLine($"Total Animals: " + farm.GrazingFields[i].GetAnimals().Count);

                var query = from r in farm.GrazingFields[i].GetAnimals()
                            group r by r.GetType() into g
                            select new { Count = g.Count(), Value = g.Key };

                foreach (var v in query)
                {
                    Console.WriteLine($"Value = {v.Value}, Count = {v.Count}");
                }

            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.GrazingFields[choice - 1].AddResource(animal);
            Console.WriteLine("Animal added to the facility");

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}