//using Microsoft.AspNetCore.Mvc;

//namespace LMIS.OMS.Controllers
//{
//    /// <summary>
//    ///  주문 관리 API
//    /// </summary>
//    [ApiController]
//    [Route("api/orders")]
//    [ApiExplorerSettings(GroupName = "OMS")]
//    public class OrdersController : ControllerBase
//    {
//        private readonly ILogger<OrdersController> _logger;
//        public OrdersController(ILogger<OrdersController> logger)
//        {
//            _logger = logger;
//        }

//        /// <summary>
//        /// 주문 목록을 조회합니다.
//        /// </summary>
//        [HttpGet]
//        public IEnumerable<OrderDto> Get()
//        {
//            return Enumerable.Range(1, 5).Select(i => new OrderDto
//            {
//                OrderID = i,
//                CustomerName = $"Customer {index}",
//                OrderDate = DateTime.Now.AddDays(-index),
//                TotalAmount = Random.Shared.Next(100, 1000)
//            })
//        }
//    }
//}
