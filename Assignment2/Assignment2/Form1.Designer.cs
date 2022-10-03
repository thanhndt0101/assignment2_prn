namespace Assignment2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWhiteningCost = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCleanCost = new System.Windows.Forms.Label();
            this.lblXRayCost = new System.Windows.Forms.Label();
            this.lblFillCost = new System.Windows.Forms.Label();
            this.chkClean = new System.Windows.Forms.CheckBox();
            this.chkWhitening = new System.Windows.Forms.CheckBox();
            this.chkXRay = new System.Windows.Forms.CheckBox();
            this.lblFilling = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dental Payment Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(22, 61);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên Khách Hàng :";
            // 
            // lblWhiteningCost
            // 
            this.lblWhiteningCost.AutoSize = true;
            this.lblWhiteningCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWhiteningCost.Location = new System.Drawing.Point(273, 155);
            this.lblWhiteningCost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWhiteningCost.Name = "lblWhiteningCost";
            this.lblWhiteningCost.Size = new System.Drawing.Size(92, 21);
            this.lblWhiteningCost.TabIndex = 6;
            this.lblWhiteningCost.Text = "$1.200.000";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(132, 323);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 21);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            // 
            // lblCleanCost
            // 
            this.lblCleanCost.AutoSize = true;
            this.lblCleanCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCleanCost.Location = new System.Drawing.Point(287, 108);
            this.lblCleanCost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCleanCost.Name = "lblCleanCost";
            this.lblCleanCost.Size = new System.Drawing.Size(78, 21);
            this.lblCleanCost.TabIndex = 8;
            this.lblCleanCost.Text = "$100.000";
            // 
            // lblXRayCost
            // 
            this.lblXRayCost.AutoSize = true;
            this.lblXRayCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblXRayCost.Location = new System.Drawing.Point(287, 200);
            this.lblXRayCost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblXRayCost.Name = "lblXRayCost";
            this.lblXRayCost.Size = new System.Drawing.Size(78, 21);
            this.lblXRayCost.TabIndex = 9;
            this.lblXRayCost.Text = "$200.000";
            // 
            // lblFillCost
            // 
            this.lblFillCost.AutoSize = true;
            this.lblFillCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFillCost.Location = new System.Drawing.Point(270, 246);
            this.lblFillCost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFillCost.Name = "lblFillCost";
            this.lblFillCost.Size = new System.Drawing.Size(95, 21);
            this.lblFillCost.TabIndex = 10;
            this.lblFillCost.Text = "$80.000/cái";
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkClean.Location = new System.Drawing.Point(21, 107);
            this.chkClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(88, 25);
            this.chkClean.TabIndex = 11;
            this.chkClean.Text = "Cạo vôi";
            this.chkClean.UseVisualStyleBackColor = true;
            this.chkClean.CheckedChanged += new System.EventHandler(this.chkClean_CheckedChanged);
            // 
            // chkWhitening
            // 
            this.chkWhitening.AutoSize = true;
            this.chkWhitening.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkWhitening.Location = new System.Drawing.Point(21, 154);
            this.chkWhitening.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkWhitening.Name = "chkWhitening";
            this.chkWhitening.Size = new System.Drawing.Size(100, 25);
            this.chkWhitening.TabIndex = 12;
            this.chkWhitening.Text = "Tẩy trắng";
            this.chkWhitening.UseVisualStyleBackColor = true;
            // 
            // chkXRay
            // 
            this.chkXRay.AutoSize = true;
            this.chkXRay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkXRay.Location = new System.Drawing.Point(21, 199);
            this.chkXRay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkXRay.Name = "chkXRay";
            this.chkXRay.Size = new System.Drawing.Size(145, 25);
            this.chkXRay.TabIndex = 13;
            this.chkXRay.Text = "Chụp hình răng";
            this.chkXRay.UseVisualStyleBackColor = true;
            this.chkXRay.CheckedChanged += new System.EventHandler(this.chkXRay_CheckedChanged);
            // 
            // lblFilling
            // 
            this.lblFilling.AutoSize = true;
            this.lblFilling.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilling.Location = new System.Drawing.Point(21, 246);
            this.lblFilling.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFilling.Name = "lblFilling";
            this.lblFilling.Size = new System.Drawing.Size(86, 21);
            this.lblFilling.TabIndex = 14;
            this.lblFilling.Text = "Trám răng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(49, 380);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 28);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 53);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 29);
            this.txtName.TabIndex = 16;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(245, 380);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(86, 28);
            this.btnCalc.TabIndex = 17;
            this.btnCalc.Text = "Tính tiền";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(229, 320);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(136, 29);
            this.txtTotal.TabIndex = 18;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // numFilling
            // 
            this.numFilling.Location = new System.Drawing.Point(115, 244);
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(106, 29);
            this.numFilling.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 419);
            this.Controls.Add(this.numFilling);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblFilling);
            this.Controls.Add(this.chkXRay);
            this.Controls.Add(this.chkWhitening);
            this.Controls.Add(this.chkClean);
            this.Controls.Add(this.lblFillCost);
            this.Controls.Add(this.lblXRayCost);
            this.Controls.Add(this.lblCleanCost);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblWhiteningCost);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Dental Payment Form";
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblWhiteningCost;
        private Label lblTotal;
        private Label lblCleanCost;
        private Label lblXRayCost;
        private Label lblFillCost;
        private CheckBox chkClean;
        private CheckBox chkWhitening;
        private CheckBox chkXRay;
        private Label lblFilling;
        private Button btnExit;
        private TextBox txtName;
        private Button btnCalc;
        private TextBox txtTotal;
        private NumericUpDown numFilling;
    }
}