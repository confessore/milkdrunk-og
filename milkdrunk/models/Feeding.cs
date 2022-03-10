using milkdrunk.models.enums;
using System;

namespace milkdrunk.models
{
    public class Feeding
    {
        public FeedingType FeedingType { get; set; }
        public DateTime Time { get; set; }
        public double FluidOunces { get; set; }
    }
}
