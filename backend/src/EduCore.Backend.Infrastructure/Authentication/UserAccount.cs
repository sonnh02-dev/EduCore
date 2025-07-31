using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace EduCore.BackEnd.Infrastructure.Authentication
{
    public partial class UserAccount:IdentityUser<int>
    {
        public bool? IsActive { get; set; }
        public virtual UserProfile UserProfile { get; set; } = null!;
    }
}
