using milkdrunk.models.abstractions;
using System;

namespace milkdrunk.models
{
    public class Sleeping : Entity<string>
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
