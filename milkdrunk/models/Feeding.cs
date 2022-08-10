using milkdrunk.models.abstractions;
using milkdrunk.models.enums;
using System;

namespace milkdrunk.models
{
    public class Feeding : Entity<string>
    {
        public FeedingType FeedingType { get; set; }
        public DateTime Time { get; set; }
        public double FluidOunces { get; set; }
    }
}
