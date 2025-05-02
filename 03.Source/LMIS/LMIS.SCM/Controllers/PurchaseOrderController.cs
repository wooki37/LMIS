using LMIS.SCM.Services.Interface;
using LMIS.Shared.Models.Common;
using LMIS.Shared.Models.SCM.DTO.Request;
using Microsoft.AspNetCore.Mvc;

namespace LMIS.SCM.Controllers
{
    /// <summary>
    /// 발주주문정보 생성 API
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "SCM")]
    public class PurchaseOrderController : Controller
    {
        private readonly IPurchaseOrderService _service;

        public PurchaseOrderController(IPurchaseOrderService service)
        {
            _service = service;
        }

        /// <summary>
        /// 발주주문정보 생성
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreatePurchaseOrder([FromBody] CreatePurchaseOrderRequest request)
        {
            var purchaseOrderID = await _service.CreateAsync(request);
            return Ok(new ApiResponse<string>
            {
                Success = true,
                Message = "발주주문정보가 생성되었습니다.",
                Data = purchaseOrderID
            });
        }
    }
}
