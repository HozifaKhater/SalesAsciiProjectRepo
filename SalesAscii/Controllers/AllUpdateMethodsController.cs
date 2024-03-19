using DAL.Helpers;
using DAL.Infrastrucre;
using DAL.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Reflection;

namespace SalesAscii.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AllUpdateMethodsController : ControllerBase
    {
        private readonly IDBConnector _db;
        public AllUpdateMethodsController(IDBConnector db)
        {
            _db = db;

        }
        [HttpPut]
        public async Task<IActionResult> updateDefData([FromBody] updateDefDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.scode), Value = model.scode });

                param.Add(new SqlParameter { ParameterName = nameof(model.sname), Value = model.sname });
                param.Add(new SqlParameter { ParameterName = nameof(model.code), Value = model.code });

                var result = await _db.ExecuteNonQuery("update_def_data", param);

                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());
        }


        [HttpPut]
        public async Task<IActionResult> updateDoctorsClassDefData([FromBody] updateDoctorsClassDefDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.class_code), Value = model.class_code });

                param.Add(new SqlParameter { ParameterName = nameof(model.doc_code), Value = model.doc_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.y), Value = model.y });

                var result = await _db.ExecuteNonQuery("update_doctors_class_def_data", param);

                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());
        }
        

            [HttpPut]
        public async Task<IActionResult> updateInDeletedDocs([FromBody] UpdateTargetStateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.emp_code), Value = model.emp_code });

                param.Add(new SqlParameter { ParameterName = nameof(model.doc_code), Value = model.doc_code });

                var result = await _db.ExecuteNonQuery("update_in_deleted_docs", param);

                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());
        }


        [HttpPut]
        public async Task<IActionResult> updateInNewDocs([FromHeader] decimal doc_code)
        {
            if (doc_code != null)
            {
                var param = new List<SqlParameter>();

                param.Add(new SqlParameter { ParameterName = nameof(doc_code), Value = doc_code });
                var result = await _db.ExecuteNonQuery("update_in_new_docs", param);

                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());
        }


        [HttpPut]
        public async Task<IActionResult> updateLocationDefData([FromBody] updateLocationDefDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();

                param.Add(new SqlParameter { ParameterName = nameof(model.sname), Value = model.sname });
                param.Add(new SqlParameter { ParameterName = nameof(model.dparent), Value = model.dparent });

                param.Add(new SqlParameter { ParameterName = nameof(model.desc), Value = model.desc });

                param.Add(new SqlParameter { ParameterName = nameof(model.code), Value = model.code });

                var result = await _db.ExecuteNonQuery("update_location_def_data", param);

                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());
        }


        [HttpPut]
        public async Task<IActionResult> updateProductDefData([FromBody] updateProductDefDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();

                param.Add(new SqlParameter { ParameterName = nameof(model.sname), Value = model.sname });
                param.Add(new SqlParameter { ParameterName = nameof(model.code), Value = model.code });

                param.Add(new SqlParameter { ParameterName = nameof(model.desc), Value = model.desc });

                param.Add(new SqlParameter { ParameterName = nameof(model.scode), Value = model.scode });

                var result = await _db.ExecuteNonQuery("update_product_def_data", param);

                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());
        }


        [HttpPut]
        public async Task<IActionResult> updateUserAndPass([FromBody] updateLocationDefDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();

                param.Add(new SqlParameter { ParameterName = nameof(model.sname), Value = model.sname });
                param.Add(new SqlParameter { ParameterName = nameof(model.desc), Value = model.desc });
                param.Add(new SqlParameter { ParameterName = nameof(model.code), Value = model.code });
                var result = await _db.ExecuteNonQuery("update_users_and_pass", param);
                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());
        }
    }
}
