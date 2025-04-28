using LMIS.Shared.Models.Common;
using LMIS.Shared.Models.TMS.DTO.Request;
using LMIS.TMS.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LMIS.TMS.Controllers
{
    /// <summary>
    /// 운송 요청 생성 API
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "TMS")]
    public class TransportRequestsController : ControllerBase
    {
        private readonly ITransportRequestsService _service;
        public TransportRequestsController(ITransportRequestsService service)
        {
            _service = service;
        }

        /// <summary>
        /// 운송 요청 생성
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateTransportRequest([FromBody] CreateTransportRequest request)
        {
            var transportRequestID = await _service.CreateAsync(request);
            return Ok(new ApiResponse<string>
            {
                Success = true,
                Message = "운송 요청이 생성되었습니다.",
                Data = transportRequestID
            });
        }
    }
}
