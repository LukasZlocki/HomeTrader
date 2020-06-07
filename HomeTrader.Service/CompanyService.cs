using HomeTrader.Data;
using HomeTrader.Data.Models.Companies;
using System.Collections.Generic;
using System.Linq;

namespace HomeTrader.Service
{
    public class CompanyService : ICompany
    {
        private readonly ApplicationDbContext _db;
        public CompanyService(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<GpwCompany> GetAllCompanies()
        {
            var service = _db.Company.ToList();          
            return service;
        }

        public GpwCompany GetCompanyById(int id)
        {
            var service = _db.Company.Where(c => c.Id == id).First();
            return service;
        }

        public IEnumerable<GpwCompany> SortCompaniesByIndex(int index)
        {
            string _sort = "";
            if (index == 1) { _sort = "Wig20"; }
            if (index == 2) { _sort = "mWig40"; }
            if (index == 3) { _sort = "sWig80"; }
            var service = _db.Company.Where(c => c.Index == _sort).ToList();
            return service;
        }


    }
}
