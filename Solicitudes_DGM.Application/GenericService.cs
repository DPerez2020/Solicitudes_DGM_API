namespace Solicitudes_DGM.Application
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Solicitudes_DGM.Persistence;

    public class GenericService<TEntity> : IGenericService<TEntity>
        where TEntity : class
    {
        private readonly IGenericRepository<TEntity> genericRepository;

        public GenericService(IGenericRepository<TEntity> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public async Task Delete(int id)
        {
            await this.genericRepository.Delete(id);
        }

        public Task<List<TEntity>> GetAll()
        {
            return this.genericRepository.GetAll();
        }

        public Task<TEntity> GetById(int id)
        {
            return this.genericRepository.GetById(id);
        }

        public Task<TEntity> Insert(TEntity entity)
        {
            return this.genericRepository.Insert(entity);
        }

        public Task<TEntity> Update(TEntity entity)
        {
            return this.genericRepository.Update(entity);
        }
    }
}
