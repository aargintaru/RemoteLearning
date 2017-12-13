using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ProductCollection
    {
        private List<Product> products;

        public ProductCollection()
        {
            this.products = new List<Product>();
        }

        public void AddProduct(Product p)
        {
            if (this.products.Any(prod => prod.Name == p.Name) == true)
            {
                var inList = this.products.FirstOrDefault(prod => prod.Name == p.Name);
                if (inList != null)
                {
                    inList.Price = p.Price;
                }
            }
        }
    }
}
