namespace BarCodeSub
{
    partial class SendBill
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
            this.txbtelno = new System.Windows.Forms.TextBox();
            this.btnDurationBill = new System.Windows.Forms.Button();
            this.btnOnlineBill = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbtelno
            // 
            this.txbtelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txbtelno.Location = new System.Drawing.Point(50, 32);
            this.txbtelno.Name = "txbtelno";
            this.txbtelno.Size = new System.Drawing.Size(190, 33);
            this.txbtelno.TabIndex = 0;
            // 
            // btnDurationBill
            // 
            this.btnDurationBill.Location = new System.Drawing.Point(258, 32);
            this.btnDurationBill.Name = "btnDurationBill";
            this.btnDurationBill.Size = new System.Drawing.Size(75, 33);
            this.btnDurationBill.TabIndex = 1;
            this.btnDurationBill.Text = "button1";
            this.btnDurationBill.UseVisualStyleBackColor = true;
            this.btnDurationBill.Click += new System.EventHandler(this.btnDurationBill_Click);
            // 
            // btnOnlineBill
            // 
            this.btnOnlineBill.Location = new System.Drawing.Point(355, 32);
            this.btnOnlineBill.Name = "btnOnlineBill";
            this.btnOnlineBill.Size = new System.Drawing.Size(75, 33);
            this.btnOnlineBill.TabIndex = 2;
            this.btnOnlineBill.Text = "button2";
            this.btnOnlineBill.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 356);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SendBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 424);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnOnlineBill);
            this.Controls.Add(this.btnDurationBill);
            this.Controls.Add(this.txbtelno);
            this.Name = "SendBill";
            this.Text = "SendBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbtelno;
        private System.Windows.Forms.Button btnDurationBill;
        private System.Windows.Forms.Button btnOnlineBill;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
    }
}