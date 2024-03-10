using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Helpers
{
    public class DBResponser
    {
        public bool State { get; set; }
        public string ErrorMessage { get; set; }
        public DataTable Data { get; set; }
        public DBResponser(DataTable data)
        {
            State = true;
            Data = data;
            ErrorMessage = "";
        }

        public DBResponser(string error)
        {
            State = false;
            Data = new DataTable();
            ErrorMessage = error;
        }
    }

}
