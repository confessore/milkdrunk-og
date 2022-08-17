using milkdrunk.models.abstractions;
using milkdrunk.models.interfaces;
using System.Collections.Generic;

namespace milkdrunk.models
{
    public class Caregiver : Entity<string>, IEntity<string>
    {
        public string? Name { get; set; }
        public string? ActiveBabyId { get; set; }
        public virtual ICollection<Baby?>? Babies { get; set; }
        public string? ActiveCaregroupId { get; set; }
        public virtual ICollection<Caregroup?>? Caregroups { get; set; }
    }
}
