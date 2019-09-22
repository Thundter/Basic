using System.Collections.Generic;
using System.Threading.Tasks;

namespace Basic.WebAPI.Models.Interfaces
{
    public interface ITestTableService
    {
        Task<IEnumerable<TestTable>> LoadPage(int offset, int count);
        Task Update(TestTable record);
        Task<long> Insert(TestTable record);
    }
}