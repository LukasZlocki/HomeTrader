using HomeTrader.Data.Models.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTrader.Models.Company
{
    public class CompaniesListViewModel
    {
        public IEnumerable<GpwCompany> Companies { get; set; }
       
        public readonly GpwCompany CompaniesName = new GpwCompany();
    }
}
