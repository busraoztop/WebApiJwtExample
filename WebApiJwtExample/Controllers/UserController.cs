using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwtExample.DTO;
using WebApiJwtExample.Model;
using WebApiJwtExample.Service.Abstract;

namespace WebApiJwtExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Save(User user)
        {
            return Ok(_userService.Save(user));
        }
    }
}
