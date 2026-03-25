using Microsoft.AspNetCore.Mvc;
using MyApi.Models; // UserDto를 쓰기위해 해당 폴더를 명시해준다

namespace MyApi.Controllers;

[ApiController]
[Route("")] // 기본 경로 없음 → 바로 /join 가능
public class UserController : ControllerBase
{
    // 회원가입 API
    [HttpPost("join")]
    public string Join([FromBody] UserDto user)
    {
        return $"회원가입 완료: {user.Username}";
    }
}