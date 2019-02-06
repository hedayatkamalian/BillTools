using System;
using System.Collections.Generic;
using System.Text;

namespace BillTools
{
    public class Shenase_Interperter
    {
        public bool Initilized = false;

        // ---------------------------------------- Bill ID -------------------------------------
        public int CustomerID { get; set; }
        public int CompanyCode { get; set; }
        public int ServiceTypeCode { get; set; }
        public int BillID_ControlCode { get; set; }
        public string Full_BillID { get; }

        // ---------------------------------------- Pay ID -------------------------------------
        public int ValueToPay { get; set; }
        public int YearCode { get; set; }
        public int Duration { get; set; }
        public int PayID_ControlCode_1 { get; set; }
        public int PayID_ControlCode_2 { get; set; }
        public string Full_PayID { get; }


        public Shenase_Interperter ( string BillID , string PayID , bool Verify )
        {
            long TestDigit = 0;

            if (BillID.Length > 13 || BillID.Length < 6 || !long.TryParse(BillID , out TestDigit) )
            {
                throw new Exception("Bad Bill_ID");
            }

            if (PayID.Length > 13 || PayID.Length < 6 || !long.TryParse(BillID, out TestDigit))
            {
                throw new Exception("Bad Pay_ID");
            }

            BillID = FixLenght(BillID);
            PayID = FixLenght(PayID);

            // Make BillID parameters
            CustomerID          = int.Parse(BillID.Substring(0, 8));
            CompanyCode         = int.Parse(BillID.Substring(8, 3));
            ServiceTypeCode     = int.Parse(BillID.Substring(11, 1));
            BillID_ControlCode  = int.Parse(BillID.Substring(12, 1));


            // Make PayID prameters
            ValueToPay          = int.Parse(PayID.Substring(0, 8))*1000;
            YearCode            = int.Parse(PayID.Substring(8, 1));
            Duration            = int.Parse(PayID.Substring(9, 2));
            PayID_ControlCode_1 = int.Parse(PayID.Substring(11, 1));
            PayID_ControlCode_2 = int.Parse(PayID.Substring(12, 1));

            if (Verify)
            {
                if (!Verify_BillID_PayID(BillID, PayID))
                    throw new Exception("BillID or PayID in not valid");
            }

            this.Full_BillID = BillID;
            this.Full_PayID = PayID;

            Initilized = true;
        }

        public Shenase_Interperter() { }

        private string FixLenght (string input)
        {
            while (input.Length < 13)
                input = '0' + input;

            return input;
        }



        public  bool Verify_BillID_PayID (string BillID , string PayID)
        {
            bool RetValue = false;

            Shenase ToVer = new Shenase(ServiceTypeCode, CompanyCode, YearCode, Duration);
            string[] ToVerShenase  = ToVer.Generate_BillID_PayID(CustomerID, ValueToPay, true);

            if (BillID.TrimStart('0') == ToVerShenase[0].TrimStart('0') && PayID.TrimStart('0') == ToVerShenase[1].TrimStart('0'))
            {
                RetValue = true;
            }

            return RetValue;

        }




    }
}
