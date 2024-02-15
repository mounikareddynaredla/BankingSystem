using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystemTestProject.Models
{
    public class AccountRequestModel
    {
        public long InitialBalance { get; set; }
        public string AccountName { get; set; }
        public string Address { get; set; }
    }
}
