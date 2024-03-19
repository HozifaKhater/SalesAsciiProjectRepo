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
    public class AllSaveMethodsController : ControllerBase
    {
        private readonly IDBConnector _db;
        public AllSaveMethodsController(IDBConnector db)
        {
            _db = db;

        }

        [HttpPost]
        public async Task<IActionResult> SaveBunitsLinesData([FromBody] saveBunitsLinesDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.bu), Value = model.bu });
                param.Add(new SqlParameter { ParameterName = nameof(model.line), Value = model.line });
                param.Add(new SqlParameter { ParameterName = nameof(model.state), Value = model.state });
          
                var result = await _db.ExecuteNonQuery("save_bunits_lines_data", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }
        [HttpPost]
        public async Task<IActionResult> SaveDefData([FromBody] SaveDefDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.scode), Value = model.scode });
                param.Add(new SqlParameter { ParameterName = nameof(model.sname), Value = model.sname });

                var result = await _db.ExecuteNonQuery("save_def_data", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }
        [HttpPost]
        public async Task<IActionResult> SaveEmpNewPassword([FromBody] SaveEmpNewPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.emp_code), Value = model.emp_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.old_pass), Value = model.old_pass });
                param.Add(new SqlParameter { ParameterName = nameof(model.new_pass), Value = model.new_pass });
                param.Add(new SqlParameter { ParameterName = nameof(model.conf_pass), Value = model.conf_pass });

                var result = await _db.ExecuteNonQuery("save_emp_new_password", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }

        [HttpPost]
        public async Task<IActionResult> SaveLinesEmpData([FromBody] saveBunitsLinesDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.bu), Value = model.bu });
                param.Add(new SqlParameter { ParameterName = nameof(model.line), Value = model.line });
                param.Add(new SqlParameter { ParameterName = nameof(model.state), Value = model.state });
                var result = await _db.ExecuteNonQuery("save_lines_emp_data", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }


        [HttpPost]
        public async Task<IActionResult> SaveLinesProductData([FromBody] saveBunitsLinesDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.bu), Value = model.bu });
                param.Add(new SqlParameter { ParameterName = nameof(model.line), Value = model.line });
                param.Add(new SqlParameter { ParameterName = nameof(model.state), Value = model.state });
                var result = await _db.ExecuteNonQuery("save_lines_product_data", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }

        [HttpPost]
        public async Task<IActionResult> SaveLocationDefData([FromBody] updateLocationDefDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();

                param.Add(new SqlParameter { ParameterName = nameof(model.sname), Value = model.sname });
                param.Add(new SqlParameter { ParameterName = nameof(model.dparent), Value = model.dparent });

                param.Add(new SqlParameter { ParameterName = nameof(model.desc), Value = model.desc });
                var result = await _db.ExecuteNonQuery("save_location_def_data", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }


        [HttpPost]
        public async Task<IActionResult> SaveLocationsDocData([FromBody] SaveLocationsDocDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.bu), Value = model.bu });
                param.Add(new SqlParameter { ParameterName = nameof(model.line), Value = model.line });
                param.Add(new SqlParameter { ParameterName = nameof(model.state), Value = model.state });
                param.Add(new SqlParameter { ParameterName = nameof(model.ser), Value = model.ser });
                param.Add(new SqlParameter { ParameterName = nameof(model.saved_place), Value = model.saved_place });
                var result = await _db.ExecuteNonQuery("save_locations_doc_data", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }




        [HttpPost]
        public async Task<IActionResult> SaveNewEmployee([FromBody] SaveNewEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.name), Value = model.name });
                param.Add(new SqlParameter { ParameterName = nameof(model.pass), Value = model.pass });
                param.Add(new SqlParameter { ParameterName = nameof(model.Class), Value = model.Class });
                param.Add(new SqlParameter { ParameterName = nameof(model.emp_code), Value = model.emp_code });
                param.Add(new SqlParameter { ParameterName = nameof(model.tel1), Value = model.tel1 });
                param.Add(new SqlParameter { ParameterName = nameof(model.tel2), Value = model.tel2 });
                param.Add(new SqlParameter { ParameterName = nameof(model.address), Value = model.address });
                param.Add(new SqlParameter { ParameterName = nameof(model.type), Value = model.type });
                param.Add(new SqlParameter { ParameterName = nameof(model.umane), Value = model.umane });
                var result = await _db.ExecuteNonQuery("save_new_employee", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }
        


        [HttpPost]
        public async Task<IActionResult> SaveProductDefData([FromBody] updateProductDefDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter { ParameterName = nameof(model.sname), Value = model.sname });

                param.Add(new SqlParameter { ParameterName = nameof(model.desc), Value = model.desc });

                param.Add(new SqlParameter { ParameterName = nameof(model.scode), Value = model.scode });
                var result = await _db.ExecuteNonQuery("save_product_def_data", param);

                return Ok(new ServiceResponse(result));
            }

            return Ok(new ServiceResponse());
        }
    }
}
