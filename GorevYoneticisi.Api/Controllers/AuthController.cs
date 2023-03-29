using AutoMapper;
using GorevYoneticisi.Business.Abstract;
using GorevYoneticisi.Business.Dtos;
using GorevYoneticisi.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GorevYoneticisi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;

        public AuthController(IUserService userService, IMapper mapper,ITokenService tokenService)
        {
            _userService = userService;
            _mapper = mapper;
            _tokenService = tokenService;
        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody] UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _userService.Add(user);
            return Ok();
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserDto userDto)
        {
            var user = _userService.Get(u=>u.UserName==userDto.UserName&&u.Password==userDto.Password);
            if (user == null) return NotFound("Kullanıcı bulunamadı");
            var token = _tokenService.CreateToken(user);
            return Ok(token);
        }
    }
}
