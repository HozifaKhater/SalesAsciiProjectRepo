using DAL.Helpers;
using DAL.Infrastrucre;
using DAL.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace SalesAscii.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NoWorkingDaysController : ControllerBase
    {
        private readonly IDBConnector _db;
        public NoWorkingDaysController(IDBConnector db)
        {
            _db = db;
        }


        [HttpGet("{ucode}")]
        public async Task<IActionResult> GetUesrType(decimal ucode)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(ucode), ucode.ToString());
            var result = await _db.ExecuteQuery("get_user_type", param);
            return Ok(new ServiceResponse(result));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFromNonWorkDays([FromBody] DeleteFromNonWorkDaysViewModel model)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(model.emp_code), Value = model.emp_code });
            param.Add(new SqlParameter { ParameterName = nameof(model.ser), Value = model.ser });

            var result = await _db.ExecuteNonQuery("delete_from_non_work_days", param);

            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{scode}")]
        public async Task<IActionResult> GetDefData(string scode)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(scode), scode.ToString());
            var result = await _db.ExecuteQuery("get_def_data", param);

            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{saleman_code}")]
        public async Task<IActionResult> GetRepNonWorkDay(decimal saleman_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(saleman_code), saleman_code.ToString());
            var result = await _db.ExecuteQuery("get_rep_non_work_days", param);

            return Ok(new ServiceResponse(result));
        }


        [HttpPost]
        public async Task<IActionResult> SaveNonWotkDay([FromBody] SaveNonWorkDayVoewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.day_date), Value = model.day_date });
                param.Add(new SqlParameter { ParameterName = nameof(model.saleman_code), Value = model.saleman_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.reason_code), Value = model.reason_code });

                var result = await _db.ExecuteNonQuery("save_non_work_day", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }
        [HttpGet("{ucode}")]
        public async Task<IActionResult> GetTheEmpName(decimal ucode)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(ucode), ucode.ToString());
            var result = await _db.ExecuteQuery("get_the_emp_name", param);
            return Ok(new ServiceResponse(result));
        }
    }
}
