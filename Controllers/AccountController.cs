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
       
        return View("IniciarSesion");
    }

     [HttpPost]
     public IActionResult CheckIniciarSesion(string Usuario, string Contraseña)
    {   
        //la logica de chequear usuario y contraseña en base de datos con verificar usuario
        if(BD.verificarUsuario(Usuario, Contraseña) != null)
        {
            return View("Inicio");
        }
        else
            {
                ViewBag.error="login Incorrecto";
                return View("IniciarSesion");
            }
            return View();
    }

    
    public IActionResult OlvideContraseña(string email)
    {
        return View();
    }

    [HttpPost]  public IActionResult CheckOlvideContraseña(string email)
    {
        if(BD.verificarEmail(email) != null)
        {
           return View("dsfdsgv");
            
        }else
        {
            ViewBag.noexiste = "No tiene ninguna cuenta registrada con este mail";
            return View("OlvideContraseña");
        }
        return View();
    }
    public IActionResult UsuarioNuevo(string contraseña1 ,string  contraseña2)
    {   
        
        return View();
    }


    public IActionResult Inicio ()
    {
        return View();
    }


    
}