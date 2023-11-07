using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleAPI3.Models;
using SampleAPI3.Services;

namespace SampleAPI3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly UserService _userService;
        private readonly keycloakContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, UserService userService, keycloakContext context)
        {
            _logger = logger;
            _userService = userService;
            _context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Hello()
        {
            return Ok("Selamalrrr");
        }


        [HttpGet("/Login")]
        public IActionResult Login()
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = "/" });
        }

        [HttpGet("/Logout")]
        public IActionResult Logout()
        {
            return SignOut(new AuthenticationProperties() { RedirectUri = "/" },
                CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme);
        }

        [HttpDelete("{userId}")]
        [Authorize]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            bool result = await _userService.DeleteUserAsync(userId);



            if (result)
            {
                return Ok("Kullanýcý baþarýyla silindi.");
            }
            else
            {
                return BadRequest("Kullanýcý silinirken bir hata oluþtu.");
            }

            var user = await _context.UserEntities.FindAsync(userId);

            _context.UserEntities.Remove(user);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}