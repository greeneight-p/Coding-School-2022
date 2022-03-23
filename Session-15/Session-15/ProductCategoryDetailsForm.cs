using CoffeeShop.EntityFrameWork.Repositories;
using CoffeeShop.Model;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
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
    public partial class ProductCategoryDetailsForm : Form {


        public ProductCategory ProductCategory { get; set; }
        public ProductCategory? OriginalCategory { get; set; }

        public ProductCategoryRepo ProductCategoryRepo { get; set; } = new ProductCategoryRepo();
        public ProductCategoryDetailsForm(ProductCategory? productCategory) {

            if (productCategory == null) {
                ProductCategory = new ProductCategory();

            }
            else {
                OriginalCategory = productCategory.ShallowCopy();
                ProductCategory = productCategory;
            }

            InitializeComponent();
        }

        private void ProductCategoryDetails_Load(object sender, EventArgs e) {

            bsProductCategory.DataSource = ProductCategory;
            ControlsHelper.PopulateProductType(lookUpEditType.Properties);
            textEditCode.DataBindings.Add(new Binding("EditValue", bsProductCategory, "Code",true));
            textEditDescription.DataBindings.Add(new Binding("EditValue", bsProductCategory, "Description",true));
            lookUpEditType.DataBindings.Add(new Binding("EditValue", bsProductCategory, "ProductType"));
            
        }

        private void btnClose_Click(object sender, EventArgs e) {



            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (OriginalCategory is not null) {
                ProductCategoryRepo.Update(ProductCategory.ID, ProductCategory);
            }
            else {
                ProductCategoryRepo.Create(ProductCategory);
            }
            DialogResult = DialogResult.OK;
        }


    }
}
