using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.Sections
{
    public interface ISectionService

    {
        public Task<List<SectionDTO>> GetListSectionByCourseId(int courseId);
    }
}
