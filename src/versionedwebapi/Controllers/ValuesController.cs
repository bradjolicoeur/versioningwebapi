using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace versionedwebapi.Controllers
{
    
    [ApiVersion( "20191207")]
    [ApiVersion( "20191021")]
    [Route("api/v{version:apiVersion}/values")]
    //[Route("api/v1/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public string Get() => "Hello world v20191021!";
    
        [HttpGet, MapToApiVersion("20191207")]
        public string GetV2() => "Hello world v20191207!";

    }
}
