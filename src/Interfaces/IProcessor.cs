using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Interfaces
{
    public interface IProcessor<T>
    {
        static List<IResource> ProcessedResources;
        static void Process(T resource, int resourcenum)
        {}

        static void Report()
        {}
    }
}
