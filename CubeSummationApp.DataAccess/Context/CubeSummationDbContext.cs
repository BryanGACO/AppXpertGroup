using CubeSummationApp.DataAccess.Contracts.Context;
using CubeSummationApp.DataAccess.Contracts.Entities;
using CubeSummationApp.DataAccess.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubeSummationApp.DataAccess.Context
{
    public class CubeSummationDbContext: DbContext, ICubeSummationDbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CubeEntity> Cubes { get; set; }
        public DbSet<CoordinateEntity> Coordinates { get; set; }

        public CubeSummationDbContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserEntityConfig.SetEntityBuilder(modelBuilder.Entity<UserEntity>());
            CubeEntityConfig.SetEntityBuilder(modelBuilder.Entity<CubeEntity>());
            CoordinateEntityConfig.SetEntityBuilder(modelBuilder.Entity<CoordinateEntity>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
