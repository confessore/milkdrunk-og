using milkdrunk.models.interfaces;
using System;

namespace milkdrunk.models.abstractions
{
    public abstract class Entity<T> : IEntity<T>
        where T : IEquatable<T>
    {
        public T? Id { get; set; }
    }
}
