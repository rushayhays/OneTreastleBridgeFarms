using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Processors
{
    public class MeatProcessor: IProcessor
    {
        
        public Dictionary<IResource, double> ProcessedResourcesDict = new Dictionary<IResource, double>(){};

        public void Process(IMeatProducing animal, int animalNum)
        {
            double totalMeat = 0;
            for(int x = 0; x < animalNum; x++)
            {
                totalMeat += animal.Butcher();
            }
            

        }
    }
}


