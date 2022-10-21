using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSIST
{
    class ProductRepostory
    {
        public ProductRepostory(String name)
        {
            Name = name;
            ListProducts = new List<Product>();
        }
        public String Name { get; set; }
        public List<Product> ListProducts;

        public void addProduct(Product product)
        {
            ListProducts.Add(product);
        }

        public void showProducts()
        {
            for(int i = 0; i < ListProducts.Count(); i++)
            {
                Console.WriteLine(ListProducts[i].InfoProduct());
            }
        }
    }
}
