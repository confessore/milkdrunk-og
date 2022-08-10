using System;

namespace milkdrunk.models.interfaces
{
    public interface IEntity<T>
        where T : IEquatable<T>
    {
        T? Id { get; set; }
        long? CreatedAt { get; set; }
    }
}
