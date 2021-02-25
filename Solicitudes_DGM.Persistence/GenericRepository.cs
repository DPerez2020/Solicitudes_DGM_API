namespace Solicitudes_DGM.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        private readonly SolicitudesDBContext solicitudesDBContext;

        public GenericRepository(SolicitudesDBContext solicitudesDBContext)
        {
            this.solicitudesDBContext = solicitudesDBContext;
        }

        public async Task Delete(int id)
        {
            var entity = await this.solicitudesDBContext.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                throw new Exception("La entidad no existe");
            }

            this.solicitudesDBContext.Set<TEntity>().Remove(entity);

            await this.solicitudesDBContext.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await this.solicitudesDBContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await this.solicitudesDBContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            this.solicitudesDBContext.Set<TEntity>().Add(entity);
            await this.solicitudesDBContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            this.solicitudesDBContext.Set<TEntity>().Update(entity);
            await this.solicitudesDBContext.SaveChangesAsync();
            return entity;
        }
    }
}
