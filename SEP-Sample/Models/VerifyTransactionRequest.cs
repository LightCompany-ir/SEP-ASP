namespace SEP_Sample.Models
{
    public class VerifyTransactionRequest
    {
        public required string RefNum { get; set; }
        public required string TerminalNumber { get; set; }
    }
}
