using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class PlowedField : IFacility<ISeedProducing>
    {
        private List<ISeedProducing> _rows = new List<ISeedProducing>();
        private double _totalrows = 13;
        private int _plantsPerRow = 5;
        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _plants = new List<ISeedProducing>();

        public double Capacity {
            get {
                return _totalrows;
            }
        }

        public void AddResource (ISeedProducing plant)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource (List<ISeedProducing> rowOfPlants) 
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._rows.Count} rows of plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}