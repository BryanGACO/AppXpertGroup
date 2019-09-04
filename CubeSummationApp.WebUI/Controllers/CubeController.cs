using System;
using System.Collections.Generic;
using CubeSummationApp.ModelsUI.Models;
using CubeSummationApp.WebUI.Utils;
using Microsoft.AspNetCore.Mvc;

namespace CubeSummationApp.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CubeController : ControllerBase
    {
        [HttpPost("ResolveCube")]
        public IEnumerable<int[]> ResolveCube([FromBody]List<CubeModel> cubos)
        {
            var apiCaller = new ApiCaller();
            var resultado = apiCaller.PostService<List<int[]>>("Cube", cubos);
            return resultado.Result;
        }
    }
}