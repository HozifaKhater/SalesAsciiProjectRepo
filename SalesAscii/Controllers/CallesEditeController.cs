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
    public class CallesEditeController : ControllerBase
    {
        private readonly IDBConnector _db;
        public CallesEditeController(IDBConnector db)
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


        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> GetAllDoneCalls(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_all_done_calls", param);
            return Ok(new ServiceResponse(result));
        }

        [HttpPost]
        public async Task<IActionResult> GetAllDoneCallsByDates([FromBody] GetAllDoneCallsByDatesViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.master_visit_code), Value = model.master_visit_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.to_date), Value = model.to_date });
                param.Add(new SqlParameter { ParameterName = nameof(model.from_date), Value = model.from_date });

                var result = await _db.ExecuteNonQuery("get_all_done_calls_by_dates", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteVisiteFromList([FromBody] DeleteVisiteFromListViewModel model)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(model.doc_code), Value = model.doc_code });
            param.Add(new SqlParameter { ParameterName = nameof(model.myser), Value = model.myser });
            param.Add(new SqlParameter { ParameterName = nameof(model.master_visit_code), Value = model.master_visit_code });

            var result = await _db.ExecuteNonQuery("delete_visits_from_list", param);

            return Ok(new ServiceResponse(result));
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
