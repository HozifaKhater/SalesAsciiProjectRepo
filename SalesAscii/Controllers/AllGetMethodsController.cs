using DAL.Helpers;
using DAL.Infrastrucre;
using DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace SalesAscii.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AllGetMethodsController : ControllerBase
    {
        private readonly IDBConnector _db;
        public AllGetMethodsController(IDBConnector db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> getAllDeletedDocs()
        {
            var result = await _db.ExecuteQuery("get_all_deleted_docs");
            return Ok(new ServiceResponse(result));
        }


        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> getAllEmps(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_all_emps", param);
            return Ok(new ServiceResponse(result));
        }


        [HttpGet]
        public async Task<IActionResult> getAllNewDocs()
        {
            var result = await _db.ExecuteQuery("get_all_new_docs");
            return Ok(new ServiceResponse(result));
        }
        [HttpGet]
        public async Task<IActionResult> getAssigningDocsData()
        {
            var result = await _db.ExecuteQuery("get_assigning_docs_data");
            return Ok(new ServiceResponse(result));
        }
        [HttpGet]
        public async Task<IActionResult> getBunitsLinesData()
        {
            var result = await _db.ExecuteQuery("get_bunits_lines_data");
            return Ok(new ServiceResponse(result));
        }
        [HttpGet]
        public async Task<IActionResult> GetCallDetailReportData([FromQuery] getCallDetailReportDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new Dictionary<string, string>();
                param.Add(nameof(model.master_visit_code1), model.master_visit_code1.ToString());
                param.Add(nameof(model.master_visit_code), model.master_visit_code.ToString());

                var result = await _db.ExecuteQuery("get_call_detail_report_data",param);
                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());
        }



        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> getClassCoverageReportData(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_class_coverage_report_data", param);
            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> getClassVisitedReportData(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_class_visited_report_data", param);
            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> getCommentesBuCount(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_commentes_bu_count", param);
            return Ok(new ServiceResponse(result));
        }


        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> getCommentesProductCount(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_commentes_product_count", param);
            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> getCommentesReportCount(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_commentes_report_count", param);
            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> getCommentesReportData(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_commentes_report_data", param);
            return Ok(new ServiceResponse(result));
        }
        [HttpGet]
        public async Task<IActionResult> getCoverageReportData([FromQuery] getCallDetailReportDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new Dictionary<string, string>();
                param.Add(nameof(model.master_visit_code1), model.master_visit_code1.ToString());
                param.Add(nameof(model.master_visit_code), model.master_visit_code.ToString());
                var result = await _db.ExecuteQuery("get_coverage_report_data",param);
                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());

        }

        [HttpGet]
        public async Task<IActionResult> getDocDataForUpdate()
        {
            var result = await _db.ExecuteQuery("get_doc_data_for_update");
            return Ok(new ServiceResponse(result));
        }
        [HttpGet]
        public async Task<IActionResult> getlinesEmpData()
        {
            var result = await _db.ExecuteQuery("get_lines_emp_data");
            return Ok(new ServiceResponse(result));
        }


        [HttpGet]
        public async Task<IActionResult> getLinesProductData()
        {
            var result = await _db.ExecuteQuery("get_lines_product_data");
            return Ok(new ServiceResponse(result));
        }


        [HttpGet]
        public async Task<IActionResult> getLocationDefData()
        {
            var result = await _db.ExecuteQuery("get_location_def_data");
            return Ok(new ServiceResponse(result));
        }

        [HttpGet]
        public async Task<IActionResult> getPromotionReportCountData([FromQuery] getPromotionReportCountDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new Dictionary<string, string>();
                param.Add(nameof(model.promo_code), model.promo_code.ToString());
                param.Add(nameof(model.master_visit_code), model.master_visit_code.ToString());
                var result = await _db.ExecuteQuery("get_promotion_report_count_data", param);
                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());

        }



        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> getPromotionReportData(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_promotion_report_data", param);
            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{saleman_code}")]
        public async Task<IActionResult> getSalesDocList(decimal saleman_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(saleman_code), saleman_code.ToString());
            var result = await _db.ExecuteQuery("get_sales_doc_list", param);
            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{saleman_code}")]
        public async Task<IActionResult> getSalesTargetList(decimal saleman_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(saleman_code), saleman_code.ToString());
            var result = await _db.ExecuteQuery("get_sales_target_list", param);
            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{saleman_code}")]
        public async Task<IActionResult> getSalesUnvisitedDocs(decimal saleman_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(saleman_code), saleman_code.ToString());
            var result = await _db.ExecuteQuery("get_sales_unvisited_docs", param);
            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{saleman_code}")]
        public async Task<IActionResult> getSalesUnvisitedList(decimal saleman_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(saleman_code), saleman_code.ToString());
            var result = await _db.ExecuteQuery("get_sales_unvisited_list", param);
            return Ok(new ServiceResponse(result));
        }
        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> getSpecialityCoverageReportData(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_speciality_coverage_report_data", param);
            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{master_visit_code}")]
        public async Task<IActionResult> getSpecialityVisitedReportData(decimal master_visit_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(master_visit_code), master_visit_code.ToString());
            var result = await _db.ExecuteQuery("get_speciality_visited_report_data", param);
            return Ok(new ServiceResponse(result));
        }
        [HttpGet]
        public async Task<IActionResult> getTargetDetailData()
        {
            var result = await _db.ExecuteQuery("get_target_detail_data");
            return Ok(new ServiceResponse(result));
        }
        [HttpGet("{saleman_code}")]
        public async Task<IActionResult> getTargetDetailData1(decimal saleman_code)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(saleman_code), saleman_code.ToString());
            var result = await _db.ExecuteQuery("get_target_detail_data1",param);
            return Ok(new ServiceResponse(result));
        }

        [HttpGet]
        public async Task<IActionResult> getTypeOfCategory()
        {
            var result = await _db.ExecuteQuery("get_type_of_category");
            return Ok(new ServiceResponse(result));
        }

        [HttpGet("{stype}")]
        public async Task<IActionResult> getTypeOfPlaces(string stype)
        {
            var param = new Dictionary<string, string>();
            param.Add(nameof(stype), stype);
            var result = await _db.ExecuteQuery("get_type_of_places", param);
            return Ok(new ServiceResponse(result));
        }



        [HttpGet]
        public async Task<IActionResult> getVisitedReportData([FromQuery] getCallDetailReportDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new Dictionary<string, string>();
                param.Add(nameof(model.master_visit_code1), model.master_visit_code1.ToString());
                param.Add(nameof(model.master_visit_code), model.master_visit_code.ToString());
                var result = await _db.ExecuteQuery("get_visited_report_data", param);
                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());

        }
        [HttpGet]
        public async Task<IActionResult> getVisitedReportDataByvisit([FromQuery] getCallDetailReportDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var param = new Dictionary<string, string>();
                param.Add(nameof(model.master_visit_code1), model.master_visit_code1.ToString());
                param.Add(nameof(model.master_visit_code), model.master_visit_code.ToString());
                var result = await _db.ExecuteQuery("get_visited_report_data_byvisit", param);
                return Ok(new ServiceResponse(result));
            }
            return Ok(new ServiceResponse());

        }
    }
}
