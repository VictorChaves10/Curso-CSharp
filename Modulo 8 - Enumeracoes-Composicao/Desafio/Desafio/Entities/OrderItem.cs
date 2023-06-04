using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Entities
{
    internal class OrderItem
    {
        public Product product { get; set; } = new Product();
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem() { }

        public OrderItem(Product prod, int quantity)
        {
            product = prod;
            Quantity = quantity;
            Price = product.Price;
        }

        public double Subtotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
          
            return $"{product.Name}, {Price.ToString("F2")}, Quantity: {Quantity}, Subtotal: ${Subtotal().ToString("F2")}";
   
        }
            
    }
}
