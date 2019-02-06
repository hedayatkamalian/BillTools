namespace BarCodeSub
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblyear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbYear = new System.Windows.Forms.TextBox();
            this.txbDuration = new System.Windows.Forms.TextBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCompanyCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbServiceTypeCode = new System.Windows.Forms.TextBox();
            this.txbToPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSubID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBillID = new System.Windows.Forms.TextBox();
            this.txbPayID = new System.Windows.Forms.TextBox();
            this.btnInterper = new System.Windows.Forms.Button();
            this.chkVerify = new System.Windows.Forms.CheckBox();
            this.chkFillzero = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.chkFillzero);
            this.tabPage1.Controls.Add(this.chkVerify);
            this.tabPage1.Controls.Add(this.btnInterper);
            this.tabPage1.Controls.Add(this.txbPayID);
            this.tabPage1.Controls.Add(this.txbBillID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnMake);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Location = new System.Drawing.Point(280, 25);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(35, 13);
            this.lblyear.TabIndex = 8;
            this.lblyear.Text = "Year :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Duration :";
            // 
            // txbYear
            // 
            this.txbYear.Location = new System.Drawing.Point(332, 18);
            this.txbYear.Name = "txbYear";
            this.txbYear.Size = new System.Drawing.Size(100, 20);
            this.txbYear.TabIndex = 7;
            this.txbYear.Text = "4";
            // 
            // txbDuration
            // 
            this.txbDuration.Location = new System.Drawing.Point(572, 21);
            this.txbDuration.Name = "txbDuration";
            this.txbDuration.Size = new System.Drawing.Size(100, 20);
            this.txbDuration.TabIndex = 10;
            this.txbDuration.Text = "5";
            // 
            // btnMake
            // 
            this.btnMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMake.Location = new System.Drawing.Point(30, 158);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(122, 41);
            this.btnMake.TabIndex = 6;
            this.btnMake.Text = "Generate";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(27, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 44);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sh.Ghabz :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(27, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sh.Pardakht :";
            // 
            // txbCompanyCode
            // 
            this.txbCompanyCode.Location = new System.Drawing.Point(333, 21);
            this.txbCompanyCode.Name = "txbCompanyCode";
            this.txbCompanyCode.Size = new System.Drawing.Size(101, 20);
            this.txbCompanyCode.TabIndex = 13;
            this.txbCompanyCode.Text = "584";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CustomerID :";
            // 
            // txbServiceTypeCode
            // 
            this.txbServiceTypeCode.Location = new System.Drawing.Point(573, 21);
            this.txbServiceTypeCode.Name = "txbServiceTypeCode";
            this.txbServiceTypeCode.Size = new System.Drawing.Size(101, 20);
            this.txbServiceTypeCode.TabIndex = 14;
            this.txbServiceTypeCode.Text = "4";
            // 
            // txbToPay
            // 
            this.txbToPay.Location = new System.Drawing.Point(106, 17);
            this.txbToPay.Name = "txbToPay";
            this.txbToPay.Size = new System.Drawing.Size(100, 20);
            this.txbToPay.TabIndex = 1;
            this.txbToPay.Text = "218000";
            this.txbToPay.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Service Type Code :";
            // 
            // txbSubID
            // 
            this.txbSubID.Location = new System.Drawing.Point(107, 21);
            this.txbSubID.Name = "txbSubID";
            this.txbSubID.Size = new System.Drawing.Size(100, 20);
            this.txbSubID.TabIndex = 0;
            this.txbSubID.Text = "3044951";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Company Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ToPay :";
            // 
            // txbBillID
            // 
            this.txbBillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txbBillID.Location = new System.Drawing.Point(278, 226);
            this.txbBillID.Name = "txbBillID";
            this.txbBillID.Size = new System.Drawing.Size(456, 50);
            this.txbBillID.TabIndex = 17;
            // 
            // txbPayID
            // 
            this.txbPayID.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txbPayID.Location = new System.Drawing.Point(278, 290);
            this.txbPayID.Name = "txbPayID";
            this.txbPayID.Size = new System.Drawing.Size(456, 50);
            this.txbPayID.TabIndex = 18;
            // 
            // btnInterper
            // 
            this.btnInterper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInterper.Location = new System.Drawing.Point(536, 157);
            this.btnInterper.Name = "btnInterper";
            this.btnInterper.Size = new System.Drawing.Size(122, 41);
            this.btnInterper.TabIndex = 19;
            this.btnInterper.Text = "Interper";
            this.btnInterper.UseVisualStyleBackColor = true;
            this.btnInterper.Click += new System.EventHandler(this.btnInterper_Click);
            // 
            // chkVerify
            // 
            this.chkVerify.AutoSize = true;
            this.chkVerify.Location = new System.Drawing.Point(675, 180);
            this.chkVerify.Name = "chkVerify";
            this.chkVerify.Size = new System.Drawing.Size(52, 17);
            this.chkVerify.TabIndex = 20;
            this.chkVerify.Text = "Verify";
            this.chkVerify.UseVisualStyleBackColor = true;
            // 
            // chkFillzero
            // 
            this.chkFillzero.AutoSize = true;
            this.chkFillzero.Location = new System.Drawing.Point(167, 181);
            this.chkFillzero.Name = "chkFillzero";
            this.chkFillzero.Size = new System.Drawing.Size(83, 17);
            this.chkFillzero.TabIndex = 21;
            this.chkFillzero.Text = "Fill with zero";
            this.chkFillzero.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 402);
            this.tabControl1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbCompanyCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbServiceTypeCode);
            this.groupBox1.Controls.Add(this.txbSubID);
            this.groupBox1.Location = new System.Drawing.Point(30, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 56);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblyear);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbYear);
            this.groupBox2.Controls.Add(this.txbDuration);
            this.groupBox2.Controls.Add(this.txbToPay);
            this.groupBox2.Location = new System.Drawing.Point(30, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 58);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pay ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbYear;
        private System.Windows.Forms.TextBox txbDuration;
        private System.Windows.Forms.TextBox txbToPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbCompanyCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbServiceTypeCode;
        private System.Windows.Forms.TextBox txbSubID;
        private System.Windows.Forms.CheckBox chkFillzero;
        private System.Windows.Forms.CheckBox chkVerify;
        private System.Windows.Forms.Button btnInterper;
        private System.Windows.Forms.TextBox txbPayID;
        private System.Windows.Forms.TextBox txbBillID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

