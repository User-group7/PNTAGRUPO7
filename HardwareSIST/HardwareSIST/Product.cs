using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HardwareSIST
{
    public class Product
    {
        public Product()
        {
        }

        //CONSTRUCTOR
        public Product(int productId, Category catId, String productName, String modelNo, String productDescription)
        {
            ProductId = productId;
            CatId = catId;
            ProductName = productName;
            ModelNo = modelNo;
            ProductDescription = productDescription;
        }

        public int ProductId { get; set; }
        public Category CatId { get; set; }
        public String ProductName { get; set; }
        public String ModelNo { get; set; }
        public String ProductDescription { get; set; }


        public String InfoProduct()
        {
            return "Nombre: " + ProductName +
                    "Id: " + ProductId;
        }
    }
}