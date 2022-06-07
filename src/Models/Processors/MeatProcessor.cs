using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Processors
{
    public class MeatProcessor: IProcessor<IMeatProducing>
    {
        
        public static List<IMeatProducing> ProcessedResources = new List<IMeatProducing>();

        static void Process(IMeatProducing animal, int animalNum)
        {
            for (int i = 0; i < animalNum; i++)
            {
                ProcessedResources.Add(animal);
            }
        }
        static void Report()
        {
            List<IMeatProducing> cows = new List<IMeatProducing>(){};
            List<IMeatProducing> pigs = new List<IMeatProducing>(){};
            List<IMeatProducing> chickens = new List<IMeatProducing>(){};
            List<IMeatProducing> sheep = new List<IMeatProducing>(){};
            List<IMeatProducing> ostriches = new List<IMeatProducing>(){};

            List<List<IMeatProducing>> sortedAnimalsDoubleList = new List<List<IMeatProducing>> (){
              cows,
              pigs,
              chickens,
              sheep,
              ostriches
            };
            foreach(IMeatProducing animal in ProcessedResources)
            {
                   if (animal.Type == "Cow")
                   {
                     sortedAnimalsDoubleList[0].Add(animal);
                   }
                    else if (animal.Type == "Pig")
                   {
                       sortedAnimalsDoubleList[1].Add(animal);
                   }
                    else if (animal.Type == "Chicken")
                   {
                       sortedAnimalsDoubleList[2].Add(animal);
                   }
                    else if (animal.Type == "Sheep")
                   {
                       sortedAnimalsDoubleList[3].Add(animal);
                   }
                    else if (animal.Type == "Ostrich")
                   {
                       sortedAnimalsDoubleList[4].Add(animal);
                   }
            }
            foreach(List<IMeatProducing> listOfAnimals in sortedAnimalsDoubleList)
            {
                if(listOfAnimals.Count > 0)
                {
                    string resourceMessage = $"You have {(listOfAnimals[0].Butcher())*listOfAnimals.Count}lbs of {listOfAnimals[0].Type} meat";
                    Console.WriteLine(resourceMessage);
                }
            }

        }
    
    }
}


