using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystemTestProject.Models
{
    public class AccountResponseModel
    {
        public long Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public long NewBalance { get; set; }
        public string Message { get; set; }
        public string Errors { get; set; }
    }
}
