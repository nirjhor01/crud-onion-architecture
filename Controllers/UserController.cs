using DomainlayerClassLibrary1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayerClassLibrary3.Service.Contract_Interface;

namespace CrudUsingOnion.Controllers
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
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAllRepo() {
            var response = this._userService.GetAllUser();
            return Ok(response);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Adduser(User user)
        {
            return Ok(this._userService.AddUserRepo(user));
        }
    }
}
