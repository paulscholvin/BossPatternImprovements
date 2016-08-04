using System.Threading.Tasks;
using DomainModel.Entities;

namespace DomainModel.Interfaces
{
    public interface IRepository<T> where T: Entity
    {
        void Add(T entity);
        Task<T> GetById(int id);
    }
}
