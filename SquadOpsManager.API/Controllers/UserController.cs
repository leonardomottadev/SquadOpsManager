﻿using Microsoft.AspNetCore.Mvc;

namespace SquadOpsManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public string Get()
        {
            return "New User";
        }
    }
}
