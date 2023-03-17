namespace Coti4150Asig02
{
    partial class FamilyPlanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyPlanForm));
            this.grpSelectModel = new System.Windows.Forms.GroupBox();
            this.rdoModel200 = new System.Windows.Forms.RadioButton();
            this.rdoModel110 = new System.Windows.Forms.RadioButton();
            this.rdoModel100 = new System.Windows.Forms.RadioButton();
            this.grpSelectPackage = new System.Windows.Forms.GroupBox();
            this.rdoUnlimited = new System.Windows.Forms.RadioButton();
            this.rdo1500Minutes = new System.Windows.Forms.RadioButton();
            this.rdo800Minutes = new System.Windows.Forms.RadioButton();
            this.grpSelectOptions = new System.Windows.Forms.GroupBox();
            this.chkTextMessaging = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.grpTotals = new System.Windows.Forms.GroupBox();
            this.txtTotalMonthlyCharge = new System.Windows.Forms.TextBox();
            this.lblTotalMonthlyCharge = new System.Windows.Forms.Label();
            this.txtPackageCharge = new System.Windows.Forms.TextBox();
            this.lblPackageCharge = new System.Windows.Forms.Label();
            this.txtOptions = new System.Windows.Forms.TextBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.txtPhoneTotal = new System.Windows.Forms.TextBox();
            this.lblPhoneTotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtPhoneSubtotal = new System.Windows.Forms.TextBox();
            this.lblPhoneSubtotal = new System.Windows.Forms.Label();
            this.picIndividual = new System.Windows.Forms.PictureBox();
            this.btnViewTotals = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNumberPhones = new System.Windows.Forms.Label();
            this.cboNumberPhones = new System.Windows.Forms.ComboBox();
            this.grpSelectModel.SuspendLayout();
            this.grpSelectPackage.SuspendLayout();
            this.grpSelectOptions.SuspendLayout();
            this.grpTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIndividual)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSelectModel
            // 
            this.grpSelectModel.Controls.Add(this.rdoModel200);
            this.grpSelectModel.Controls.Add(this.rdoModel110);
            this.grpSelectModel.Controls.Add(this.rdoModel100);
            this.grpSelectModel.Location = new System.Drawing.Point(14, 62);
            this.grpSelectModel.Name = "grpSelectModel";
            this.grpSelectModel.Size = new System.Drawing.Size(157, 100);
            this.grpSelectModel.TabIndex = 0;
            this.grpSelectModel.TabStop = false;
            this.grpSelectModel.Text = "Select a Model";
            // 
            // rdoModel200
            // 
            this.rdoModel200.AutoSize = true;
            this.rdoModel200.Checked = true;
            this.rdoModel200.Location = new System.Drawing.Point(15, 71);
            this.rdoModel200.Name = "rdoModel200";
            this.rdoModel200.Size = new System.Drawing.Size(80, 19);
            this.rdoModel200.TabIndex = 2;
            this.rdoModel200.TabStop = true;
            this.rdoModel200.Text = "Model 200";
            this.rdoModel200.UseVisualStyleBackColor = true;
            // 
            // rdoModel110
            // 
            this.rdoModel110.AutoSize = true;
            this.rdoModel110.Location = new System.Drawing.Point(15, 46);
            this.rdoModel110.Name = "rdoModel110";
            this.rdoModel110.Size = new System.Drawing.Size(80, 19);
            this.rdoModel110.TabIndex = 1;
            this.rdoModel110.Text = "Model 110";
            this.rdoModel110.UseVisualStyleBackColor = true;
            // 
            // rdoModel100
            // 
            this.rdoModel100.AutoSize = true;
            this.rdoModel100.Location = new System.Drawing.Point(15, 21);
            this.rdoModel100.Name = "rdoModel100";
            this.rdoModel100.Size = new System.Drawing.Size(80, 19);
            this.rdoModel100.TabIndex = 0;
            this.rdoModel100.Text = "Model 100";
            this.rdoModel100.UseVisualStyleBackColor = true;
            // 
            // grpSelectPackage
            // 
            this.grpSelectPackage.Controls.Add(this.rdoUnlimited);
            this.grpSelectPackage.Controls.Add(this.rdo1500Minutes);
            this.grpSelectPackage.Controls.Add(this.rdo800Minutes);
            this.grpSelectPackage.Location = new System.Drawing.Point(186, 62);
            this.grpSelectPackage.Name = "grpSelectPackage";
            this.grpSelectPackage.Size = new System.Drawing.Size(274, 100);
            this.grpSelectPackage.TabIndex = 1;
            this.grpSelectPackage.TabStop = false;
            this.grpSelectPackage.Text = "Select a Package";
            // 
            // rdoUnlimited
            // 
            this.rdoUnlimited.AutoSize = true;
            this.rdoUnlimited.Location = new System.Drawing.Point(17, 69);
            this.rdoUnlimited.Name = "rdoUnlimited";
            this.rdoUnlimited.Size = new System.Drawing.Size(123, 19);
            this.rdoUnlimited.TabIndex = 2;
            this.rdoUnlimited.TabStop = true;
            this.rdoUnlimited.Text = "Unlimited Minutes";
            this.rdoUnlimited.UseVisualStyleBackColor = true;
            // 
            // rdo1500Minutes
            // 
            this.rdo1500Minutes.AutoSize = true;
            this.rdo1500Minutes.Checked = true;
            this.rdo1500Minutes.Location = new System.Drawing.Point(17, 44);
            this.rdo1500Minutes.Name = "rdo1500Minutes";
            this.rdo1500Minutes.Size = new System.Drawing.Size(136, 19);
            this.rdo1500Minutes.TabIndex = 1;
            this.rdo1500Minutes.TabStop = true;
            this.rdo1500Minutes.Text = "1500 Minutes/Month";
            this.rdo1500Minutes.UseVisualStyleBackColor = true;
            // 
            // rdo800Minutes
            // 
            this.rdo800Minutes.AutoSize = true;
            this.rdo800Minutes.Location = new System.Drawing.Point(17, 19);
            this.rdo800Minutes.Name = "rdo800Minutes";
            this.rdo800Minutes.Size = new System.Drawing.Size(130, 19);
            this.rdo800Minutes.TabIndex = 0;
            this.rdo800Minutes.Text = "800 Minutes/Month";
            this.rdo800Minutes.UseVisualStyleBackColor = true;
            // 
            // grpSelectOptions
            // 
            this.grpSelectOptions.Controls.Add(this.chkTextMessaging);
            this.grpSelectOptions.Controls.Add(this.chkEmail);
            this.grpSelectOptions.Location = new System.Drawing.Point(14, 177);
            this.grpSelectOptions.Name = "grpSelectOptions";
            this.grpSelectOptions.Size = new System.Drawing.Size(157, 100);
            this.grpSelectOptions.TabIndex = 2;
            this.grpSelectOptions.TabStop = false;
            this.grpSelectOptions.Text = "Select Options";
            // 
            // chkTextMessaging
            // 
            this.chkTextMessaging.AutoSize = true;
            this.chkTextMessaging.Checked = true;
            this.chkTextMessaging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTextMessaging.Location = new System.Drawing.Point(11, 53);
            this.chkTextMessaging.Name = "chkTextMessaging";
            this.chkTextMessaging.Size = new System.Drawing.Size(107, 19);
            this.chkTextMessaging.TabIndex = 1;
            this.chkTextMessaging.Text = "Text Messaging";
            this.chkTextMessaging.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Checked = true;
            this.chkEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmail.Location = new System.Drawing.Point(11, 28);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(55, 19);
            this.chkEmail.TabIndex = 0;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // grpTotals
            // 
            this.grpTotals.Controls.Add(this.txtTotalMonthlyCharge);
            this.grpTotals.Controls.Add(this.lblTotalMonthlyCharge);
            this.grpTotals.Controls.Add(this.txtPackageCharge);
            this.grpTotals.Controls.Add(this.lblPackageCharge);
            this.grpTotals.Controls.Add(this.txtOptions);
            this.grpTotals.Controls.Add(this.lblOptions);
            this.grpTotals.Controls.Add(this.txtPhoneTotal);
            this.grpTotals.Controls.Add(this.lblPhoneTotal);
            this.grpTotals.Controls.Add(this.txtTax);
            this.grpTotals.Controls.Add(this.lblTax);
            this.grpTotals.Controls.Add(this.txtPhoneSubtotal);
            this.grpTotals.Controls.Add(this.lblPhoneSubtotal);
            this.grpTotals.Location = new System.Drawing.Point(186, 177);
            this.grpTotals.Name = "grpTotals";
            this.grpTotals.Size = new System.Drawing.Size(274, 213);
            this.grpTotals.TabIndex = 3;
            this.grpTotals.TabStop = false;
            this.grpTotals.Text = "Totals";
            // 
            // txtTotalMonthlyCharge
            // 
            this.txtTotalMonthlyCharge.Location = new System.Drawing.Point(160, 177);
            this.txtTotalMonthlyCharge.Name = "txtTotalMonthlyCharge";
            this.txtTotalMonthlyCharge.ReadOnly = true;
            this.txtTotalMonthlyCharge.Size = new System.Drawing.Size(100, 23);
            this.txtTotalMonthlyCharge.TabIndex = 11;
            this.txtTotalMonthlyCharge.TabStop = false;
            // 
            // lblTotalMonthlyCharge
            // 
            this.lblTotalMonthlyCharge.AutoSize = true;
            this.lblTotalMonthlyCharge.Location = new System.Drawing.Point(17, 180);
            this.lblTotalMonthlyCharge.Name = "lblTotalMonthlyCharge";
            this.lblTotalMonthlyCharge.Size = new System.Drawing.Size(124, 15);
            this.lblTotalMonthlyCharge.TabIndex = 10;
            this.lblTotalMonthlyCharge.Text = "Total Monthly Charge:";
            this.lblTotalMonthlyCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPackageCharge
            // 
            this.txtPackageCharge.Location = new System.Drawing.Point(160, 142);
            this.txtPackageCharge.Name = "txtPackageCharge";
            this.txtPackageCharge.ReadOnly = true;
            this.txtPackageCharge.Size = new System.Drawing.Size(100, 23);
            this.txtPackageCharge.TabIndex = 9;
            this.txtPackageCharge.TabStop = false;
            // 
            // lblPackageCharge
            // 
            this.lblPackageCharge.AutoSize = true;
            this.lblPackageCharge.Location = new System.Drawing.Point(18, 150);
            this.lblPackageCharge.Name = "lblPackageCharge";
            this.lblPackageCharge.Size = new System.Drawing.Size(95, 15);
            this.lblPackageCharge.TabIndex = 8;
            this.lblPackageCharge.Text = "Package Charge:";
            this.lblPackageCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOptions
            // 
            this.txtOptions.Location = new System.Drawing.Point(160, 109);
            this.txtOptions.Name = "txtOptions";
            this.txtOptions.ReadOnly = true;
            this.txtOptions.Size = new System.Drawing.Size(100, 23);
            this.txtOptions.TabIndex = 7;
            this.txtOptions.TabStop = false;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(18, 117);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(52, 15);
            this.lblOptions.TabIndex = 6;
            this.lblOptions.Text = "Options:";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhoneTotal
            // 
            this.txtPhoneTotal.Location = new System.Drawing.Point(160, 77);
            this.txtPhoneTotal.Name = "txtPhoneTotal";
            this.txtPhoneTotal.ReadOnly = true;
            this.txtPhoneTotal.Size = new System.Drawing.Size(100, 23);
            this.txtPhoneTotal.TabIndex = 5;
            this.txtPhoneTotal.TabStop = false;
            // 
            // lblPhoneTotal
            // 
            this.lblPhoneTotal.AutoSize = true;
            this.lblPhoneTotal.Location = new System.Drawing.Point(18, 85);
            this.lblPhoneTotal.Name = "lblPhoneTotal";
            this.lblPhoneTotal.Size = new System.Drawing.Size(72, 15);
            this.lblPhoneTotal.TabIndex = 4;
            this.lblPhoneTotal.Text = "Phone Total:";
            this.lblPhoneTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(160, 46);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 23);
            this.txtTax.TabIndex = 3;
            this.txtTax.TabStop = false;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(18, 53);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(27, 15);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax:";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhoneSubtotal
            // 
            this.txtPhoneSubtotal.Location = new System.Drawing.Point(160, 15);
            this.txtPhoneSubtotal.Name = "txtPhoneSubtotal";
            this.txtPhoneSubtotal.ReadOnly = true;
            this.txtPhoneSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtPhoneSubtotal.TabIndex = 1;
            this.txtPhoneSubtotal.TabStop = false;
            // 
            // lblPhoneSubtotal
            // 
            this.lblPhoneSubtotal.AutoSize = true;
            this.lblPhoneSubtotal.Location = new System.Drawing.Point(18, 23);
            this.lblPhoneSubtotal.Name = "lblPhoneSubtotal";
            this.lblPhoneSubtotal.Size = new System.Drawing.Size(91, 15);
            this.lblPhoneSubtotal.TabIndex = 0;
            this.lblPhoneSubtotal.Text = "Phone Subtotal:";
            this.lblPhoneSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picIndividual
            // 
            this.picIndividual.Image = ((System.Drawing.Image)(resources.GetObject("picIndividual.Image")));
            this.picIndividual.Location = new System.Drawing.Point(25, 286);
            this.picIndividual.Name = "picIndividual";
            this.picIndividual.Size = new System.Drawing.Size(117, 66);
            this.picIndividual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIndividual.TabIndex = 4;
            this.picIndividual.TabStop = false;
            // 
            // btnViewTotals
            // 
            this.btnViewTotals.Location = new System.Drawing.Point(34, 380);
            this.btnViewTotals.Name = "btnViewTotals";
            this.btnViewTotals.Size = new System.Drawing.Size(75, 23);
            this.btnViewTotals.TabIndex = 5;
            this.btnViewTotals.Text = "View Totals";
            this.btnViewTotals.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(34, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNumberPhones
            // 
            this.lblNumberPhones.AutoSize = true;
            this.lblNumberPhones.Location = new System.Drawing.Point(14, 23);
            this.lblNumberPhones.Name = "lblNumberPhones";
            this.lblNumberPhones.Size = new System.Drawing.Size(110, 15);
            this.lblNumberPhones.TabIndex = 0;
            this.lblNumberPhones.Text = "Number of Phones:";
            this.lblNumberPhones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboNumberPhones
            // 
            this.cboNumberPhones.AllowDrop = true;
            this.cboNumberPhones.DisplayMember = "4";
            this.cboNumberPhones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumberPhones.FormattingEnabled = true;
            this.cboNumberPhones.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboNumberPhones.Location = new System.Drawing.Point(138, 23);
            this.cboNumberPhones.MinimumSize = new System.Drawing.Size(2, 0);
            this.cboNumberPhones.Name = "cboNumberPhones";
            this.cboNumberPhones.Size = new System.Drawing.Size(49, 23);
            this.cboNumberPhones.TabIndex = 7;
            // 
            // FamilyPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 445);
            this.Controls.Add(this.cboNumberPhones);
            this.Controls.Add(this.lblNumberPhones);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewTotals);
            this.Controls.Add(this.picIndividual);
            this.Controls.Add(this.grpTotals);
            this.Controls.Add(this.grpSelectOptions);
            this.Controls.Add(this.grpSelectPackage);
            this.Controls.Add(this.grpSelectModel);
            this.Name = "FamilyPlanForm";
            this.Text = "Family Plan";
            this.grpSelectModel.ResumeLayout(false);
            this.grpSelectModel.PerformLayout();
            this.grpSelectPackage.ResumeLayout(false);
            this.grpSelectPackage.PerformLayout();
            this.grpSelectOptions.ResumeLayout(false);
            this.grpSelectOptions.PerformLayout();
            this.grpTotals.ResumeLayout(false);
            this.grpTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIndividual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpSelectModel;
        private RadioButton rdoModel200;
        private RadioButton rdoModel110;
        private RadioButton rdoModel100;
        private GroupBox grpSelectPackage;
        private RadioButton rdoUnlimited;
        private RadioButton rdo1500Minutes;
        private RadioButton rdo800Minutes;
        private GroupBox grpSelectOptions;
        private CheckBox chkTextMessaging;
        private CheckBox chkEmail;
        private GroupBox grpTotals;
        private TextBox txtTotalMonthlyCharge;
        private Label lblTotalMonthlyCharge;
        private TextBox txtPackageCharge;
        private Label lblPackageCharge;
        private TextBox txtOptions;
        private Label lblOptions;
        private TextBox txtPhoneTotal;
        private Label lblPhoneTotal;
        private TextBox txtTax;
        private Label lblTax;
        private TextBox txtPhoneSubtotal;
        private Label lblPhoneSubtotal;
        private PictureBox picIndividual;
        private Button btnViewTotals;
        private Button btnClose;
        private Label lblNumberPhones;
        private ComboBox cboNumberPhones;
    }
}