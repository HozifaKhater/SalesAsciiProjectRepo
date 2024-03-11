using DAL.Helpers;
using DAL.Infrastrucre;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalesAscii.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomePageController : ControllerBase
    {
        private readonly IDBConnector _db;
        public HomePageController(IDBConnector db)
        {
            _db = db;
        }
        //Get Dashboard Data
        [HttpGet("{saleman_code}")]
        public async Task<IActionResult> GetDashboardData(decimal saleman_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(saleman_code), saleman_code.ToString());
            var result = await _db.ExecuteQuery("get_dashboard_data", param);

            return Ok(new ServiceResponse(result));
        }

        //Get Sales Todaye Doc List Data
        [HttpGet("{saleman_code}")]
        public async Task<IActionResult> GetSalesTodaydDocList(decimal saleman_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(saleman_code), saleman_code.ToString());
            var result = await _db.ExecuteQuery("get_sales_today_doc_list", param);

            return Ok(new ServiceResponse(result));
        }
    }
}
