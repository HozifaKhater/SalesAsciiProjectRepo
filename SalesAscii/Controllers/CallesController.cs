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
    public class CallesController : ControllerBase
    {
        private readonly IDBConnector _db;
        public CallesController(IDBConnector db)
        {
            _db = db;

        }
        [HttpGet("{ucode}")]
        public async Task<IActionResult> GetUesrType(decimal ucode)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(ucode), ucode.ToString());
            var result = await _db.ExecuteQuery("get_user_type",param);
            return Ok(new ServiceResponse(result));
        }
        [HttpGet("{scode}")]
        public async Task<IActionResult> GetDoctorDataForCall(decimal scode)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(scode), scode.ToString());
            var result = await _db.ExecuteQuery("get_doctor_data_for_call",param);
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
        [HttpPost]
        public async Task<IActionResult> GetDefData1([FromBody] GetDefData1ViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.scode), Value = model.scode });
                param.Add(new SqlParameter { ParameterName = nameof(model.user_code), Value = model.user_code });

                var result = await _db.ExecuteNonQuery("get_def_data1", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }

        [HttpGet("{saleman_code}")]
        public async Task<IActionResult> GetSalesDocList(decimal saleman_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(saleman_code), saleman_code.ToString());
            var result = await _db.ExecuteQuery("get_sales_doc_list", param);

            return Ok(new ServiceResponse(result));

        }

        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> GetAllManagers(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_all_managers", param);

            return Ok(new ServiceResponse(result));
        }


        [HttpPost]
        public async Task<IActionResult> SaveCallMasterDetails([FromBody] SaveCallMasterDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.emp_code), Value = model.emp_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.doc_code), Value = model.doc_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.call_date), Value = model.call_date });
                param.Add(new SqlParameter { ParameterName = nameof(model.g_notes), Value = model.g_notes });
                param.Add(new SqlParameter { ParameterName = nameof(model.bu_feed), Value = model.bu_feed });
                param.Add(new SqlParameter { ParameterName = nameof(model.product_code), Value = model.product_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.product_notes), Value = model.product_notes });
                param.Add(new SqlParameter { ParameterName = nameof(model.product_feed), Value = model.product_feed });
                param.Add(new SqlParameter { ParameterName = nameof(model.p1), Value = model.p1 });
                param.Add(new SqlParameter { ParameterName = nameof(model.p1_count), Value = model.p1_count });
                param.Add(new SqlParameter { ParameterName = nameof(model.p2), Value = model.p2 });
                param.Add(new SqlParameter { ParameterName = nameof(model.p2_count), Value = model.p2_count });
                param.Add(new SqlParameter { ParameterName = nameof(model.visit_type), Value = model.visit_type });
                param.Add(new SqlParameter { ParameterName = nameof(model.who_with), Value = model.who_with });
                param.Add(new SqlParameter { ParameterName = nameof(model.NA), Value = model.NA });
                param.Add(new SqlParameter { ParameterName = nameof(model.p1_notes), Value = model.p1_notes });
                param.Add(new SqlParameter { ParameterName = nameof(model.p2_notes), Value = model.p2_notes });
                var result = await _db.ExecuteNonQuery("save_call_master_detail", param);

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
        [HttpGet]
        public async Task<IActionResult> GetAllPromotions()
        {
            
            var result = await _db.ExecuteQuery("get_all_promotion");
            return Ok(new ServiceResponse(result));
        }
    }
}
