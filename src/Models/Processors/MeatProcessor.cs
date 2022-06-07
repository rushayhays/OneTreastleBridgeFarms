using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Processors
{
    public class MeatProcessor: IProcessor
    {
        
    
        public Dictionary<string, int> ResourceDict = new Dictionary<string, int>(){};

        public void AddToResourceDict(IMeatProducing meatType, int animalNum)
        {
            //Does it pass in an animal object or just the name of the type?
            double totalMeat = 0;
            for(int x = 0; x < animalNum; x++)
            {
                totalMeat += meatType.Butcher();
            }

        }
    }
}

