using HomeTrader.Data.Models.Finance;
using System.Collections.Generic;

namespace HomeTrader.Models.DetailsVM
{
    public class CashFlowVM
    {
        public int CompanyId { get; set; }
        public IEnumerable <FinanceCashFlow> CashFlowRaports { get; set; }

        public readonly FinanceCashFlow CashFlowColumnDescription = new FinanceCashFlow();


    }
}
