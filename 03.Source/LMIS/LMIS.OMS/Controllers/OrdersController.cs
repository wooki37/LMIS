using Microsoft.AspNetCore.Mvc;
using LMIS.Shared.Models.OMS.DTO.Request;
using LMIS.Shared.Models.Common; // ApiResponse 위치

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
        private readonly ILogger<OrdersController> _logger;
        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 주문 생성.
        /// </summary>
        [HttpPost]
        public IActionResult CreateOrder([FromBody] CreateOrderRequest request)
        {
            return Ok(new ApiResponse<string>
            {
                Success = true,
                Message = "주문이 생성되었습니다.",
                Data = "ORD123456"
            });
        }
    }
}
