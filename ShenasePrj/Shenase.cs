using System;
//using System.Linq;

namespace BillTools
{
    /// <summary>
    /// کلاسی برای تولید شناسه قبض و شناسه پرداخت قبوض خدماتی
    /// </summary>
    public class Shenase
    {
        private int _ServiceType = 1;
        private int _CompanyCode = 111;
        private int _YearCode = 0;
        private int _DurationCode = 1;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ServiceTypeCode">کد نوع سرویس</param>
        /// <param name="CompanyCode"> کد سه رقمی شرکت تابعه</param>
        /// <param name="YearCode"> رقم یکان سال</param>
        /// <param name="DurationCode"> دوره صدور صورتحساب</param>
        public Shenase(int ServiceTypeCode , int CompanyCode , int YearCode , int DurationCode , bool Validate )
        {
            #region Validation

            if (Validate)
            {
                if (ServiceTypeCode < 1 || ServiceTypeCode > 9)
                {
                    throw new Exception("ServiceTypeCode Type must between 1 to 9");
                }

                if (CompanyCode < 100 || CompanyCode > 999)
                {
                    throw new Exception("CompanyCode Type must between 100 to 999");
                }

                if (YearCode < 0 || YearCode > 9)
                {
                    throw new Exception("YearCode Type must between 0 to 9");
                }

                if (DurationCode < 1 || DurationCode > 12)
                {
                    throw new Exception("DurationCode Type must between 1 to 12");
                }
            }

          

            #endregion

            _ServiceType = ServiceTypeCode;
            _CompanyCode = CompanyCode;
            _YearCode = YearCode;
            _DurationCode = DurationCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SubID">شماره اشتراک ( پرونده ) مشترک</param>
        /// <param name="ValueToPay"> مبلغ صورت حساب</param>
        /// <param name="FillWithZero"> پر کردن با صفر </param>
        /// <returns> شناسه قبض در عنصر اول / شناسه پرداخت در عنصر دوم </returns>
        public string[] Generate_BillID_PayID (int SubID , double ValueToPay , bool FillWithZero)
        {
            #region Validation

            if (SubID < 1 || SubID > 99999999)
            {
                throw new Exception("SubID Type must between 1 to 99999999");
            }

            if (ValueToPay < 1 || ValueToPay > 99999999)
            {
                throw new Exception("ValueToPay Type must between 1 to 99999999");
            }

            #endregion

            string[] RetValue = new string[2];


            string CompanyCodeString = _CompanyCode.ToString();

            while (CompanyCodeString.Length < 3)
            {
                CompanyCodeString = "0" + CompanyCodeString;
            }

            string Bill = SubID.ToString()  + CompanyCodeString + _ServiceType.ToString();
            Bill = Bill + ControlDigit(Bill);

            string Dur = _DurationCode.ToString();
            if (Dur.Length < 2)
            {
                Dur = "0" + Dur;
            }

            string Pay = ((int)(ValueToPay / 1000)).ToString() + _YearCode.ToString() + Dur;

            Pay = Pay + ControlDigit(Pay);
            Pay = Pay + ControlDigit(Bill + Pay);

            if (FillWithZero)
            {
                Bill = ZeroFillr(Bill);
                Pay = ZeroFillr(Pay);
            }


            RetValue[0] = Bill;
            RetValue[1] = Pay;

            

            return RetValue;

        }

        private string ControlDigit (string InputString )
        {
            

            char[] CharSingleDigit = new char[InputString.Length];

            /*
            for (int i=0; i < InputString.Length; i++)
            {
                CharSingleDigit[i] = InputString. .ElementAt(i);
            }

            */

            CharSingleDigit = InputString.ToCharArray();


            int MultiPlay = 2;
            int SUM = 0;

            for (int j= CharSingleDigit.Length - 1 ; j>=0 ; j--)
            {
                //Console.WriteLine(string.Format("Sum = {0} + ( {1} * {2} ) ", SUM, int.Parse(CharSingleDigit[j].ToString()), MultiPlay)) ;
                SUM += int.Parse(CharSingleDigit[j].ToString()) * MultiPlay;
                MultiPlay++;



                if (MultiPlay > 7)
                    MultiPlay = 2;
            }

            //Console.WriteLine("--------------------------------------------------------\n");
            int Remain = (SUM % 11);
            int RetValue = -1;

            if (Remain == 0 || Remain == 1)
            {
                RetValue = 0;
            }
            else
            {
                RetValue = 11 - Remain;
            }


            return RetValue.ToString();

        }

        private string ZeroFillr(string Input)
        {
            while (Input.Length <= 13)
            {
                Input = "0" + Input;
            }

            return Input;
        }

    }
}
