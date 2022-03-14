using milkdrunk.models.abstractions;
using System.Collections.Generic;

namespace milkdrunk.models
{
    public class Caregiver : Entity<string>
    {
        public string? Name { get; set; }
        public virtual ICollection<Baby>? Babies { get; set; }
        public virtual ICollection<Caregroup>? Caregroups { get; set; }
    }
}
