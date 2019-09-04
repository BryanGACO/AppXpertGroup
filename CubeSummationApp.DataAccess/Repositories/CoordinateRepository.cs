using CubeSummationApp.DataAccess.Contracts.Context;
using CubeSummationApp.DataAccess.Contracts.Entities;
using CubeSummationApp.DataAccess.Contracts.Repositories;
using CubeSummationApp.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CubeSummationApp.DataAccess.Repositories
{
    public class CoordinateRepository : BaseRepository<CoordinateEntity>, ICoordinateRepository
    {
        public CoordinateRepository(ICubeSummationDbContext cubeSummationDbContext) :
            base(cubeSummationDbContext)
        {

        }

        public async Task<CoordinateEntity> Update(CoordinateEntity updateEntity)
        {
            var entity = await Get(updateEntity.Id);

            entity.X = updateEntity.X;
            entity.Y = updateEntity.Y;
            entity.Z = updateEntity.Z;
            entity.Value = updateEntity.Value;

            _cubeSummationDbContext.Coordinates.Update(entity);

            await _cubeSummationDbContext.SaveChangesAsync();

            return entity;
        }
    }
}
