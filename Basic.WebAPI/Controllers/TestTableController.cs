using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic.WebAPI.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using m = Basic.WebAPI.Models;

namespace Basic.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TestTableController : ControllerBase
    {
        public ITestTableService TestTableService { get; set; }

        private int _pageSize = 10;

        [HttpGet]
        public async Task<IEnumerable<m.TestTable>> Get(int page = 0) => await this.TestTableService.LoadPage(_pageSize * page, _pageSize);

        [HttpPost]
        public async Task<long> CancelPendingContacts(m.TestTable record) => await this.TestTableService.Insert(record);

        [HttpPost]
        public async Task Insert(m.TestTable record) => await this.TestTableService.Update(record);


    }
}