using EduCore.Frontend.Web.ViewModels;

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface ICommentService
    {
        public  Task<int> AddComment(AddCommentViewModel comment);
         public Task<CommentViewModel>  GetCommentById(int? id);
    }
}
