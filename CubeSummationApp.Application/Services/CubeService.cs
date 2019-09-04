using CubeSummationApp.Application.Contracts.Services;
using CubeSummationApp.Application.Entities;
using CubeSummationApp.Application.Entities.Resources;
using CubeSummationApp.DataAccess.Contracts.Mappers;
using CubeSummationApp.DataAccess.Contracts.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CubeSummationApp.Application.Services
{
    public class CubeService : ICubeService
    {
        private readonly ICubeRepository _cubeRepository;

        public CubeService(ICubeRepository cubeRepository)
        {
            this._cubeRepository = cubeRepository;            
        }

        public async Task<List<int[]>> ResolveCubes(List<Cube> cubes)
        {
            var resultados = new List<int[]>();
            foreach (var cube in cubes)
            {
                resultados.Add(ResolveCube(cube));
            }

            return resultados;
        }
        
        private int[] ResolveCube(Cube cube)
        {
            var resultadosQueries = new List<int>();            
            foreach (var query in cube.Queries)
            {
                if (query.Tipo == QueryTypes.Update)
                {
                    cube.UpdateCoordinate(query.CoordenadaInicial);
                }
                else if (query.Tipo == QueryTypes.Query)
                {
                    resultadosQueries.Add(cube.GetQuery(query.CoordenadaInicial, query.CoordenadaFinal));
                }
            }

            return resultadosQueries.ToArray();
        }
    }
}
