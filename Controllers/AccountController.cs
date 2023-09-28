using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Registrarse.Models;

namespace Registrarse.Controllers;

public class AccountController : Controller
{

    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }


    public IActionResult IniciarSesion()
    {   
       
        return View();
    }
}