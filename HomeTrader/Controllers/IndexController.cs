using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeTrader.Data;
using HomeTrader.Models.DetailsVM;
using Microsoft.AspNetCore.Mvc;

namespace HomeTrader.Controllers
{
    public class IndexController : Controller
    {
        private readonly ICompany _companyService;

        public IndexController(ICompany companyService)
        {
            _companyService = companyService;
        }


        public IActionResult Index(int id)
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