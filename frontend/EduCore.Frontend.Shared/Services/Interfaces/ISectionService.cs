using EduCore.Frontend.Shared.ViewModels;
using System.Collections;

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface ISectionService
    {
        public Task<IEnumerable<SectionViewModel>> GetAllSectionByCourseId(int courseId);
    }
}
