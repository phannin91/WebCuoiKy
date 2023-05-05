using System.Collections.Generic;
using WebCuoiKy.Models;

namespace WebCuoiKy.ModelViews
{
    public class ProductHomeVM
    {
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }
    }
}
