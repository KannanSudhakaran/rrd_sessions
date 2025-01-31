using CollectionsApp.Models;
using System.Collections;

namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var basket = new ArrayList();
            

            basket.Add(new OrderItem(1, "Milk", 30, 3));
            basket.Add(new OrderItem(2, "Biscuit", 10, 3));
            basket.Add(new OrderItem(3, "Cashew", 100, 1));
            basket.Add(new OrderItem(4, "Rice", 500, 1));

            //basket.Add("Shalini");// no type safety
            //basket.Add(1000);

            PritnBasketDetails(basket);

        }

        private static void PritnBasketDetails(ArrayList basket)
        {
            double totolCost = 0;
            foreach(object item in basket)
            {
             
                OrderItem orderItem= (OrderItem) item;
                Console.WriteLine($"name is {orderItem.Name} quantiy {orderItem.Quanity}  price {orderItem.UnitPrice}, cost :{orderItem.LineItemCost}");
                totolCost += orderItem.LineItemCost;
            }

            Console.WriteLine("Amount to payed is :"+totolCost);
        }
    }
}
