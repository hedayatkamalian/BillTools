# BillTools
# یک کتابخانه برای تعریف و تفسیر شناسه قبض و شناسه پرداخت قبوض به زبان C#

به کمک این  کتابخانه میتوانید شناسه قبض و شناسه پرداخت های معتبر[( طبق قوانین بانک مرکزی ایران )](https://www.tavanir.org.ir/dm/dmmoshtarekin/doc/bill850530.pdf) برای درج بر روی  قبض تولید کنید
 همچنین میتوانید یک شناسه قبض و یا شناسه پرداخت را تفسیر کنید
 
 به کمک این کتابخانه کلیه قبوض
- آب
- برق
- گاز
- تلفن ثابت
- تلفن همراه
- جرایم راهنمایی و رانندگی
- ...
قابل تولید است 

>  توصیه میشود پیش از شروع کار با این کتابخانه مستندات طرح پرداخت هماهنگ قبوض را مطالعه فرمایید 

برای تولید شناسه ها کافی است مقادیر تشکیل دهنده آن را در سازنده وارد کنید
 رقم های کنترلی محاسبه شده و شناسه ها به صورت یک آرایه دوتایی از رشته ها بر گردانده میشوند

```
 
Shenase Sh = new Shenase( 4 , 581, 7 , 5);
            
string[] Temp = Sh.Generate_BillID_PayID(3044951, 218000 , true );

            txbBillID.Text = Temp[0];
            txbPayID.Text = Temp[1];
```

برای تفسیر یک شناسه از کلاس Shenase_interperter استفاده میکینم 

```
Shenase_Interperter SH = new Shenase_Interperter(txbBillID.Text, txbPayID.Text, chkVerify.Checked);

                txbSubID.Text = SH.CustomerID.ToString();
                txbCompanyCode.Text = SH.CompanyCode.ToString();
                txbServiceTypeCode.Text = SH.ServiceTypeCode.ToString();

                txbToPay.Text = SH.ValueToPay.ToString();
                txbYear.Text = SH.YearCode.ToString();
                txbDuration.Text = SH.Duration.ToString();
```
