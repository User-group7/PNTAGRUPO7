using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace HardwareSIST
{
    public class Category
    {
        //CONSTRUCTOR
        public Category(String catId, String catName)
        {
            CatId = catId;
             if (validate(catName)){
                CatName = catName;
            }
            

        }

        public String CatId { get; set; }
        public String CatName { get; set; }
       
        private Boolean validate(String catId)
        {
            Boolean validName = false;

            if(catId != "")
            {
                validName = true;
            }

            return validName;

        }
    }
}