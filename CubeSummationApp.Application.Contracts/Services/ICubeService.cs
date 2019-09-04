using CubeSummationApp.Application.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CubeSummationApp.Application.Contracts.Services
{
    public interface ICubeService
    {
        Task<List<int[]>> ResolveCubes(List<Cube> cubes);
    }
}
