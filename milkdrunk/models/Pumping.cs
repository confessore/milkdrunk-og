using milkdrunk.models.abstractions;
using System;

namespace milkdrunk.models
{
    public class Pumping : Entity<string>
    {
        public DateTime Time { get; set; }
        public double FluidOunces { get; set; }
    }
}
