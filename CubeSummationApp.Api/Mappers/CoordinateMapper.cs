using CubeSummationApp.Application.Entities;
using CubeSummationApp.ModelsUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CubeSummationApp.Api.Mappers
{
    public class CoordinateMapper
    {
        public static Coordinate Map(CoordinateModel  model)
        {
            return new Coordinate()
            {
                Value = model.Value,
                X = model.X,
                Y = model.Y,
                Z = model.Z                
            };
        }

        public static CoordinateModel Map(Coordinate dto)
        {
            return new CoordinateModel()
            {
                Value = dto.Value,
                X = dto.X,
                Y = dto.Y,
                Z = dto.Z
            };
        }
    }
}
