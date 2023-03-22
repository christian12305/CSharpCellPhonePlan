/*
 * File: CellPhonePackageForm.cs
 * Author: Christian J. Ramos Ortega 841-18-4582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 03/22/2023
 * Purpose: This form asks the user to choose between an Individual Plan and a Family Plan
 *          to calculate the monthly charges.
 */
namespace Coti4150Asig02
{
    public partial class CellPhonePackageForm : Form
    {
        public CellPhonePackageForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            new IndividualPlanForm().Show();
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            new FamilyPlanForm().Show();
        }
    }
}