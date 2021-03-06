﻿namespace Successful.Core.Domain.Entities
{
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}
