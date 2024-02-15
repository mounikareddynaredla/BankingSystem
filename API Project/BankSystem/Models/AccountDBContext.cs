using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIInMemoryDB.Models
{
    public class AccountDBContext : DbContext
    {
        public DbSet<BankAccountModel> Accounts { get; set; }

        public AccountDBContext(DbContextOptions<AccountDBContext> options)
            : base(options)
        {

        }
    }
}
