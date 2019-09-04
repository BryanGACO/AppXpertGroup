using CubeSummationApp.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CubeSummationApp.DataAccess.EntityConfig
{
    public static class CubeEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<CubeEntity> entityBuilder)
        {
            entityBuilder.ToTable("Cubes");

            entityBuilder.HasKey(x => x.Id);
        }
    }
}
