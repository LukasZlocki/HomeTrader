using HomeTrader.Data.Models.Finance;
using System.Collections.Generic;

namespace HomeTrader.Models.FinanceVM
{
    public class CashFlowVM
    {
        public IEnumerable <FinanceCashFlow> CashFlowRaports { get; set; }

        public readonly FinanceCashFlow CashFlowColumnDescription = new FinanceCashFlow();


    }
}
