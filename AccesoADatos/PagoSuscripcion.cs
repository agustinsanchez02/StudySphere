using System;
using System.Threading.Tasks;
using MercadoPago.Client.Payment;
using MercadoPago.Config;
using MercadoPago.Resource.Payment;



namespace AccesoADatos
{
    
    public class PagoSuscripcion
    {
        public async Task pagarAsync()
        {
            MercadoPagoConfig.AccessToken = "APP_USR-499927899085749-062523-3db7ffcf2e837d3c155a413246dc387b-239307515";
            var request = new PaymentCreateRequest
            {
                TransactionAmount = 10,
                Token = "CARD_TOKEN",
                Description = "Payment description",
                Installments = 1,
                PaymentMethodId = "visa",
                Payer = new PaymentPayerRequest
                {
                    Email = "agusjcr2016@gmail.com",
                }
            };

            var client = new PaymentClient();
            Payment payment = await client.CreateAsync(request);

            Console.WriteLine($"Payment ID: {payment.Id}");
        }
    }
}
