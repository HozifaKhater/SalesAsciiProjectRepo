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
    public class CallsPlanController : ControllerBase
    {
        private readonly IDBConnector _db;
        public CallsPlanController(IDBConnector db)
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



        [HttpGet("{saleman_code}")]
        public async Task<IActionResult> GetSalesDocList(decimal saleman_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(saleman_code), saleman_code.ToString());
            var result = await _db.ExecuteQuery("get_sales_doc_list", param);

            return Ok(new ServiceResponse(result));
        
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSalesDocList([FromBody] UpdateSalesDocListViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.saleman_code), Value = model.saleman_code });

                param.Add(new SqlParameter { ParameterName = nameof(model.thedate), Value = model.thedate });
                param.Add(new SqlParameter { ParameterName = nameof(model.serial), Value = model.serial });

                var result = await _db.ExecuteNonQuery("update_sales_doc_list", param);

                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());
        }

        [HttpPost]
        public async Task<IActionResult> SaveInDeletedDocs([FromBody] SaveInDeletedDocsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.emp_code), Value = model.emp_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.doc_code), Value = model.doc_code });
         
                var result = await _db.ExecuteNonQuery("save_in_deleted_docs", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTargetState([FromBody] UpdateTargetStateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.emp_code), Value = model.emp_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.doc_code), Value = model.doc_code });

                var result = await _db.ExecuteNonQuery("update_target_states", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }

        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> GetCurrentCallDetails(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_current_call_details", param);

            return Ok(new ServiceResponse(result));

        }

        [HttpPost]
        public async Task<IActionResult> SaveAnotherCallDetaile([FromBody] SaveAnotherCallDetail model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.myser), Value = model.myser });
                param.Add(new SqlParameter { ParameterName = nameof(model.product_notes), Value = model.product_notes });
                param.Add(new SqlParameter { ParameterName = nameof(model.product_code), Value = model.product_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.product_feed), Value = model.product_feed });
                param.Add(new SqlParameter { ParameterName = nameof(model.p1), Value = model.p1 });
                param.Add(new SqlParameter { ParameterName = nameof(model.p1_count), Value = model.p1_count });
                param.Add(new SqlParameter { ParameterName = nameof(model.p2), Value = model.p2 });
                param.Add(new SqlParameter { ParameterName = nameof(model.p2_count), Value = model.p2_count });
                var result = await _db.ExecuteNonQuery("save_another_call_detail", param);

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
