using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeTrader.Data;
using HomeTrader.Models.FinanceVM;
using Microsoft.AspNetCore.Mvc;

namespace HomeTrader.Controllers
{
    public class DetailsController : Controller
    {
        private readonly IFinance _financeService;
       // private readonly ICompany _companyService;

        public DetailsController(IFinance financeService)
        {
            _financeService = financeService;
        }

        // GET - tutaj wypisac pobranie podstawowych danych o spolce
        public IActionResult Index(int id)
        {
            var vm = new IndexVM()
            {
                Id = id
        };
            return View("Index",vm);
        }

        public IActionResult GetCashFlow(int id)
        {
            CashFlowVM CashFlowRaportVM = new CashFlowVM()
            {
                CashFlowRaports = _financeService.GetCashFlowRaportsByCompanyId(id)
            };

            return View("CashFlow", CashFlowRaportVM);
        }

    }
}