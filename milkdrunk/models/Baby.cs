using milkdrunk.models.abstractions;
using System;
using System.Collections.Generic;

namespace milkdrunk.models
{
    public class Baby : Entity<string>
    {
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Changing>? Changings { get; set; }
        public virtual ICollection<Feeding>? Feedings { get; set; }
        public virtual ICollection<Sleeping>? Sleepings { get; set; }
    }
}
