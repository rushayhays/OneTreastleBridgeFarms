using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 2;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IGrazing animal)
        {
            // TODO: implement this...
            Console.WriteLine(animal);
            if (Capacity > _animals.Count)
            {
                this._animals.Add(animal);
            }
            else
            {
                Console.WriteLine("This facility is full. Please select another facility.");
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Press return key to go back to main menu.");
                Console.ReadLine();
            }
        }

        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            //this._animals.AddRange(animals);
            Console.WriteLine("Have to add a list of animals");
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}