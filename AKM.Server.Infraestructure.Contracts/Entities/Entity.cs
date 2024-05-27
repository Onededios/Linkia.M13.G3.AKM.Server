﻿using System.Text.Json.Serialization;

namespace AKM.Server.Infrastructure.Contracts.Entities
{
    public abstract class Entity
    {
        [JsonIgnore]
        public Guid id { get; set; }
        protected Entity() => id = Guid.NewGuid();
    }
}
