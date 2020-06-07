using HomeTrader.Data.Models.Finance;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTrader.Data
{
    public interface IFinance
    {
        IEnumerable<FinanceCashFlow> GetCashFlowRaportsByCompanyId(int id);
        IEnumerable<FinanceBalance> GetBalanceRaportsByCompanyId(int id);
        IEnumerable<FinanceProfitAndLose> GetProfitAndLoseRaportsByCompanyId(int id);

    }
}
