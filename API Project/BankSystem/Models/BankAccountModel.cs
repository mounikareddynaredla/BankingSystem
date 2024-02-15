using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIInMemoryDB.Models
{
    public class BankAccountModel
    {
        public int Id { get; set; }

        [Required]
        public string AccountName { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        public int NewBalance { get; set; }

        public string Message { get; set; }

        public string Errors { get; set; }
        

    }
}
