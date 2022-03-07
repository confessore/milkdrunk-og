using System;

namespace milkdrunk
{
    public abstract class Entity<T> : IEntity<T>
        where T : IEquatable<T>
    {
        public T? Id { get; set; }
    }
}
