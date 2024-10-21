namespace GesFin.Api.Controllers;

using GesFin.Domain.Models.User;
using Microsoft.AspNetCore.Mvc;

[ApiController]
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
    public async Task<IActionResult> Add(User user)
    {
        await _userService.Add(user);
        return Created("v1/users", user);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(long id)
    {
        await _userService.Delete(id);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update(User user)
    {
        await _userService.Update(user);
        return Ok();
    }
}