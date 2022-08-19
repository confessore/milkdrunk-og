using milkdrunk.models.abstractions;
using milkdrunk.models.interfaces;
using System.Collections.Generic;

namespace milkdrunk.models
{
    public class Caregroup : Entity<string>, IEntity<string>
    {
        public virtual string? OwnerId { get; set; }
        public virtual ICollection<string>? MemberIds { get; set; }
    }
}
