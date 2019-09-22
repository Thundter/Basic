using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using e = Basic.Data.Entities;

namespace Basic.Data.TestDatabase
{
    public class TestTableDataAccess : TestDatabaseData
    {
        public async Task<IEnumerable<e.TestTable>> LoadPage(int offset, int count)
        {
            var sqlParams = new SqlParameter[]
            {
                new SqlParameter("@offset", offset),
                new SqlParameter("@count", count),
            };
            return await this.Database.SqlQuery<e.TestTable>("TestTable_SelectPage" + sqlParams.AsExecuteString(), sqlParams).ToListAsync();
        }

        public async Task<int> Update(e.TestTable record)
        {
            var sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Id", record.Id),
                new SqlParameter("@test_bigint", record.test_bigint),
                new SqlParameter("@test_binary", record.test_binary),
                new SqlParameter("@test_bit", record.test_bit),
                new SqlParameter("@test_char", record.test_char),
                new SqlParameter("@test_date", record.test_date),
                new SqlParameter("@test_datetime", record.test_datetime),
                new SqlParameter("@test_datetime2", record.test_datetime2),
                new SqlParameter("@test_decimal", record.test_decimal),
                new SqlParameter("@test_float", record.test_float),
                new SqlParameter("@test_image", record.test_image),
                new SqlParameter("@test_int", record.test_int),
                new SqlParameter("@test_money", record.test_money),
                new SqlParameter("@test_nchar", record.test_nchar),
                new SqlParameter("@test_ntext", record.test_ntext),
                new SqlParameter("@test_numeric", record.test_numeric),
                new SqlParameter("@test_nvarchar", record.test_nvarchar),
                new SqlParameter("@test_real", record.test_real),
                new SqlParameter("@test_smalldatetime", record.test_smalldatetime),
                new SqlParameter("@test_smallint", record.test_smallint),
                new SqlParameter("@test_smallmoney", record.test_smallmoney),
                new SqlParameter("@test_text", record.test_text),
                new SqlParameter("@test_time", record.test_time),
                new SqlParameter("@test_timestamp", record.test_timestamp),
                new SqlParameter("@test_tinyint", record.test_tinyint),
                new SqlParameter("@test_uniqueidentifier", record.test_uniqueidentifier),
                new SqlParameter("@test_varbinary", record.test_varbinary),
                new SqlParameter("@test_varchar", record.test_varchar),
                new SqlParameter("@test_xml", record.test_xml),
            };
            // new SqlParameter("@criteria", (object)record.NullableField ?? DBNull.Value),

            return await this.ExecuteSqlCommandAsync("TestTable_Update", sqlParams);
        }

        public async Task<long> Insert(e.TestTable record)
        {
            var returnParam = new SqlParameter("@Id", SqlDbType.BigInt) { Direction = ParameterDirection.Output };
            var sqlParams = new SqlParameter[]
            {
                returnParam,
                new SqlParameter("@test_bigint", record.test_bigint),
                new SqlParameter("@test_binary", record.test_binary),
                new SqlParameter("@test_bit", record.test_bit),
                new SqlParameter("@test_char", record.test_char),
                new SqlParameter("@test_date", record.test_date),
                new SqlParameter("@test_datetime", record.test_datetime),
                new SqlParameter("@test_datetime2", record.test_datetime2),
                new SqlParameter("@test_decimal", record.test_decimal),
                new SqlParameter("@test_float", record.test_float),
                new SqlParameter("@test_image", record.test_image),
                new SqlParameter("@test_int", record.test_int),
                new SqlParameter("@test_money", record.test_money),
                new SqlParameter("@test_nchar", record.test_nchar),
                new SqlParameter("@test_ntext", record.test_ntext),
                new SqlParameter("@test_numeric", record.test_numeric),
                new SqlParameter("@test_nvarchar", record.test_nvarchar),
                new SqlParameter("@test_real", record.test_real),
                new SqlParameter("@test_smalldatetime", record.test_smalldatetime),
                new SqlParameter("@test_smallint", record.test_smallint),
                new SqlParameter("@test_smallmoney", record.test_smallmoney),
                new SqlParameter("@test_text", record.test_text),
                new SqlParameter("@test_time", record.test_time),
                new SqlParameter("@test_timestamp", record.test_timestamp),
                new SqlParameter("@test_tinyint", record.test_tinyint),
                new SqlParameter("@test_uniqueidentifier", record.test_uniqueidentifier),
                new SqlParameter("@test_varbinary", record.test_varbinary),
                new SqlParameter("@test_varchar", record.test_varchar),
                new SqlParameter("@test_xml", record.test_xml),
            };

            await this.ExecuteSqlCommandAsync("TestTable_Insert", sqlParams);

            return (long)returnParam.Value;
        }

        public async Task<int> Delete(e.TestTable record)
        {
            var sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Id", record.Id),
            };

            return await this.ExecuteSqlCommandAsync("TestTable_Delete", sqlParams);
        }
    }
}