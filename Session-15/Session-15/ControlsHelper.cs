using CoffeeShop.Model;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15 {
    public class ControlsHelper {

        public static void PopulateProductType(RepositoryItemLookUpEdit lookup) {
            var types = new Dictionary<ProductType, string>()
        {
            { ProductType.Coffee, "Coffee" },
            { ProductType.Beverages, "Beverages" },
            { ProductType.Food, "Food" }
        };

            lookup.DataSource = types;
            lookup.Columns.Add(new LookUpColumnInfo("Value"));
            lookup.DisplayMember = "Value";
            lookup.ValueMember = "Key";
            lookup.ShowHeader = false;
            
        }

        public static void PopulatePaymentMethod(RepositoryItemLookUpEdit lookup) {
        var types = new Dictionary<PaymentMethod, string>()
        {
            { PaymentMethod.Cash, "Cash" },
            { PaymentMethod.CreditCard, "Credit Card" }
        };

        lookup.DataSource = types;
        lookup.Columns.Add(new LookUpColumnInfo("Value"));
        lookup.DisplayMember = "Value";
        lookup.ValueMember = "Key";
        lookup.ShowHeader = false;
    }

    public static void PopulateLedgerMonths(RepositoryItemLookUpEdit lookup) {

        Dictionary<Months, string> months = new Dictionary<Months, string>();
        months.Add(Months.January, "Januray");
        months.Add(Months.February, "February");
        months.Add(Months.March, "March");
        months.Add(Months.April, "April");
        months.Add(Months.May, "May");
        months.Add(Months.June, "June");
        months.Add(Months.July, "July");
        months.Add(Months.August, "August");
        months.Add(Months.September, "September");
        months.Add(Months.October, "October");
        months.Add(Months.November, "November");
        months.Add(Months.December, "December");


        lookup.DataSource = months;
        lookup.Columns.Add(new LookUpColumnInfo("Value"));
        lookup.DisplayMember = "Value";
        lookup.ValueMember = "Key";
        lookup.ShowHeader = false;

    }







}
}
