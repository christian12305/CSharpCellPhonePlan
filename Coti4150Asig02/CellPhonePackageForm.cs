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