using System;
using System.Collections.Generic;
using System.Text;
using HomeTrader.Data.Models.Companies;
using HomeTrader.Data.Models.Finance;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeTrader.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }
        public DbSet<GpwCompany> Company { get; set; }
        // public DbSet<FinanceProfitAndLose> ProfitAndLose { get; set; }
        // public DbSet<FinanceCashFlow> CashFlow { get; set; }
        // public DbSet<FinanceBalance> Balance { get; set; }
    
    }
}
