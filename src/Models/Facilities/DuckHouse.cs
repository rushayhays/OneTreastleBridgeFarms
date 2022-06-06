using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Models.Animals;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<Duck>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<Duck> _animals = new List<Duck>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(Duck duck)
        {
            if (_animals.Count < Capacity)
            {
                _animals.Add(duck);
            }
            else
            {
                throw new HouseTooSmall();
            }
        }

        public void AddResource(List<Duck> ducks)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck house {shortId} has {this._animals.Count} ducks\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}