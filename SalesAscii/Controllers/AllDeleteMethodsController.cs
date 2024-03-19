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
    public class AllDeleteMethodsController : ControllerBase
    {
        private readonly IDBConnector _db;
        public AllDeleteMethodsController(IDBConnector db)
        {
            _db = db;
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteDefData([FromBody] DeleteDefDataViewModel model)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(model.scode), Value = model.scode });
            param.Add(new SqlParameter { ParameterName = nameof(model.code), Value = model.code });

            var result = await _db.ExecuteNonQuery("delete_def_data", param);

            return Ok(new ServiceResponse(result));
        }



        [HttpDelete]
        public async Task<IActionResult> DeleteInDeletedDocs([FromBody] DeleteInDeletedDocsViewModel model)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(model.emp_code), Value = model.emp_code });
            param.Add(new SqlParameter { ParameterName = nameof(model.doc_code), Value = model.doc_code });

            var result = await _db.ExecuteNonQuery("delete_in_deleted_docs", param);

            return Ok(new ServiceResponse(result));
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteLocationDefData([FromHeader] decimal code)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(code), Value = code });

            var result = await _db.ExecuteNonQuery("delete_location_def_data", param);

            return Ok(new ServiceResponse(result));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductDefData([FromBody] DeleteDefDataViewModel model)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(model.scode), Value = model.scode });
            param.Add(new SqlParameter { ParameterName = nameof(model.code), Value = model.code });

            var result = await _db.ExecuteNonQuery("delete_product_def_data", param);

            return Ok(new ServiceResponse(result));
        }
    }
}
