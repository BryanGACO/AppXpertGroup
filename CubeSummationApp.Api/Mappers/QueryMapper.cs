using CubeSummationApp.Application.Entities;
using CubeSummationApp.ModelsUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CubeSummationApp.Api.Mappers
{
    public class QueryMapper
    {
        public static Query Map(QueryModel model)
        {
            return new Query()
            {
                Tipo = model.Tipo,
                CoordenadaInicial = CoordinateMapper.Map(model.CoordenadaInicial),
                CoordenadaFinal = CoordinateMapper.Map(model.CoordenadaFinal)
            };
        }

        public static QueryModel Map(Query dto)
        {
            return new QueryModel()
            {
                Tipo = dto.Tipo,
                CoordenadaInicial = CoordinateMapper.Map(dto.CoordenadaInicial),
                CoordenadaFinal = CoordinateMapper.Map(dto.CoordenadaFinal)
            };
        }
    }
}
