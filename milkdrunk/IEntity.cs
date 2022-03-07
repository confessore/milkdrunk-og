using System;

namespace milkdrunk
{
    public interface IEntity<T>
        where T : IEquatable<T>
    {
        T? Id { get; set; }
    }
}
