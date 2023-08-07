using Microsoft.AspNetCore.Mvc;
using MongDbWebAPI.Services;

namespace MongDbWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriverController : ControllerBase
    {
        public ILogger<DriverController> _logger;
        private DriverService _driverService;

        // Add the constructor
        public DriverController(ILogger<DriverController> logger, DriverService driverService)
        {
            _logger= logger;
            _driverService= driverService;
        }
        [HttpGet]
        public async Task<IActionResult> GetDrivers()
        {
            return Ok(await _driverService.GetAsync());
        }
    }
}
