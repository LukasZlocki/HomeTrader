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
        

        public DetailsController(IFinance financeService)
        {
            _financeService = financeService;
        }

        // GET - tutaj wypisac pobranie podstawowych danych o spolce
        public IActionResult Index(int id)
        {

            return View("Index");
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

        public IActionResult GetProfitAndLose(int id)
        {
            ProfitAndLoseVM ProfitAndLoseRaportVM = new ProfitAndLoseVM
            {
                CompanyId = id,
                ProfitAndLoseRaports = _financeService.GetProfitAndLoseRaportsByCompanyId(id)
            };

            return View("ProfitAndLose", ProfitAndLoseRaportVM);
        }


    }
}