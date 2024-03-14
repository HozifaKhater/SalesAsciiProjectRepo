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
    public class DoctorsPageController : ControllerBase
    {
        private readonly IDBConnector _db;
        public DoctorsPageController(IDBConnector db)
        {
            _db = db;
        }
        // get user type
        [HttpGet("{ucode}")]
        public async Task<IActionResult> GetUesrType(decimal ucode)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(ucode), ucode.ToString());
            var result = await _db.ExecuteQuery("get_user_type",param);
            return Ok(new ServiceResponse(result));
        }


        //get def data
        [HttpGet("{scode}")]
        public async Task<IActionResult> GetDefData(string scode)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(scode), scode.ToString());
            var result = await _db.ExecuteQuery("get_def_data", param);

            return Ok(new ServiceResponse(result));
        }
        //fill places with type
        [HttpGet("{scode}")]
        public async Task<IActionResult> FillPlacesWithType(decimal scode)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(scode), scode.ToString());
            var result = await _db.ExecuteQuery("fill_places_with_type", param);

            return Ok(new ServiceResponse(result));
        }

        [HttpPost]
        public async Task<IActionResult> SaveNewDoctor([FromBody] SaveNewDoctorViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.name), Value = model.name });
                param.Add(new SqlParameter { ParameterName = nameof(model.address), Value = model.address });
                param.Add(new SqlParameter { ParameterName = nameof(model.tel1), Value = model.tel1 });
                param.Add(new SqlParameter { ParameterName = nameof(model.tel2), Value = model.tel2 });
                param.Add(new SqlParameter { ParameterName = nameof(model.type), Value = model.type });
                param.Add(new SqlParameter { ParameterName = nameof(model.Class), Value = model.Class });
                param.Add(new SqlParameter { ParameterName = nameof(model.spec), Value = model.spec });
                param.Add(new SqlParameter { ParameterName = nameof(model.branch), Value = model.branch });
                param.Add(new SqlParameter { ParameterName = nameof(model.emp_code), Value = model.emp_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.doc_codeing), Value = model.doc_codeing });
                param.Add(new SqlParameter { ParameterName = nameof(model.bunit), Value = model.bunit });
                var result = await _db.ExecuteNonQuery("save_new_doctor", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }


        [HttpGet]
        public async Task<IActionResult> GetDocSpeciality()
        {
            var result = await _db.ExecuteQuery("get_speciality");
            return Ok(new ServiceResponse(result));
        }

    }
}
