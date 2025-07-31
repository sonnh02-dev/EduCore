using EduCore.BackEnd.Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using EduCore.BackEnd.Application.Module.Comments;
using EduCore.BackEnd.Application.Module.Comments.DTOs;

namespace EduCore.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : Controller
    {
        public ICommentService commentService;
        public CommentController(ICommentService _commentService)
        {
            commentService = _commentService;
        }
        [HttpPost("addComment")]
        public async Task<IActionResult> AddComment([FromBody] CreateCommentRequest CommentResponse)
        {
            await commentService.AddComment(CommentResponse);
            return Ok();
        }
        //[HttpGet("getCommentById/{commentId}")]
        //public async Task<IActionResult> GetCommentById(int commentId)
        //{
           
        //    return Ok(await commentService.GetCommentById(commentId));
        //}

    }


}
