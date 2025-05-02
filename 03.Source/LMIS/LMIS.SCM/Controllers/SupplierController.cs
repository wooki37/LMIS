//using LMIS.SCM.Services.Interface;
using LMIS.SCM.Services.Interface;
using LMIS.Shared.Models.Common;
using LMIS.Shared.Models.SCM.DTO.Request;
using Microsoft.AspNetCore.Mvc;

namespace LMIS.SCM.Controllers
{
    /// <summary>
    /// 공급업체 등록 API
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "SCM")]
    public class SupplierController : Controller
    {
        private readonly ISupplierService _service;

        public SupplierController(ISupplierService service)
        {
            _service = service;
        }

        /// <summary>
        /// 공급업체등록
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateSupplier([FromBody] CreateSupplierRequest request)
        {
            var supplierID = await _service.CreateAsync(request);
            return Ok(new ApiResponse<string>
            {
                Success = true,
                Message = "공급업체가 등록되었습니다.",
                Data = supplierID
            });
        }
    }
}
