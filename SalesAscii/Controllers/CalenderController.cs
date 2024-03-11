using DAL.Helpers;
using DAL.Infrastrucre;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalesAscii.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalenderController : ControllerBase
    {

 
        private readonly IDBConnector _db;
        public CalenderController(IDBConnector db)
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

        [HttpGet("{saleman_code}")]
        public async Task<IActionResult> GetSalesMonthDocList(decimal saleman_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(saleman_code), saleman_code.ToString());
            var result = await _db.ExecuteQuery("get_sales_month_doc_list", param);
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
