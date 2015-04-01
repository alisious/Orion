using System;

namespace Orion.Domain
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
