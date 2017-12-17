using System;
using System.Collections.Generic;

namespace Pandia
{
    public class Entity
    {
        public long Id { get; }

        private readonly Dictionary<Type, IComponent> _components;

        public Entity(long id)
        {
            Id = id;
            _components = new Dictionary<Type, IComponent>();
        }

        public bool AddComponent<T>(T component) where T:IComponent
        {
            return _components.TryAdd(typeof(T), component);
        }

        public bool RemoveComponent<T>() where T : IComponent
        {
            return _components.Remove(typeof(T));
        }
    }
}
