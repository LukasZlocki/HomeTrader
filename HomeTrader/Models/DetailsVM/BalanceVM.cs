using HomeTrader.Data.Models.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTrader.Models.DetailsVM
{
    public class BalanceVM
    {
        public int CompanyId { get; set; }
        public IEnumerable<FinanceBalance> BalanceRaports { get; set; }

        public readonly FinanceBalance BalanceColumnDescription = new FinanceBalance();

    }
}
