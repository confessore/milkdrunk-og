using milkdrunk.models.abstractions;
using milkdrunk.models.enums;
using System;

namespace milkdrunk.models
{
    public class Changing : Entity<string>
    {
        public ChangingType ChangingType { get; set; }
        public DateTime Time { get; set; }
    }
}
