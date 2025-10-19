using System.Diagnostics;

namespace SEP_Sample.Models
{
    public class VerifyTransactionResponse
    {
        //جزئیات تراکنش
        public VerifyInfo? TransactionDetail { get; set; }
        //کد پاسخ
        public int? ResultCode { get; set; }
        //شرح پاسخ
        public string? ResultDescription { get; set; }
        //موفق یا ناموفق بودن درخواست
        public bool Success { get; set; }
    }
    public class VerifyInfo
    {
        public string RRN { get; set; }
        public string RefNum { get; set; }
        // شماره کارت به صورت ماسک شده
        public string MaskedPan { get; set; }
        //شماره کارت به صورت هش شده
        public string HashedPan { get; set; }
        //شماره ترمینال
        public int TerminalNumber { get; set; }
        // مبلغ ارسال شده به درگاه
        public Int64 OrginalAmount { get; set; }
        // مبلغ کسر شده از صاحب کارت
        public Int64 AfiectiveAmount { get; set; }
        //تاریخ تراکنش
        public string StraceDate { get; set; }
        //کد رهگیری
        public string StraceNo { get; set; }
    }
}
