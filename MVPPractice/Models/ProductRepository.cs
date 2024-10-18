using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPractice.Models
{
    internal class ProductRepository
    {
        public Product GetProduct()
        {
            // 假設這裡用 Web API 拿到商品資料
            return new Product
            {
                Name = "Google Pixel 3",
                Size = "5.5吋螢幕",
                Price = 27000,
            };
        }
    }
}
