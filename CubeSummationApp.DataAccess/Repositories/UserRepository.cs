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
    public class UserRepository: BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(ICubeSummationDbContext cubeSummationDbContext) :
            base(cubeSummationDbContext)
        {

        }

        public async Task<UserEntity> Update(UserEntity updateEntity)
        {
            var entity = await Get(updateEntity.Id);

            entity.Name = updateEntity.Name;

            _cubeSummationDbContext.Users.Update(entity);

            await _cubeSummationDbContext.SaveChangesAsync();

            return entity;
        }
    }
}
