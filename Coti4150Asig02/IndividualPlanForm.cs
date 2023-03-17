using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coti4150Asig02
{
    public partial class IndividualPlanForm : Form
    {
        private decimal phoneSubtotal = 0;
        private decimal packageCost = 0;
        private decimal optionCost = 0;
        public IndividualPlanForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdo800Minutes_CheckedChanged(object sender, EventArgs e)
        {
            packageCost = 45.0m;
        }

        private void rdo1500Minutes_CheckedChanged(object sender, EventArgs e)
        {
            packageCost = 65.0m;
        }

        private void rdoUnlimited_CheckedChanged(object sender, EventArgs e)
        {
            packageCost = 99.0m;
        }

        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {
            optionCost += 25.0m;
        }

        private void chkTextMessaging_CheckedChanged(object sender, EventArgs e)
        {
            optionCost += 10.0m;
        }

        private void btnViewTotals_Click(object sender, EventArgs e)
        {
            txtPhoneSubtotal.Text = phoneSubtotal.ToString("c");

            decimal tax = phoneSubtotal * 0.115m;
            
            txtTax.Text = tax.ToString("c");

            decimal total = phoneSubtotal * 1.115m;

            txtPhoneTotal.Text = total.ToString();

            txtOptions.Text = optionCost.ToString();

            txtPackageCharge.Text = packageCost.ToString();
        }

        private void rdoModel100_CheckedChanged(object sender, EventArgs e)
        {
            phoneSubtotal = 229.25m;
        }

        private void rdoModel110_CheckedChanged(object sender, EventArgs e)
        {
            phoneSubtotal = 249.95m;
        }

        private void rdoModel200_CheckedChanged(object sender, EventArgs e)
        {
            phoneSubtotal = 299.95m;
        }
    }
}
