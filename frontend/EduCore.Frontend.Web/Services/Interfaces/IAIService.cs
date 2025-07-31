using EduCore.Frontend.Web.ViewModels;

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface IAIService
    {
        public Task<double> EvaluateAnswer();

    }
}
