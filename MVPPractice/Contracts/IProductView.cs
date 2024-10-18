using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPractice.Contracts
    // Contract: 定義做到那些事情並列出來做統整
{
    //使用介面來定義 View 和 Presenter 之間的溝通
    public interface IProductView
    {
        // 顯示商品資訊
        void DisplayProductInfo(string name, string size, decimal price);
    }

    //定義presenter必須要有的作法
    public interface IProductPresenter
    {
        void LoadProductData();
    }
}
