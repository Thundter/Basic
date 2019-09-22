using Basic.Data.Interfaces;
using Basic.WebAPI.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using m = Basic.WebAPI.Models;
using Basic.Logic.Mappers;

namespace Basic.Logic
{
    public class TestTableService: m.Interfaces.ITestTableService
    {
        public ITestTableDataAccess TestTableDataAccess { get; set; }

        public async Task<IEnumerable<m.TestTable>> LoadPage(int offset, int count)
        {
            var output = await this.TestTableDataAccess.LoadPage(offset, count);

            return output.Select(x => x.ToModel());
        }

        public async Task Update(m.TestTable record) => await this.TestTableDataAccess.Update(record.ToDataModel());

        public async Task<long> Insert(m.TestTable record) => await this.TestTableDataAccess.Insert(record.ToDataModel());
    }
}