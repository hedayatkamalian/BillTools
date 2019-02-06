using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCodeSub
{
    public partial class SendBill : Form
    {
        public SendBill()
        {
            InitializeComponent();
        }

        private void btnDurationBill_Click(object sender, EventArgs e)
        {
            ezService.TCI_SerClient SC = new ezService.TCI_SerClient();
            string R = SC.GetBillInfo("hedayat", "ILUT@325", "5832233128", 1);
        }
    }
}
