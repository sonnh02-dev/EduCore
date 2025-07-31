using EduCore.BackEnd.Domain.Common.DomainEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Common.Entities
{
    public abstract class AggregateRoot<TEntity> : Entity<TEntity>
    {
        private readonly List<IDomainEvent> _domainEvents = new();

        protected AggregateRoot(Id<TEntity> id) : base(id)
        {
        }

        protected AggregateRoot()
        {
        }

        public IReadOnlyCollection<IDomainEvent> DomainEvents() => _domainEvents.ToList();

        public void ClearDomainEvents() => _domainEvents.Clear();

        protected void RaiseDomainEvent(IDomainEvent domainEvent) =>
            _domainEvents.Add(domainEvent);
    }
}
