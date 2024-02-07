using Microsoft.AspNetCore.Mvc;
using BlazingShop.Server.Services.PaymentService;
using BlazingShop.Shared;

namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {

        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("checkout")]
        public ActionResult<int> CreateCheckoutSession(List<CartItem> cartItems)
        {
            var session = _paymentService.CreateCheckoutSession(cartItems);
            return Ok(session.Url);
        }




    }
}

