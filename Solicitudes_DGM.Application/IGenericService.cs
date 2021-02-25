namespace Solicitudes_DGM.Application
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IGenericService<TEntity>
        where TEntity : class
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(int id);

        Task<TEntity> Insert(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task Delete(int id);
    }
}
