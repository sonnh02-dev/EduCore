using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Aggregates.StudentCourseAggregate
{
    [Flags]
    public enum StudentCourseStatus
    {
        None = 0,        // 0000
        InCart = 1 << 0,   // 0001 = 1
        InWishlist = 1 << 1,   // 0010 = 2
        Enrolled = 1 << 2,   // 0100 = 4
        Removed = 1 << 3    // 1000 = 8
    }




}
