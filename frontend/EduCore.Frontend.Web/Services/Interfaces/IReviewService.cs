using EduCore.Frontend.Web.ViewModels;

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface IReviewService
    {
        public Task<List<ReviewViewModel>> GetListReview();


    }
}
