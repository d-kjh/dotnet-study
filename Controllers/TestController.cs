using Microsoft.AspNetCore.Mvc; // 컨트롤러 + api기능들을 쓰기 위한 라이브러리 import *필수!

namespace MyApi.Controllers;

[ApiController]
[Route("[controller]")] // 컨트롤러 이름 자동 치환 controller제거
public class TestController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello .net";
    }
}

//주소가 localhost:port/test 가 된다
