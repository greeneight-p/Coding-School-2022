using CoffeeShop.EntityFrameWork;
using CoffeeShop.EntityFrameWork.Repositories;
using CoffeeShop.Model;

namespace Session_15 {
    public partial class CoffeeShop : Form {
        public CoffeeShop() {
            InitializeComponent();
        }

        private void CoffeeShop_Load(object sender, EventArgs e) {

            //var cp = new CustomerRepo();
            //var customer = new Customer()
            //{
            //    Code ="001",
            //    Description ="Retail Customer",
               
                
            //};
            //cp.Create(customer);

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e) {
            var customersForm = new CustomersForm();
            customersForm.ShowDialog();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e) {
            var productCategoriesForm = new ProductCategoriesForm();
            productCategoriesForm.ShowDialog();
        }
    }
}