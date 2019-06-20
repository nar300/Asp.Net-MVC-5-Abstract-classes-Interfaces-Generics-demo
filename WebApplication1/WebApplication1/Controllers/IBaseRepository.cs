using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    interface IBaseRepository<T> where T:BaseClass
    {

        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int? id);
        Task<T> Create(T body);
        Task<T> Update(int id, T body);
        Task<T> Delete(int id);
    }
}
