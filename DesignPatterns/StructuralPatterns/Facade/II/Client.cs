using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Facade.II
{
    internal class Client
    {
        static ICartService cartService;
        static IProductService productService;
        static IPaymentService paymentService;

        public static void Execute()
        {

            var productIds = new[] {1, 2, 3, 4, 5 };

            /*foreach (var productId in productIds)
            {
                var price = productService.GetPrice(productId);
                cartService.AddProduct(productId, price);
            }
            paymentService.Pay(cartService.GetId(), cartService.GetValue());*/

            var shop = new Facade(cartService, productService, paymentService);
            shop.Buy(productIds);
        }
    }
}
