using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<ISeedProducing>
    {

        private List<List<ISeedProducing>> _allRows = new List<List<ISeedProducing>>();
        private double _totalrows = 10;
        private int _plantsPerRow = 6;
        private Guid _id = Guid.NewGuid();



        public double Capacity {
            get {
                return _totalrows;
            }
        }
        public double GetCurrentRowCount()
        {
            double rowCount = _allRows.Count;
            return rowCount;
        }
        public string GetPlants()
        {
            var values = _allRows.SelectMany(i => i)
                .GroupBy(i => i.Type)
                .Select(group => new {
                    Type = group.Key,
                    Count = group.Count()});

            return String.Join(", ", values.Select(kvp => kvp.Count + " " + kvp.Type));
        }

        public void AddResource (ISeedProducing plant)
        {
            List<ISeedProducing> singleRow = new List<ISeedProducing>
            {
                plant, plant, plant, plant, plant, plant
            };
            _allRows.Add(singleRow);
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

            output.Append($"Natural field {shortId} has {this._allRows.Count} rows of plants\n");
            this._allRows.ForEach(r => r.ForEach(p => output.Append($"   {p}\n")));

            return output.ToString();
        }
    }
}