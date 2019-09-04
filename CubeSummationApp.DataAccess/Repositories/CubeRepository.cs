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
    public class CubeRepository : BaseRepository<CubeEntity>, ICubeRepository
    {
        public CubeRepository(ICubeSummationDbContext cubeSummationDbContext) :
            base(cubeSummationDbContext)
        {

        }

        public async Task<CubeEntity> Update(int id, CubeEntity updateEntity)
        {
            var entity = await Get(id);

            entity.Dimension = updateEntity.Dimension;

            _cubeSummationDbContext.Cubes.Update(entity);

            await _cubeSummationDbContext.SaveChangesAsync();

            return entity;
        }

    }
}
