using DAL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DAL.Infrastrucre
{
    public class DBConnector : IDBConnector
    {
        private readonly IConfiguration _configuration;

        public DBConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DataTable CreateDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();

            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                dt.Columns.Add(new DataColumn(info.Name, info.PropertyType));
            }

            foreach (T t in list)
            {
                DataRow row = dt.NewRow();
                foreach (PropertyInfo info in typeof(T).GetProperties())
                {
                    row[info.Name] = info.GetValue(t, null);
                }
                dt.Rows.Add(row);
            }

            return dt;
        }

        public async Task<DBResponser> ExecuteQuery(string storedProcedureName, Dictionary<string, string>? pars = null)
        {
            SqlConnection cnn;
            string connetionString = _configuration.GetConnectionString("DefaultConnection") ?? "";

            cnn = new SqlConnection(connetionString);
            SqlDataReader reader;
            var data = new DataTable();

            try
            {
                using var command = new SqlCommand(storedProcedureName, cnn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (pars != null)
                {
                    pars.ToList().ForEach(par =>
                    {
                        command.Parameters.Add(par.Key, SqlDbType.VarChar).Value = par.Value;
                    });
                }

                cnn.Open();
                reader = await command.ExecuteReaderAsync();
                data.Load(reader);
                cnn.Close();

                return new DBResponser(data);
            }
            catch (Exception ex)
            {
                return new DBResponser(ex.Message);
            }
        }

        public async Task<DBResponser> ExecuteNonQuery(string storedProcedureName, List<SqlParameter> pars)
        {
            SqlConnection cnn;
            string connetionString = _configuration.GetConnectionString("DefaultConnection") ?? "";

            cnn = new SqlConnection(connetionString);
            SqlDataReader reader;
            var data = new DataTable();

            try
            {
                using var command = new SqlCommand(storedProcedureName, cnn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (pars != null)
                {
                    pars.ForEach(par =>
                    {
                        command.Parameters.Add(par);
                    });
                }

                cnn.Open();
                reader = await command.ExecuteReaderAsync();
                data.Load(reader);
                cnn.Close();

                return new DBResponser(data);
            }
            catch (Exception ex)
            {
                return new DBResponser(ex.Message);
            }
        }
    }
}
