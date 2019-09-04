using CubeSummationApp.DataAccess.Contracts.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CubeSummationApp.DataAccess.Repositories.Base
{
    public class BaseRepository<T> where T : class
    {
        protected internal readonly ICubeSummationDbContext _cubeSummationDbContext;

        private readonly DbSet<T> _dbSet;

        public BaseRepository(ICubeSummationDbContext cubeSummationDbContext)
        {
            this._cubeSummationDbContext = cubeSummationDbContext;
            this._dbSet = this._cubeSummationDbContext.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            await this._dbSet.AddAsync(entity);
            await _cubeSummationDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Get(int id)
        {
            var result = await this._dbSet.FindAsync(id);
            return result;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this._dbSet.ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            this._dbSet.Update(entity);

            await _cubeSummationDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {

            var entity = await this._dbSet.FindAsync(id);

            this._dbSet.Remove(entity);

            await _cubeSummationDbContext.SaveChangesAsync();
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }
    }
}
