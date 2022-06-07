using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Interfaces
{
    public interface Processor
    {
        
    
        Dictionary<IResource, double> ResourceDict{get; set;}

        void Process();
    }
}
