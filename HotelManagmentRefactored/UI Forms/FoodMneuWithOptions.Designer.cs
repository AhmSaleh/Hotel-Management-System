namespace HotelManagmentRefactored.UI_Forms
{
    partial class FoodMneuWithOptions
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
            this.cbSweSurp = new System.Windows.Forms.CheckBox();
            this.cbTowels = new System.Windows.Forms.CheckBox();
            this.cbCleaning = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbDinner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLunch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBreakfast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSweSurp
            // 
            this.cbSweSurp.AutoSize = true;
            this.cbSweSurp.Location = new System.Drawing.Point(89, 413);
            this.cbSweSurp.Name = "cbSweSurp";
            this.cbSweSurp.Size = new System.Drawing.Size(147, 24);
            this.cbSweSurp.TabIndex = 28;
            this.cbSweSurp.Text = "Sweetest Surprise";
            this.cbSweSurp.UseVisualStyleBackColor = true;
            // 
            // cbTowels
            // 
            this.cbTowels.AutoSize = true;
            this.cbTowels.Location = new System.Drawing.Point(180, 363);
            this.cbTowels.Name = "cbTowels";
            this.cbTowels.Size = new System.Drawing.Size(76, 24);
            this.cbTowels.TabIndex = 27;
            this.cbTowels.Text = "Towels";
            this.cbTowels.UseVisualStyleBackColor = true;
            // 
            // cbCleaning
            // 
            this.cbCleaning.AutoSize = true;
            this.cbCleaning.Location = new System.Drawing.Point(53, 363);
            this.cbCleaning.Name = "cbCleaning";
            this.cbCleaning.Size = new System.Drawing.Size(89, 24);
            this.cbCleaning.TabIndex = 26;
            this.cbCleaning.Text = "Cleaning";
            this.cbCleaning.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(89, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Special Needs";
            // 
            // btnNext
            // 
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNext.Location = new System.Drawing.Point(53, 469);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(183, 29);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbDinner
            // 
            this.tbDinner.Location = new System.Drawing.Point(42, 251);
            this.tbDinner.Name = "tbDinner";
            this.tbDinner.Size = new System.Drawing.Size(214, 27);
            this.tbDinner.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dinner ($15)";
            // 
            // tbLunch
            // 
            this.tbLunch.Location = new System.Drawing.Point(42, 162);
            this.tbLunch.Name = "tbLunch";
            this.tbLunch.Size = new System.Drawing.Size(214, 27);
            this.tbLunch.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lunch ($15)";
            // 
            // tbBreakfast
            // 
            this.tbBreakfast.Location = new System.Drawing.Point(42, 66);
            this.tbBreakfast.Name = "tbBreakfast";
            this.tbBreakfast.Size = new System.Drawing.Size(214, 27);
            this.tbBreakfast.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Breakfast ($7)";
            // 
            // FoodMneuWithOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 526);
            this.Controls.Add(this.cbSweSurp);
            this.Controls.Add(this.cbTowels);
            this.Controls.Add(this.cbCleaning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbDinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLunch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBreakfast);
            this.Controls.Add(this.label1);
            this.Name = "FoodMneuWithOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Menu";
            this.Load += new System.EventHandler(this.FoodMneuWithOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbSweSurp;
        private CheckBox cbTowels;
        private CheckBox cbCleaning;
        private Label label4;
        private Button btnNext;
        private TextBox tbDinner;
        private Label label3;
        private TextBox tbLunch;
        private Label label2;
        private TextBox tbBreakfast;
        private Label label1;
    }
}