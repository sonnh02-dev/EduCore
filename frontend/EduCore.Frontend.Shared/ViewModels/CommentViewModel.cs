namespace EduCore.Frontend.Shared.ViewModels
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int ProfileId { get; set; }
        public string FullName { get; set; }
        public string UrlImage { get; set; }

        public DateTime CommentOn { get; set; }
        public int NumberOfLikes { get; set; }

        public List<CommentViewModel> Replies { get; set; }
    }
}
