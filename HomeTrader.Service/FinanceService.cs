using HomeTrader.Data;
using HomeTrader.Data.Models.Finance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTrader.Service
{
    public class FinanceService : IFinance
    {
        private readonly ApplicationDbContext _db;
        public FinanceService(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET - Balance
        public IEnumerable<FinanceCashFlow> GetCashFlowRaportsByCompanyId(int id)
        {
            var financeService = _db.CashFlow.Where(c => c.CompanyId == id)
                .OrderByDescending(c => c.RaportYear)
                .ToList();

            return financeService;
        }

        // GET - Cash Flow
        public IEnumerable<FinanceBalance> GetBalanceRaportsByCompanyId(int id)
        {
            var financeService = _db.Balance.Where(b => b.CompanyId == id)
                .OrderByDescending(b => b.RaportYear)
                .ToList();
            return financeService;
        }

        // GET = Profit and lose
        public IEnumerable<FinanceProfitAndLose> GetProfitAndLoseRaportsByCompanyId(int id)
        {
            var financeService = _db.ProfitAndLose.Where(p => p.CompanyId == id)
                .OrderByDescending(p => p.RaportYear)
                .ToList();

            return financeService;
        }


    }
}
