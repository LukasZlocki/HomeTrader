using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeTrader.Data;
using HomeTrader.Models.DetailsVM;
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
                CompanyId = id,
                CashFlowRaports = _financeService.GetCashFlowRaportsByCompanyId(id)
            };

            return View("CashFlow", CashFlowRaportVM);
        }

        public IActionResult GetBalance(int id)
        {
            BalanceVM BalanceRaportVM = new BalanceVM
            {
                CompanyId = id,
                BalanceRaports = _financeService.GetBalanceRaportsByCompanyId(id)
            };

            return View("Balance", BalanceRaportVM);
        }

    }
}