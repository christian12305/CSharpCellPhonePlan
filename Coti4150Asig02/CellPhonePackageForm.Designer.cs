namespace Coti4150Asig02
{
    partial class CellPhonePackageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CellPhonePackageForm));
            this.grpSelectPlan = new System.Windows.Forms.GroupBox();
            this.picFamily = new System.Windows.Forms.PictureBox();
            this.btnFamily = new System.Windows.Forms.Button();
            this.lblFamily = new System.Windows.Forms.Label();
            this.picIndividual = new System.Windows.Forms.PictureBox();
            this.btnIndividual = new System.Windows.Forms.Button();
            this.lblIndividual = new System.Windows.Forms.Label();
            this.picCellPhone = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpSelectPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndividual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCellPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSelectPlan
            // 
            this.grpSelectPlan.Controls.Add(this.picFamily);
            this.grpSelectPlan.Controls.Add(this.btnFamily);
            this.grpSelectPlan.Controls.Add(this.lblFamily);
            this.grpSelectPlan.Controls.Add(this.picIndividual);
            this.grpSelectPlan.Controls.Add(this.btnIndividual);
            this.grpSelectPlan.Controls.Add(this.lblIndividual);
            this.grpSelectPlan.Location = new System.Drawing.Point(12, 22);
            this.grpSelectPlan.Name = "grpSelectPlan";
            this.grpSelectPlan.Size = new System.Drawing.Size(489, 215);
            this.grpSelectPlan.TabIndex = 0;
            this.grpSelectPlan.TabStop = false;
            this.grpSelectPlan.Text = "Select a Plan";
            // 
            // picFamily
            // 
            this.picFamily.Image = ((System.Drawing.Image)(resources.GetObject("picFamily.Image")));
            this.picFamily.Location = new System.Drawing.Point(338, 136);
            this.picFamily.Name = "picFamily";
            this.picFamily.Size = new System.Drawing.Size(134, 72);
            this.picFamily.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFamily.TabIndex = 5;
            this.picFamily.TabStop = false;
            // 
            // btnFamily
            // 
            this.btnFamily.Location = new System.Drawing.Point(233, 155);
            this.btnFamily.Name = "btnFamily";
            this.btnFamily.Size = new System.Drawing.Size(75, 23);
            this.btnFamily.TabIndex = 4;
            this.btnFamily.Text = "&Family";
            this.btnFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnFamily, "Choose a Family Plan");
            this.btnFamily.UseVisualStyleBackColor = true;
            this.btnFamily.Click += new System.EventHandler(this.btnFamily_Click);
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(6, 136);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(199, 60);
            this.lblFamily.TabIndex = 3;
            this.lblFamily.Text = "The Family plan allows you to\r\npurchase multiple cell phones of the\r\nsame model, " +
    "with each phone\r\nsharing one monthly package.";
            this.lblFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picIndividual
            // 
            this.picIndividual.Image = ((System.Drawing.Image)(resources.GetObject("picIndividual.Image")));
            this.picIndividual.Location = new System.Drawing.Point(348, 32);
            this.picIndividual.Name = "picIndividual";
            this.picIndividual.Size = new System.Drawing.Size(103, 67);
            this.picIndividual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIndividual.TabIndex = 2;
            this.picIndividual.TabStop = false;
            // 
            // btnIndividual
            // 
            this.btnIndividual.Location = new System.Drawing.Point(233, 43);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.Size = new System.Drawing.Size(75, 23);
            this.btnIndividual.TabIndex = 1;
            this.btnIndividual.Text = "&Individual";
            this.btnIndividual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnIndividual, "Choose an Individual Plan");
            this.btnIndividual.UseVisualStyleBackColor = true;
            this.btnIndividual.Click += new System.EventHandler(this.btnIndividual_Click);
            // 
            // lblIndividual
            // 
            this.lblIndividual.AutoSize = true;
            this.lblIndividual.Location = new System.Drawing.Point(6, 32);
            this.lblIndividual.Name = "lblIndividual";
            this.lblIndividual.Size = new System.Drawing.Size(194, 45);
            this.lblIndividual.TabIndex = 0;
            this.lblIndividual.Text = "The Individual plan provides one \r\ncell phone and a variety of monthly\r\n packages" +
    ".";
            this.lblIndividual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCellPhone
            // 
            this.picCellPhone.Image = ((System.Drawing.Image)(resources.GetObject("picCellPhone.Image")));
            this.picCellPhone.Location = new System.Drawing.Point(12, 253);
            this.picCellPhone.Name = "picCellPhone";
            this.picCellPhone.Size = new System.Drawing.Size(134, 145);
            this.picCellPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCellPhone.TabIndex = 1;
            this.picCellPhone.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(418, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnExit, "Exit the application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CellPhonePackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(515, 414);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picCellPhone);
            this.Controls.Add(this.grpSelectPlan);
            this.Name = "CellPhonePackageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cell Phone Packages";
            this.toolTip1.SetToolTip(this, "Cell Phone Package Form");
            this.grpSelectPlan.ResumeLayout(false);
            this.grpSelectPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndividual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCellPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpSelectPlan;
        private PictureBox picFamily;
        private Button btnFamily;
        private Label lblFamily;
        private PictureBox picIndividual;
        private Button btnIndividual;
        private Label lblIndividual;
        private PictureBox picCellPhone;
        private Button btnExit;
        private ToolTip toolTip1;
    }
}