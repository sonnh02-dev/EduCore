using Profile = AutoMapper.Profile;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;

namespace EduCore.BackEnd.Application.Module.Comments
{
    public class CommentMapping : Profile
    {
        public CommentMapping()
        {
            //CreateMap<Comment, CommentResponse>()
            // .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
            // .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.FullName))
            // .ForMember(dest => dest.UserImg, opt => opt.MapFrom(src => src.User.UrlImage))
            // .ForMember(dest => dest.CommentOn, opt => opt.MapFrom(src => src.CommentOn))
            // .ForMember(dest => dest.Replies, opt => opt.MapFrom(src => src.InverseReply)).
            // ReverseMap();

            //CreateMap<Comment, CreateCommentRequest>()
            //.ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
            //.ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
            //.ForMember(dest => dest.LectureId, opt => opt.MapFrom(src => src.LectureId))
            //.ForMember(dest => dest.ReplyId, opt => opt.MapFrom(src => src.ReplyId)).ReverseMap();
        }
    }
}
