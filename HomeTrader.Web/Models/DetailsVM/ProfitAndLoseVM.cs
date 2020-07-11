using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HomeTrader.Data.Models.Finance;

namespace HomeTrader.Models.DetailsVM
{
    public class ProfitAndLoseVM
    {
        public int CompanyId { get; set; }
        public IEnumerable<FinanceProfitAndLose> ProfitAndLoseRaports { get; set; }

        public readonly FinanceProfitAndLose ProfitAndLoseDescription = new FinanceProfitAndLose();
    }
}
