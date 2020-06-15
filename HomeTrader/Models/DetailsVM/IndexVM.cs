using HomeTrader.Data.Models.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTrader.Models.DetailsVM
{
    public class IndexVM
    {
        public int CompanyId { get; set; }
        public GpwCompany Company { get; set; }
    }
}
