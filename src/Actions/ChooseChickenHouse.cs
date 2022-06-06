using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, Chicken chicken)
        {
            Utils.Clear();

            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House");
            }

            Console.WriteLine();
            Console.WriteLine("Place the chicken where?");
            Console.Write("> ");

            try
            {
                int choice = Int32.Parse(Console.ReadLine());
                farm.ChickenHouses[choice - 1].AddResource(chicken);
            }
            catch (HouseTooSmall)
            {
                Console.WriteLine("That house was too small, please put your chicken in a house with more room.");
                Console.ReadLine();
                ChooseChickenHouse.CollectInput(farm, new Chicken());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please enter a valid chicken house.");
                Console.ReadLine();
                ChooseChickenHouse.CollectInput(farm, new Chicken());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid chicken house.");
                Console.ReadLine();
                ChooseChickenHouse.CollectInput(farm, new Chicken());
            }
        }
    }
}