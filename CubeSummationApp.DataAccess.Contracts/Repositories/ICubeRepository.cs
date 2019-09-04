using CubeSummationApp.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CubeSummationApp.DataAccess.Contracts.Repositories
{
    public interface ICubeRepository: IRepository<CubeEntity>
    {
        Task<CubeEntity> Update(CubeEntity entity);
    }
}
