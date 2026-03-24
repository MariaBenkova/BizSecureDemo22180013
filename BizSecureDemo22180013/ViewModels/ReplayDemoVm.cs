namespace BizSecureDemo22180013.ViewModels
{
    public class ReplayDemoVm
    {
        public string Nonce { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public string? Message { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; } = 100;
        public string Token { get; set; } = "SECRET123";
    }
}