﻿using Microsoft.AspNetCore.Mvc;
using MongDbWebAPI.Services;

namespace MongDbWebAPI.Controllers
{
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
        [Route("Driver")]
        public async Task<IActionResult> Index()
        {
            return Ok(await _driverService.GetAsync());
        }
    }
}
