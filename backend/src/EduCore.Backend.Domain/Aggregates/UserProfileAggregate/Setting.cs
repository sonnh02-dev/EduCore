using EduCore.BackEnd.Domain.Common.Entities;
using System;
using System.Collections.Generic;

namespace EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate
{
    public partial class Setting : AggregateRoot<Setting>
    {
        public Id<Setting> UserProfileId { get; set; }
        public string Theme { get; set; } = null!;
        public string Language { get; set; } = null!;
        public bool NotificationsEnabled { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}
