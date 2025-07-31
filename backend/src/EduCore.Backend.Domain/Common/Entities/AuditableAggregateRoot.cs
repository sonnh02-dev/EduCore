using System;
using System.ComponentModel.DataAnnotations;

namespace EduCore.BackEnd.Domain.Common.Entities
{
    public abstract class AuditableAggregateRoot<TEntity> : AggregateRoot<TEntity>
    {
        protected AuditableAggregateRoot() : base() { }

        protected AuditableAggregateRoot(Id<TEntity> id) : base(id) { }

        public int CreatorId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int? ModifierId { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public int? DeleterId { get; set; }
        public DateTime? DeletedAt { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; } = new byte[] { 0 };
    }
}
