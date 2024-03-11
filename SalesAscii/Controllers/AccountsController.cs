using DAL.Helpers;
using DAL.Infrastrucre;
using DAL.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace SalesAscii.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IDBConnector _db;
        public AccountsController(IDBConnector db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _db.ExecuteQuery("get_all_users_data");
            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{scode}")]
        public async Task<IActionResult> GetDoctorData(int scode)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(scode), scode.ToString());
            var result = await _db.ExecuteQuery("get_doctor_data_for_call", param);

            return Ok(new ServiceResponse(result));
        }

        // validate login data
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.uname), Value = model.uname });
                param.Add(new SqlParameter { ParameterName = nameof(model.upass), Value = model.upass });

                var result = await _db.ExecuteNonQuery("validate_login_data", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }
 
    }
}
