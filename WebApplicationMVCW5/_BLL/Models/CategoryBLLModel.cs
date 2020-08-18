using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVCW5._BLL.Models
{
    public class CategoryBLLModel
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }


    public class ProductBLLModel
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
    }
}
