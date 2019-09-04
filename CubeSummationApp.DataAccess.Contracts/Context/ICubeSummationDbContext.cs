using CubeSummationApp.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CubeSummationApp.DataAccess.Contracts.Context
{
    public interface ICubeSummationDbContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<CubeEntity> Cubes { get; set; }
        DbSet<CoordinateEntity> Coordinates { get; set; }

        /* Estas propiedades se cargan cuando se hereda de DbContext */
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);
    }
}
