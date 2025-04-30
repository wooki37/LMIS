using LMIS.Shared.Models.Common;
using LMIS.Shared.Models.WMS.DTO.Request;
using LMIS.WMS.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LMIS.WMS.Controllers
{
    /// <summary>
    /// 입고 생성 API
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "WMS")]
    public class InboundController : ControllerBase
    {
        private readonly IInboundService _service;
        public InboundController(IInboundService service)
        {
            _service = service;
        }
        /// <summary>
        /// 입고 생성
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateInbound([FromBody] CreateInboundRequest request)
        {
            var inboundID = await _service.CreateAsync(request);
            return Ok(new ApiResponse<string>
            {
                Success = true,
                Message = "입고가 생성되었습니다.",
                Data = inboundID
            });
        }
    }
}
