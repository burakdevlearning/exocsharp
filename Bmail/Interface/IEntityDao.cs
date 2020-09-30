using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmail.Interface
{
    interface IEntityDao<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetOnebyId(int id);
        Task<T> Update(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Add(T entity);
    }
}
