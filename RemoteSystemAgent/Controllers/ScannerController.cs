using LocalSystemDevicesInterface;
using LocalSystemDevicesInterface.Exceptions;
using LocalSystemDevicesInterface.Providers;
using LocalSystemDevicesInterface.Scanners;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RemoteSystemAgent.RequestTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteSystemAgent.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ScannerController : ControllerBase
    {
        private readonly ISystemScannersProvider scanner;

        public ScannerController(ILogger<ScannerController> logger,
            ISystemScannersProvider scanner)
        {
            this.scanner = scanner;
        }

        [HttpPost]
        [Route("capabilities")]
        public IActionResult Capabilities([FromBody] CapabilitiesRequest request)
        {
            return GetCapabilities(request.Name);
        }

        [HttpGet]
        [Route("capabilities/{name}")]
        public IActionResult GetCapabilities(string name)
        {
            try
            {
                return Ok(scanner.Capabilities(name));
            }
            catch (UnknownLocalSystemScannerException e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}
