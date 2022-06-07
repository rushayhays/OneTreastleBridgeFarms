using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : ISeedProducing
    {
        private int _seedsProduced = 40;
        public string Type { get; } = "Sunflower";

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sunflower. Beautiful!";
        }
    }
}