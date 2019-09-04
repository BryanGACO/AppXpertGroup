using CubeSummationApp.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CubeSummationApp.DataAccess.Contracts.Repositories
{
    public interface ICoordinateRepository
    {
        Task<CoordinateEntity> Update(CoordinateEntity entity);
    }
}
