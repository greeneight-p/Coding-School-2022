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
    public partial class CustomerDetailsForm : Form {

        public Customer Customer { get; set; }
        public Customer? OriginalCustomer { get; set; }

        public CustomerRepo CustomerRepo { get; set; } = new CustomerRepo();
        public CustomerDetailsForm(Customer? customer) {

            if (customer == null) {
                Customer = new Customer()
                {
                    Code ="001",
                    Description ="Retailer"
                };   
            }
            else {
                OriginalCustomer = customer.ShallowCopy();
                Customer = customer;
            }

            InitializeComponent();
        }

        private void CustomerDetailsForm_Load(object sender, EventArgs e) {

            bsCustomer.DataSource = Customer;
            textEditCode.DataBindings.Add(new Binding("EditValue", bsCustomer, "Code"));
            textEditDescription.DataBindings.Add(new Binding("EditValue", bsCustomer, "Description"));
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if(OriginalCustomer is not null) {
                CustomerRepo.Update(Customer.ID, Customer);
            }
            CustomerRepo.Create(Customer);
            DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e) {

            //if(OriginalCustomer is not null) {
            //    Customer = OriginalCustomer;
            //}

            Close();
                
            
        }
    }
}
