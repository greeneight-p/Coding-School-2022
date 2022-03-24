using CoffeeShop.EntityFrameWork;
using CoffeeShop.EntityFrameWork.Repositories;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_15 {
    public partial class ProductDetailsForm : Form {

        public Product Product { get; set; }
        public ProductRepo ProductRepo { get; set; } = new ProductRepo();
        public ProductCategoryRepo ProductCategoryRepo { get; set; } = new ProductCategoryRepo();
        private bool _edit;

        public ProductDetailsForm(Product? product, bool edit) {

            if (product is null) {
                Product = new Product();
                _edit = edit;
            }
            else {

                _edit = edit;
                Product = product;
            }

            InitializeComponent();
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e) {

            bsProduct.DataSource = Product;

            bsProductCategories.DataSource = ProductCategoryRepo.GetAll();
            grdProductCats.DataSource = bsProductCategories;


            textEditCode.DataBindings.Add(new Binding("EditValue", bsProduct, "Code", true));
            textEditDescription.DataBindings.Add(new Binding("EditValue", bsProduct, "Description", true));
            calcEditCost.DataBindings.Add(new Binding("EditValue", bsProduct, "Cost", true));
            calcEditPrice.DataBindings.Add(new Binding("EditValue", bsProduct, "Price", true));


        }

        private void btnSave_Click(object sender, EventArgs e) {


            var productCat = bsProductCategories.Current as ProductCategory;
            if (productCat is null) {
                MessageBox.Show("Pick a category");
            }
            Product.ProductCategoryID = productCat.ID;
            //Product.ProductCategory = productCat;

            if (_edit) {
                ProductRepo.Update(Product.ID, Product);
            }
            else {
                ProductRepo.Create(Product);
            }

            DialogResult = DialogResult.OK;


        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
