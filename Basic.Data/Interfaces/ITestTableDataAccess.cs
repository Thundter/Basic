using System.Collections.Generic;
using System.Threading.Tasks;
using e = Basic.Data.Entities;

namespace Basic.Data.Interfaces
{
    public interface ITestTableDataAccess
    {
        Task<IEnumerable<e.TestTable>> LoadPage(int offset, int count);
        Task Update(e.TestTable record);
        Task<long> Insert(e.TestTable record);
    }
}