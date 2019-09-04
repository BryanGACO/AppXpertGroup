using CubeSummationApp.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CubeSummationApp.DataAccess.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<UserEntity> Update(UserEntity entity);
    }
}
