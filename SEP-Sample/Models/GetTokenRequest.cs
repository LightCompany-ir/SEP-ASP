namespace SEP_Sample.Models
{
    public class GetTokenRequest
    {
        //نوع عملیات درخواستی
        //مقدار آن باید توکن باشد
        // به حروف بزرگ و کوچک حساس نیست
        public required string Action { get; set; } // = SEP TOKEN
        //مبلغ
        public required int Amount { get; set; }
        //کارمزد - اختیاری است
        public int? Wage { get; set; }
        //مبلغی که از کارت خریدار کسر شده است
        //فقط برای پذیرندگانی که از سامانه تخفیف استفاده می کنند
        public int? AffectiveAmount { get; set; }
        //شماره ترمینال فروشنده
        public required string TerminalId { get; set; }
        //شماره یکتا برای جلوگیری از تکرار تراکنش و قابلیت استعلام
        public required string? ResNum { get; set; }
        //لینک دریافت نتیجه درخواست
        public required string RedirectURL { get; set; }
        //شماره موبایل کاربر
        //اگر کاربر با این شماره کارتی ذخیره کرده باشد نمایش داده می شود
        public string? CellNumber { get; set; }
        //مدت زمان اعتبار توکن که به صورت پیشفرض 20 دقیقه است
        //بازه قابل انتخاب از 20 دقیقه تا 3600 دقیقه است
        //اگر ارسال نشود همان 20 دقیقه در نظر گرفته می شود
        public int? TokenExpiryInMin { get; set; } = 20;
        public string? HashedCardNumber { get; set; }
    }

    public class GetTokenResponse
    {
        // 1 : Success موفق
        // -1: Error ناموفق
        public int status { get; set; }
        // اگر موفق بود
        public string? token { get; set; }
        // اگر ناموفق بود
        //کد خطا
        public int? errorCode { get; set; }
        // متن خطا
        public string? errorDesc { get; set; }
    }
}
