using EduCore.Frontend.Shared.ViewModels;

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface IAIService
    {
        public Task<double> EvaluateAnswer();

    }
}
