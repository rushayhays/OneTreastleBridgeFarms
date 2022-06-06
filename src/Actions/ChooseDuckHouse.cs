using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, Duck duck)
        {
            Utils.Clear();

            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Duck House");
            }

            Console.WriteLine();
            Console.WriteLine("Place the Duck where?");
            Console.Write("> ");

            try
            {
                int choice = Int32.Parse(Console.ReadLine());
                farm.DuckHouses[choice - 1].AddResource(duck);
            }
            catch (HouseTooSmall)
            {
                Console.WriteLine("That house was too small, please house your duck in a duck house with more room.");
                Console.ReadLine();
                ChooseDuckHouse.CollectInput(farm, new Duck());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please enter a valid duck house.");
                Console.ReadLine();
                ChooseDuckHouse.CollectInput(farm, new Duck());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid duck house.");
                Console.ReadLine();
                ChooseDuckHouse.CollectInput(farm, new Duck());
            }
        }
    }
}