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
    public partial class ProductCategoriesForm : Form {
        public ProductCategoriesForm() {
            InitializeComponent();
        }

        private void ProductCategoriesForm_Load(object sender, EventArgs e) {
            var pcr = new ProductCategoryRepo();
            bsProductCategories.DataSource = pcr.GetAll();
            grdProductCategories.DataSource = bsProductCategories;
        }

        private void btnNew_Click(object sender, EventArgs e) {
            var pcdf = new ProductCategoryDetailsForm(null);
            pcdf.ShowDialog();
            var pcr = new ProductCategoryRepo();
            bsProductCategories.DataSource = pcr.GetAll();
            grvProductCategories.RefreshData();

        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            var productCategory = bsProductCategories.Current as ProductCategory;
            var pcdForm = new ProductCategoryDetailsForm(productCategory);
            pcdForm.ShowDialog();
            var pcr = new ProductCategoryRepo();
            bsProductCategories.DataSource = pcr.GetAll();
            grvProductCategories.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var productCategory = bsProductCategories.Current as ProductCategory;
            if(productCategory is null) {
                return;
            }
            var pcr = new ProductCategoryRepo();
            pcr.Delete(productCategory.ID);
            bsProductCategories.DataSource = pcr.GetAll();
            grvProductCategories.RefreshData();
        }
    }
}
