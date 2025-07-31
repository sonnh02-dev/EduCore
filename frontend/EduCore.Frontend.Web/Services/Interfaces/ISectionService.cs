using EduCore.Frontend.Web.ViewModels;
using System.Collections;

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface ISectionService
    {
        public Task<IEnumerable<SectionViewModel>> GetAllSectionByCourseId(int courseId);
    }
}
