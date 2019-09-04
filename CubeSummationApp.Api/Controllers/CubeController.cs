using System.Collections.Generic;
using System.Threading.Tasks;
using CubeSummationApp.Application.Contracts.Services;
using CubeSummationApp.ModelsUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CubeSummationApp.Api.Mappers;

namespace CubeSummationApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CubeController : ControllerBase
    {
        private readonly ICubeService _cubeService;

        public CubeController(ICubeService cubeService)
        {
            _cubeService = cubeService;        
        }

        /// <summary>
        /// Add a new cube
        /// </summary>
        /// <param name="cube">CubeModel</param>
        /// <returns>Admin</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json", Type = typeof(List<int[]>))]
        [HttpPost]
        public async Task<IActionResult> ResolveCube([FromBody]List<CubeModel> cubos)
        {            
            var resultadosQueries = await _cubeService.ResolveCubes(cubos.Select(c => CubeMapper.Map(c)).ToList());         
            return Ok(resultadosQueries);
        }
    }
}