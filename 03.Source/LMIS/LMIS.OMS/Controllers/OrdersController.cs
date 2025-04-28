using Microsoft.AspNetCore.Mvc;
using LMIS.Shared.Models.OMS.DTO.Request;
using LMIS.Shared.Models.Common;
using LMIS.OMS.Services.Interface; // ApiResponse 위치

namespace LMIS.OMS.Controllers
{
    /// <summary>
    ///  주문 생성 API
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "OMS")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _service;
        public OrdersController(IOrdersService sercive)
        {
            _service = sercive;
        }

        /// <summary>
        /// 주문 생성.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest request)
        {
            var orderID = await _service.CreateAsync(request);
            return Ok(new ApiResponse<string>
            {
                Success = true,
                Message = "주문이 생성되었습니다.",
                Data = orderID
            });
        }
    }
}
