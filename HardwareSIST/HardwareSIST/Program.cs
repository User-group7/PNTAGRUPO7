using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSIST
{
    class Program
    {

        static void Main(string[] args)
        {
            //creo la primer categoría
            Category category1 = new Category("C1-LAP", "LAPTOPS");
            Product product1 = new Product(001, category1, "LaptopEjemplo", "Modelo1", "LaptopDeEjemploD");
            Product product2 = new Product(002, category1, "LaptopEjemplo2", "Modelo2", "LaptopDeEjemploD");

            ProductRepostory entregados = new ProductRepostory("entregados");
            entregados.addProduct(product1);

            ProductRepostory recibidos = new ProductRepostory("recibidos");
            recibidos.addProduct(product2);
            //creo una lista de productos
            //List<Product> ListaProducts = new List<Product>()
            //{
            //  new Product(001, category1, "LaptopEjemplo", "Modelo1", "LaptopDeEjemploD"),
            // new Product(002, category1, "LaptopEjemplo2", "Modelo2", "LaptopDeEjemploD")
            //};
            recibidos.showProducts();
        
        }
    }
}
