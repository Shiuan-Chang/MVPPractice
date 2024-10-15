using MVPPractice.Contracts;
using MVPPractice.Models;
using MVPPractice.Presenters;

namespace MVPPractice
{
    public partial class Form1 : Form, IProductView
    {
        private readonly IProductPresenter _presenter;
        public Form1()
        {
            InitializeComponent();
            IProductRepository repository = new ProductRepository();
            _presenter = new ProductPresenter(this, repository);
            _presenter.LoadProductData();
        }

        public void DisplayProductInfo(string name, string size, decimal price)
        {
            BrandName.Text = name;
            Size.Text = size;
            Price.Text = $"${price}";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Content_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
