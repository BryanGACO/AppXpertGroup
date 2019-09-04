using CubeSummationApp.Application.Entities;
using CubeSummationApp.DataAccess.Contracts.Entities;

namespace CubeSummationApp.DataAccess.Contracts.Mappers
{
    public static class CubeMapper
    {
        public static CubeEntity Map(Cube dto, int userId)
        {
            return new CubeEntity()
            {
                Id = dto.Id,
                Dimension = dto.Dimension,
                UserId = userId
            };
        }

        public static Cube Map(CubeEntity entity)
        {
            return new Cube()
            {
                Id = entity.Id,
                Dimension = entity.Dimension
            };
        }
    }
}
