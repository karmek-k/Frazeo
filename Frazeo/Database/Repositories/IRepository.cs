using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazeo.Database.Repositories
{
    internal interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAsync(string text);
    }
}
