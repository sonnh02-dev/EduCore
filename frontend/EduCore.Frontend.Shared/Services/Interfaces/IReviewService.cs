using EduCore.Frontend.Shared.ViewModels;

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface IReviewService
    {
        public Task<List<ReviewViewModel>> GetListReview();


    }
}
