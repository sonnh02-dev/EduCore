using EduCore.BackEnd.Application.Interfaces.Services;
using EduCore.BackEnd.Application.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System.Net;

namespace EduCore.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        //private readonly IAuthenticationService _authenticationService;

        //public AccountController(IAuthenticationService authenticationService)
        //{
        //    _authenticationService = authenticationService;
        //}

        //[HttpPost("signin")]
        //public async Task<IActionResult> SignIn(SignInDTO request)
        //{
        //    var success = await _authenticationService.SignInAsync(request);

        //    if (success)
        //        return Ok(new { message = "Sign in successful" });

        //    return Unauthorized(new { message = "Invalid credentials" });
        //}

        //[HttpPost("signup")]
        //public async Task<IActionResult> SignUp(SignUpRequest request)
        //{
        //    var result = await _authenticationService.SignUpAsync(request);

        //    if (!result.Succeeded)
        //        return BadRequest(result.Errors);

        //    return Ok(result);
        //}

        //[Authorize]
        //[HttpGet("me")]
        //public async Task<IActionResult> GetCurrentUser()
        //{
        //    var user = await _authenticationService.GetCurrentUserAsync(User);
        //    return Ok(user);
        //}

        //[Authorize]
        //[HttpPost("changepassword")]
        //public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        //{
        //    var result = await _authenticationService.ChangePasswordAsync(User, request.CurrentPassword, request.NewPassword);

        //    if (!result.Succeeded)
        //        return BadRequest(result.Errors);

        //    return Ok(result);
        //}

        //[HttpGet("all-user")]
        //[EnableQuery]
        //public async Task<IActionResult> Get()
        //{
        //    var listUser = await _userService.GetListUser();
        //    return Ok(listUser);
        //}

        //[HttpGet("getUserById/{uID}")]
        //[EnableQuery]
        //public async Task<IActionResult> GetUserById(int uID)
        //{
        //    var user = await _userService.GetUserById(uID);
        //    return Ok(user);
        //}

        //[HttpPost("updateUser")]
        //public async Task<IActionResult> UpdateUser([FromBody] UserDTO userDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    try
        //    {
        //        await _userService.UpdateUser(userDto);
        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(new { message = ex.Message });
        //    }
        //}

        //[HttpPut("updateStatusUser")]
        //public async Task<IActionResult> UpdateStatusUserById([FromBody] UserStatusDTO userStatus)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    try
        //    {
        //        await _userService.UpdateStatusUser(userStatus);
        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(new { message = ex.Message });
        //    }
        //}
        //[HttpPost("addUser")]
        //public async Task<IActionResult> AddUser([FromBody] UserDTO userDto)
        //{
        //    await _userService.AddUser(userDto);
        //    return Ok();
        //}
        //[HttpDelete("deleteUser")]
        //public async Task<IActionResult> DeleteUser(int userId)
        //{
        //    try
        //    {
        //        await _userService.DeleteUser(userId);
        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(new { message = ex.Message });
        //    }
        //}

    }
}
