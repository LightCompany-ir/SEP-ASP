namespace SEP_Sample.Models
{
    //همیشه با post دریافت می شود
    public class PayResponse
    {
        //شماره ترمینال
        public int MID { get; set; }
        // وضعیت تراکنش به انگلیسی
        public string State { get; set; }
        //وضعیت تراکنش به عدد
        public int Status { get; set; }
        //شماره مرجع
        public string RRN { get; set; }
        //رسید دیجیتالی خرید
        public string RefNum { get; set; }
        //شماره خرید
        public string ResNum { get; set; }
        //شماره ترمینال 
        public string TerminalId { get; set; }
        //شماره رهگیری
        public string TraceNo { get; set; }
        //مبلغ
        public int Amount { get; set; }
        //کارمزد
        public int Wage { get; set; }
        //شماره کارتی که با آن پرداخت انجام شده است
        public string SecurePan { get; set; }
        //شماره کارت هش شده SHA256
        public string HashedCardNumber { get; set; }

        public string GetStatusMessage()
        {
            string rslt = string.Empty;

            switch (Status)
            {
                case 1:
                    rslt = " کاربر انصراف داده است ";
                    break;
                case 2:
                    rslt = " پرداخت با موفقیت انجام شد ";
                    break;
                case 3:
                    rslt = " پرداخت انجام نشد ";
                    break;
                case 4:
                    rslt = " کاربر در بازه زمانی تعیین شده پاسخی ارسال نکرده است ";
                    break;
                case 5:
                    rslt = " پارامتر های ارسالی نامعتبر است ";
                    break;
                case 8:
                    rslt = " آدرس سرور پذیرنده نامعتبر است ";
                    break;
                case 10:
                    rslt = " توکن ارسال شده یافت نشد ";
                    break;
                case 11:
                    rslt = "توکن ارسال نشد";
                    break;
                case 12:
                    rslt = " شماره ترمینال یافت نشد ";
                    break;
                case 21:
                    rslt = " محدودیت های چند حسابی رعایت نشد ";
                    break;
                default:
                    rslt = "ارور نامشخص";
                    break;
            }

            return rslt;
        }
    }
}
