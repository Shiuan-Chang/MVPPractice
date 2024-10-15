using MVPPractice.Contracts;
using MVPPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPractice.Presenters
{
    //負責商業邏輯處理,為model和view之間的橋梁
    public class ProductPresenter : IProductPresenter
    {
        private readonly IProductView _view;
        private readonly IProductRepository _repository;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            _view = view;
            _repository = repository;
        }

        public void LoadProductData()
        {
            var product = _repository.GetProduct();
            _view.DisplayProductInfo(product.Name, product.Size, product.Price);
        }



    }
}
