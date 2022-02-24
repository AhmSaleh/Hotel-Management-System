namespace HotelManagmentRefactored.UI_Forms
{
    partial class FinalizePayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.tbCardNumbeer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMM = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbYY = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCVC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tbCardType = new System.Windows.Forms.TextBox();
            this.txtFoodBill = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.Label();
            this.textTax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation Current Bill";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.cbPaymentType.Location = new System.Drawing.Point(30, 312);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(195, 28);
            this.cbPaymentType.TabIndex = 1;
            this.cbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cbPaymentType_SelectedIndexChanged);
            // 
            // tbCardNumbeer
            // 
            this.tbCardNumbeer.Location = new System.Drawing.Point(251, 312);
            this.tbCardNumbeer.MaxLength = 16;
            this.tbCardNumbeer.Name = "tbCardNumbeer";
            this.tbCardNumbeer.Size = new System.Drawing.Size(148, 27);
            this.tbCardNumbeer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Food bill";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(30, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Payment Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Card Number";
            // 
            // cbMM
            // 
            this.cbMM.FormattingEnabled = true;
            this.cbMM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMM.Location = new System.Drawing.Point(30, 378);
            this.cbMM.Name = "cbMM";
            this.cbMM.Size = new System.Drawing.Size(82, 28);
            this.cbMM.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(119, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 28);
            this.label13.TabIndex = 34;
            this.label13.Text = "/";
            // 
            // cbYY
            // 
            this.cbYY.FormattingEnabled = true;
            this.cbYY.Items.AddRange(new object[] {
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbYY.Location = new System.Drawing.Point(143, 378);
            this.cbYY.Name = "cbYY";
            this.cbYY.Size = new System.Drawing.Size(82, 28);
            this.cbYY.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "MM";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(143, 355);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "YY";
            // 
            // tbCVC
            // 
            this.tbCVC.Location = new System.Drawing.Point(356, 375);
            this.tbCVC.MaxLength = 3;
            this.tbCVC.Name = "tbCVC";
            this.tbCVC.Size = new System.Drawing.Size(98, 27);
            this.tbCVC.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(306, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 20);
            this.label16.TabIndex = 39;
            this.label16.Text = "CVC";
            // 
            // btnNext
            // 
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNext.Location = new System.Drawing.Point(248, 442);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(437, 278);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 20);
            this.label17.TabIndex = 42;
            this.label17.Text = "Card Type";
            // 
            // tbCardType
            // 
            this.tbCardType.Location = new System.Drawing.Point(437, 312);
            this.tbCardType.MaxLength = 16;
            this.tbCardType.Name = "tbCardType";
            this.tbCardType.Size = new System.Drawing.Size(148, 27);
            this.tbCardType.TabIndex = 3;
            // 
            // txtFoodBill
            // 
            this.txtFoodBill.AutoSize = true;
            this.txtFoodBill.Location = new System.Drawing.Point(449, 108);
            this.txtFoodBill.Name = "txtFoodBill";
            this.txtFoodBill.Size = new System.Drawing.Size(68, 20);
            this.txtFoodBill.TabIndex = 1;
            this.txtFoodBill.Text = "Food bill";
            // 
            // textTotal
            // 
            this.textTotal.AutoSize = true;
            this.textTotal.Location = new System.Drawing.Point(451, 185);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(42, 20);
            this.textTotal.TabIndex = 1;
            this.textTotal.Text = "Total";
            // 
            // textTax
            // 
            this.textTax.AutoSize = true;
            this.textTax.Location = new System.Drawing.Point(450, 145);
            this.textTax.Name = "textTax";
            this.textTax.Size = new System.Drawing.Size(30, 20);
            this.textTax.TabIndex = 43;
            this.textTax.Text = "Tax";
            // 
            // FinalizePayment
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 483);
            this.Controls.Add(this.textTax);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbCardType);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbCVC);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbYY);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbMM);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbPaymentType);
            this.Controls.Add(this.tbCardNumbeer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFoodBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FinalizePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalize Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbPaymentType;
        private TextBox tbCardNumbeer;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cbMM;
        private Label label13;
        private ComboBox cbYY;
        private Label label14;
        private Label label15;
        private TextBox tbCVC;
        private Label label16;
        private Button btnNext;
        private Label label17;
        private TextBox tbCardType;
        private Label txtFoodBill;
        private Label textTotal;
        private Label textTax;
    }
}