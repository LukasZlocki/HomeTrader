using HomeTrader.Data;
using HomeTrader.Models.CompanyVM;
using HomeTrader.Models.DetailsVM;
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

        //GET - all companies
        public IActionResult Index()
        {

            CompaniesListViewModel companiesListVM = new CompaniesListViewModel()
            {
                Companies = _companyService.GetAllCompanies()
            };

            return View("Company",companiesListVM);
        }

        // GET - Company by Wig Index
        public IActionResult IndexSort(int id)
        {
            CompaniesListViewModel sortCompaniesListVM = new CompaniesListViewModel()
            {
                Companies = _companyService.SortCompaniesByIndex(id)
            };

            return View("Company",sortCompaniesListVM); 
        }


        public IActionResult Company(int id)
        {
            IndexVM CompanyInfoVM = new IndexVM
            {
                CompanyId = id,
                Company = _companyService.GetCompanyById(id)

            };
            return View("Index", CompanyInfoVM);
        }

    }
}