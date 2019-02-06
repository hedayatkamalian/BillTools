using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using BillTools;

namespace BarCodeSub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMake_Click(object sender, EventArgs e)
        {

            try
            {

            
            Shenase Sh = new Shenase(int.Parse(txbServiceTypeCode.Text), int.Parse(txbCompanyCode.Text), int.Parse(txbYear.Text), int.Parse(txbDuration.Text));
            

            string[] Temp = Sh.Generate_BillID_PayID(int.Parse(txbSubID.Text), double.Parse(txbToPay.Text) , chkFillzero.Checked);

            txbBillID.Text = Temp[0];
            txbPayID.Text = Temp[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInterper_Click(object sender, EventArgs e)
        {
            try
            {
                Shenase_Interperter SH = new Shenase_Interperter(txbBillID.Text, txbPayID.Text, chkVerify.Checked);

                txbSubID.Text = SH.CustomerID.ToString();
                txbCompanyCode.Text = SH.CompanyCode.ToString();
                txbServiceTypeCode.Text = SH.ServiceTypeCode.ToString();

                txbToPay.Text = SH.ValueToPay.ToString();
                txbYear.Text = SH.YearCode.ToString();
                txbDuration.Text = SH.Duration.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
