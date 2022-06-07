using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Interfaces
{
    public interface IProcessor
    {
        
    
        Dictionary<IResource, double> ProcessedResourcesDict{get; set;}

        void Process();
    }
}
