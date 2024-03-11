using System.Collections.Generic;

namespace PizzaOrderingApp.Models
{
    public class OrderViewModel
    {
       
        public User? User { get; set; }

        
        public List<Product> Products { get; set; } = new List<Product>();
    }

}
