using CubeSummationApp.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubeSummationApp.DataAccess.EntityConfig
{
    public static class CoordinateEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<CoordinateEntity> entityBuilder)
        {
            entityBuilder.ToTable("Coordinates");

            entityBuilder.HasKey(x => x.Id);
        }
    }
}
