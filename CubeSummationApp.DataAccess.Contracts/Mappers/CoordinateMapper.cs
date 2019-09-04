using CubeSummationApp.Application.Entities;
using CubeSummationApp.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubeSummationApp.DataAccess.Contracts.Mappers
{
    public static class CoordinateMapper
    {
        public static CoordinateEntity Map(Coordinate dto)
        {
            return new CoordinateEntity()
            {
                Id = dto.Id,
                CubeId = dto.CubeId,
                X = dto.X,
                Y = dto.Y,
                Z = dto.Z,
                Value = dto.Value
            };
        }

        public static Coordinate Map(CoordinateEntity entity)
        {
            return new Coordinate()
            {
                Id = entity.Id,
                CubeId = entity.CubeId,
                X = entity.X,
                Y = entity.Y,
                Z = entity.Z,
                Value = entity.Value
            };
        }
    }
}
