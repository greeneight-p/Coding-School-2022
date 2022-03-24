using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoffeeShop.EntityFrameWork.Repositories;
using CoffeeShop.Model;

namespace Session_15 {
    public partial class ProductsForm : Form {

        public ProductRepo ProductRepo { get; set; } = new ProductRepo();
        public ProductsForm() {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e) {

            bsProducts.DataSource = ProductRepo.GetAll();
            grdProducts.DataSource = bsProducts;

        }

        private void btnNew_Click(object sender, EventArgs e) {
           
            var pdForm = new ProductDetailsForm(null, false);
            pdForm.ShowDialog();

            bsProducts.DataSource = ProductRepo.GetAll();
            grvProducs.RefreshData();

        }

        private void btnEdit_Click(object sender, EventArgs e) {

            var product = bsProducts.Current as Product;
            var pdForm = new ProductDetailsForm(product, true);
            pdForm.ShowDialog();

            bsProducts.DataSource = ProductRepo.GetAll();
            grvProducs.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var product = bsProducts.Current as Product;
            ProductRepo.Delete(product.ID);
            bsProducts.DataSource = ProductRepo.GetAll();
            grvProducs.RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
