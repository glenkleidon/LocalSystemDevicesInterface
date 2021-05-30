using LocalSystemDevicesInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteSystemAgent.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class LocalSystemController : ControllerBase
    {
        public LocalSystemController(ILogger<LocalSystemController> logger,
              ILocalSystemDeviceInterface devices)
        {
            this.logger = logger;
            this.devices = devices;
        }

        private readonly ILogger<LocalSystemController> logger;
        private readonly ILocalSystemDeviceInterface devices;

        [HttpGet]
        public ILocalSystemDeviceInterface Get()
        {
            return devices;
        }
    }
}
