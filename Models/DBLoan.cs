using System;

namespace CoreWebAPIApp.API.Models
{
    public class DBLoan
    {
        public string ID { get; set; }
        public float LoanSize { get; set; }
        public DateTime RepaymentTime { get; set; }
    }
}
