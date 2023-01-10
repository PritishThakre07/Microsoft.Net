using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using BOL;
using BLL;
using LoanApp.Models;

namespace LoanApp.Controllers;

public class LoanController : Controller
{
    private readonly ILogger<LoanController> _logger;

    public LoanController(ILogger<LoanController> logger)
    {
        _logger = logger;
    }


    public IActionResult Index()
    {
        LoanOperational manager = new LoanOperational();
        List<Loan> alltype = manager.GetAllTypeLoans();
        this.ViewData["loans"] = alltype;
       Console.WriteLine(" Step Loan INde ");
        
        return View();
    }

    public IActionResult Details( int id)
    {
        LoanOperational manager = new LoanOperational();

        Loan onetype = manager.GetLoanDetailsById(id);

        this.ViewData["loan"] = onetype ;

       Console.WriteLine(" Step Loan Dtails ");


        return View();

    }



   

    
}

