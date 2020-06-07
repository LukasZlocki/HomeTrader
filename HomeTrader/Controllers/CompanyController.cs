using HomeTrader.Data;
using HomeTrader.Models.Company;
using Microsoft.AspNetCore.Mvc;

namespace HomeTrader.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompany _companyService;

        public CompanyController(ICompany companyService)
        {
            _companyService = companyService;
        }

        public IActionResult Index()
        {

            CompaniesListViewModel companiesListVM = new CompaniesListViewModel()
            {
                Companies = _companyService.GetAllCompanies()
            };

            return View("Company",companiesListVM);
        }

        public IActionResult IndexSort(int sortId)
        {
            CompaniesListViewModel companiesListVM = new CompaniesListViewModel() 
            {
                Companies = _companyService.SortCompaniesByIndex(sortId)
            };
            return View(companiesListVM);
        }

    }
}