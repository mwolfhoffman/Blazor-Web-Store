using Stripe;
using Stripe.Checkout;
using BlazingShop.Shared;
using Microsoft.Extensions.Configuration;

namespace BlazingShop.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {

        private readonly IConfiguration _configuration;


        public PaymentService(IConfiguration configuration)
        {
            _configuration = configuration;
            StripeConfiguration.ApiKey = _configuration["StripePrivateKey"];
        }
        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            cartItems.Select(x => x.ProductTitle).ToList().ForEach(Console.WriteLine);
            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(c => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = c.Price * 100,
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = c.ProductTitle,
                        Images = new List<string> { c.Image }
                    }
                },
                Quantity = c.Quantity
            }));

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },

                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = "localhost:5288/order-successful",
                CancelUrl = "localhost:5288/cart",
            };
            var service = new Stripe.Checkout.SessionService();
            Session session = service.Create(options);
            return session;
        }

    }
}