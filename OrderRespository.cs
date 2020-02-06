using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBIZ
{
    public class OrderRepository
    {
            public Order Retrieve(int orderId)
            {
                Order order = new Order(orderId);

                return order;
            }

            public OrderDisplay RetrieveOrderDisplay(int orderId)
            {
                OrderDisplay orderDisplay = new OrderDisplay();

                var addressRepository = new AddressRepository();

                if (orderId == 10)
                {
                    orderDisplay.FirstName = "William";
                    orderDisplay.LastName = "Smith";
                    orderDisplay.OrderDate = new DateTimeOffset(2017, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                    orderDisplay.ShippingAddress = addressRepository.Retrieve(1);
                }

                orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

                if (orderId == 10)
                {
                    var orderDisplayItem = new OrderDisplayItem()
                    {
                        ProductName = "Mouse",
                        PurchasePrice = 14.93M,
                        OrderQuantity = 2
                    };
                    orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

                    orderDisplayItem = new OrderDisplayItem()
                    {
                        ProductName = "USB Drive",
                        PurchasePrice = 8M,
                        OrderQuantity = 1
                    };
                    orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
                }
                return orderDisplay;
            }

            public bool Save(Order order)
            {
                return true;
            }
        }
    }
