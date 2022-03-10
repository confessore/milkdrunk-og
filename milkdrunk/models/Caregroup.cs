﻿using milkdrunk.models.abstractions;
using System.Collections.Generic;

namespace milkdrunk.models
{
    public class Caregroup : Entity<string>
    {
        public string? Name { get; set; }
        public virtual ICollection<Caregiver>? Caregivers { get; set; }
        public virtual ICollection<Baby>? Babies { get; set; }
    }
}
