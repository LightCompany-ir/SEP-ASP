namespace SEP_Sample.Models
{
    //اگر با لینک ریدایرکت شود و توکن به صورت متغیر در لینک باشد دیگر GetMethod نداریم
    public class SendToSepViewModel
    {
        //توکن با درخواست بدست آمد
        public required string token { get; set; }
        //مشخص کردن نوع دریافت به صورت رشته
        //true : دریافت پاسخ به صورت GET
        //false: دریافت پاسخ به صورت POST
        //null OR empty: دریافت پاسخ به صورت POST
        public string? GetMethod { get; set; }
    }
}
