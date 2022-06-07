using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Processors
{
    public class FeatherHarvester : IProcessor<IFeatherProducing>
    {
        public static List<IFeatherProducing> ProcessedResources = new List<IFeatherProducing>();

        static void Process(IFeatherProducing animal, int numOfAnimals)
        {
            for (int i = 0; i < numOfAnimals; i++)
            {
                ProcessedResources.Add(animal);
            }
        }

        static void Report()
        {
            
        }
    }
}