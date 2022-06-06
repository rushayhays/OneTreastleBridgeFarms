using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IEggLaying, IFeatherProducing, IFeedEating
    {
        private Guid _id = Guid.NewGuid();
        private double _feathersProduced = 0.75;
        private double _eggsProduced = 6;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double FeedPerDay { get; set; } = 0.8;
        public string Type { get; } = "Duck";

        //Methods
        public void Feed()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public double CollectEggs()
        {
            return _eggsProduced;
        }
        public double CollectFeathers()
        {
            return _feathersProduced;
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack Quack!";
        }
    }

}