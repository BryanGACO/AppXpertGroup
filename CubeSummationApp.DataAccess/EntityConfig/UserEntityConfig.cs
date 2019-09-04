using CubeSummationApp.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CubeSummationApp.DataAccess.EntityConfig
{
    public static class UserEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<UserEntity> entityBuilder)
        {
            entityBuilder.ToTable("Users");

            entityBuilder.Property("CreatedDate").HasColumnType("DATETIME");

            entityBuilder.HasKey(x => x.Id);
        }
    }
}
