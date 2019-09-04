using CubeSummationApp.Application.Entities;
using CubeSummationApp.ModelsUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CubeSummationApp.Api.Mappers
{
    public class CubeMapper
    {
        public static Cube Map(CubeModel model)
        {
            return new Cube()
            {
                Dimension = model.Dimension,
                Id = model.Id,
                Operaciones = model.Operaciones,
                Queries = model.Queries.Select(q=> QueryMapper.Map(q)).ToList()
            };
        }

        public static CubeModel Map(Cube dto)
        {
            return new CubeModel()
            {
                Dimension = dto.Dimension,
                Id = dto.Id,
                Operaciones = dto.Operaciones,
                Queries = dto.Queries.Select(q => QueryMapper.Map(q)).ToList()
            };
        }
    }
}
