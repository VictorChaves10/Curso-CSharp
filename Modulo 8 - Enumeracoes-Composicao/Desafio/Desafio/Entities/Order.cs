using Desafio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Desafio.Entities
{
    internal class Order
    {
        public DateTime Moment{ get; set; }
        public OrderStatus Status;
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Client client = new Client(); 
        public Order() { }

        public Order(DateTime date, OrderStatus status, Client clt) 
        {       
            Moment = date;
            Status = status;
            client = clt;
        }

        public void AddItem(OrderItem orderItem) 
        {        
            Item.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            Item.Add(orderItem);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Item)
            {
             
               sum += item.Subtotal();

            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\nORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status.ToString()}");
            sb.AppendLine(client.ToString());
            sb.AppendLine($"Order items:");
            foreach (OrderItem order in Item)
            {
                sb.AppendLine(order.ToString());
            }
            sb.AppendLine($"Total price: ${Total().ToString("F2")}");

            return sb.ToString();

        }

    }

   
}
