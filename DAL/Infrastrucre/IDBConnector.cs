using DAL.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Infrastrucre
{
    public interface IDBConnector
    {
        Task<DBResponser> ExecuteQuery(string storedProcedureName, Dictionary<string, string>? pars = null);
        DataTable CreateDataTable<T>(List<T> list);
        Task<DBResponser> ExecuteNonQuery(string storedProcedureName, List<SqlParameter> pars);
    }
}
