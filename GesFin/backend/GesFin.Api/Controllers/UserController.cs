namespace GesFin.Api.Controllers;

using GesFin.Api.Models.Request;
using GesFin.Domain.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Authorize]
[Route("[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _userService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long id)
    {
        var user = await _userService.Get(id);
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> Add(Request<User> request)
    {
        await _userService.Add(request.Data);
        return Created("v1/users", request.Data);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(long id)
    {
        await _userService.Delete(id);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update(Request<User> request)
    {
        await _userService.Update(request.Data);
        return Ok();
    }
}