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
    public partial class CustomersForm : Form {



        public CustomersForm() {


            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e) {

            var cr = new CustomerRepo();
            bsCustomers.DataSource = cr.GetAll();
            grdCustomers.DataSource = bsCustomers;
        }

        private void btnNew_Click(object sender, EventArgs e) {
            var cr = new CustomerRepo();
            if (cr.GetAll().Count >= 1) {
                MessageBox.Show("Already One Customer");
                return;
            }
            var customerDefailsForm = new CustomerDetailsForm(null);
            customerDefailsForm.ShowDialog();
            bsCustomers.DataSource = cr.GetAll();
            grvCustomers.RefreshData();
            
        }

        private void bntEdit_Click(object sender, EventArgs e) {
            var customerDefailsForm = new CustomerDetailsForm((Customer)bsCustomers.Current);
            customerDefailsForm.ShowDialog();
            grvCustomers.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var selected = bsCustomers.Current as Customer;
            var cr = new CustomerRepo();
            cr.Delete(selected.ID);
            bsCustomers.DataSource = cr.GetAll();
            grvCustomers.RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
