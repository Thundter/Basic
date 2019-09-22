using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Data.TestDatabase
{
    public static class Extensions
    {
        public static string AsExecuteString(this IEnumerable<SqlParameter> sqlParameters) => string.Join(",", sqlParameters.Select(p => string.Concat(" ", p.ParameterName, p.Direction == ParameterDirection.Output ? " out" : string.Empty)));

        public static async Task<int> ExecuteSqlCommandAsync(this DbContext context, string procedureName, params SqlParameter[] sqlParameters) => await context.Database.ExecuteSqlCommandAsync(procedureName + sqlParameters.AsExecuteString(), sqlParameters);

        public static DbRawSqlQuery<T> SqlQuery<T>(this DbContext context, string procedureName, params SqlParameter[] sqlParameters) => context.Database.SqlQuery<T>(procedureName + sqlParameters.AsExecuteString(), sqlParameters);
    }
}