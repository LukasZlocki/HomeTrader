using HomeTrader.Data.Models.Companies;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTrader.Data
{
    public interface ICompany
    {
        GpwCompany GetCompanyById(int id);
        IEnumerable<GpwCompany> GetAllCompanies();
        IEnumerable<GpwCompany> SortCompaniesByIndex(int index);
    }
}
