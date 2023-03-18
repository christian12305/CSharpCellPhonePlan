using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coti4150Asig02
{
    public partial class IndividualPlanForm : Form
    {
        public IndividualPlanForm()
        {
            InitializeComponent();
        }
        //Event handeler for view totals button
        private void btnViewTotals_Click(object sender, EventArgs e)
        {
            modelChosen(out decimal phoneCost);

            packageChosen(out decimal packageCost);

            optionsChosen(out decimal optionsCost);

            monthlyCharge(out decimal monthlyCost, packageCost, optionsCost);

            taxCharge(out decimal taxCost, phoneCost);

            txtPhoneSubtotal.Text = phoneCost.ToString("c");

            txtTax.Text = taxCost.ToString("c");

            totalPhoneCalc(out decimal phoneTotal, phoneCost, taxCost);

            txtPhoneTotal.Text = phoneTotal.ToString("c");

            txtOptions.Text = optionsCost.ToString("c");

            txtPackageCharge.Text = packageCost.ToString("c");

            txtTotalMonthlyCharge.Text = monthlyCost.ToString("c");

        }

        //Calculates the total phone cost
        private void totalPhoneCalc(out decimal phoneTotal, decimal phoneCost, decimal taxCost)
        {
            phoneTotal = phoneCost + taxCost;
        }

        //Calculate the 11.5% tax 
        private void taxCharge(out decimal taxCost, decimal phoneCost)
        {
            decimal salesTax = 0.115m;

            taxCost = phoneCost * salesTax;
        }

        //Calculate the monthly charge.
        private void monthlyCharge(out decimal monthlyCost, decimal packageCost, decimal optionsCost)
        {
            monthlyCost = packageCost + optionsCost;
        }

        //Method to store the options cost.
        private void optionsChosen(out decimal optionsCost)
        {
            decimal temp = 0;

            if (chkEmail.Checked)
                temp += 25.0m;
            if (chkTextMessaging.Checked)
                temp += 10.0m;

            optionsCost = temp;
        }

        //Method to store the package cost.
        private void packageChosen(out decimal packageCost)
        {
            if (rdo800Minutes.Checked)
                packageCost = 45.0m;
            else if (rdo1500Minutes.Checked)
                packageCost = 65.0m;
            else
                packageCost = 99.0m;

        }

        //Method to store the phone cost.
        private void modelChosen(out decimal phoneCost)
        {
            if (rdoModel100.Checked)
                phoneCost = 229.95m;
            else if (rdoModel110.Checked)
                phoneCost = 249.95m;
            else
                phoneCost = 299.95m;
        }


        //Event handler for any input change
        private void inputChanged(object sender, EventArgs e)
        {
            txtPhoneSubtotal.Clear();
            txtTax.Clear();
            txtPhoneTotal.Clear();
            txtOptions.Clear();
            txtPackageCharge.Clear();
            txtTotalMonthlyCharge.Clear();
        }

        //Event handler for closing operation
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
