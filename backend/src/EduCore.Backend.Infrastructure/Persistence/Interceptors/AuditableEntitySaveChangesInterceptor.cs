//using Microsoft.EntityFrameworkCore.Diagnostics;
//using Microsoft.EntityFrameworkCore;
//using EduCore.BackEnd.SharedKernel;

//namespace EduCore.BackEnd.Infrastructure.Persistence.Interceptors
//{
//    public class AuditableEntitySaveChangesInterceptor : SaveChangesInterceptor
//    {
//        private readonly ICurrentUserService currentUserService;
//        private readonly IDateTimeService dateTime;

//        public AuditableEntitySaveChangesInterceptor(
//            ICurrentUserService currentUserService,
//            IDateTimeService dateTime)
//        {
//            currentUserService = currentUserService;
//            dateTime = dateTime;
//        }

//        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
//        {
//            UpdateEntities(eventData.Context);

//            return base.SavingChanges(eventData, result);
//        }

//        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
//        {
//            UpdateEntities(eventData.Context);

//            return base.SavingChangesAsync(eventData, result, cancellationToken);
//        }

//        public void UpdateEntities(DbContext? context)
//        {
//            if (context == null) return;

//            DateTime now = dateTime.Now;

//            foreach (var entry in context.ChangeTracker.Entries<AuditableEntity>())
//            {
//                if (entry.State == EntityState.Added)
//                {
//                    entry.Entity.CreatedAt = currentUserService.UserId;
//                    entry.Entity.CreatedAt = now;
//                }

//                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
//                {
//                    entry.Entity.ModifierId = currentUserService.UserId;
//                    entry.Entity.ModifiedAt = now;
//                }
//            }
//        }
//    }
//}