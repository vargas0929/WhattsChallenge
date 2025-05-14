using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Whatts.Application.Contracts;
using Whatts.Services.WebApi.Filters;


namespace Whatts.Services.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserApplication _userApplication;
        private readonly ILogger<UserController> _logger;
        public UserController(IUserApplication userApplication, ILogger<UserController> logger)
        {
            _userApplication = userApplication;
            _logger = logger;
        }
        //Descomentar si se requiere que solicite el api key del appsettings
        //[ApiKeyAuth]
        [HttpGet(Name = "get-wallet-by-email")]
        public ActionResult GetWalletByEmail([FromQuery] string email)
        {
            var response = _userApplication.getWalletByEmail(email);
            return StatusCode(response.StatusCode, response);
        }
    }
}
