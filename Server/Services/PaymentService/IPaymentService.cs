using Stripe.Checkout;
using BlazingShop.Shared;

namespace BlazingShop.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Session CreateCheckoutSession(List<CartItem> cartItems);
    }
}