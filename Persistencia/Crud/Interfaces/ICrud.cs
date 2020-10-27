using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistencia.Crud.Interfaces
{
    public interface ICrud<T>
    {
        Task<List<T>> List();
        Task<T> GetObjById(int Id);
        Task Insert(T obj);
        Task Update(T obj);
        Task Delete(T obj);
    }
}
