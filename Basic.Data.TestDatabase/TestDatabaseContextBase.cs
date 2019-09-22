using System.Data.Entity;

namespace Basic.Data.TestDatabase
{
    public class TestDatabaseContextBase : DbContext
    {
        public TestDatabaseContextBase() : base("name=TestDatabase")
        {
            this.Database.CommandTimeout = 120;
        }
    }
}